#r "nuget: FSharp.Data, 6.4.0"

open System

open FSharp.Data

type LspMetaModel = JsonProvider<"metaModel.json">

let metaModel = LspMetaModel.GetSample()

let uppercaseFirst (str: string) =
    match str with
    | "" -> ""
    | str when Char.IsAsciiLetterLower str[0] -> string (Char.ToUpperInvariant str[0]) + str[1..]
    | _ -> str

let docLines (doc: string option) : seq<string> =
    seq {
        match doc with
        | None -> ()
        | Some doc -> for line in doc.ReplaceLineEndings("\n").Split("\n") -> Security.SecurityElement.Escape(line)
    }

let jsonNs = "global.System.Text.Json"
let fsharpCoreNs = "global.FSharp.Core"
let lspTypesNs = "global.Amongonz.LspTypes"

type TypeKind =
    | KindBase
    | KindReference
    | KindArray
    | KindMap
    | KindAnd
    | KindOr
    | KindTuple
    | KindLiteral
    | KindStringLiteral
    | KindIntegerLiteral
    | KindBooleanLiteral

    static member FromKind(kind) =
        match kind with
        | "base" -> KindBase
        | "reference" -> KindReference
        | "array" -> KindArray
        | "map" -> KindMap
        | "and" -> KindAnd
        | "or" -> KindOr
        | "tuple" -> KindTuple
        | "literal" -> KindLiteral
        | "stringLiteral" -> KindStringLiteral
        | "integerLiteral" -> KindIntegerLiteral
        | "booleanLiteral" -> KindBooleanLiteral
        | _ -> invalidArg (nameof kind) ""

type BaseType =
    | BaseURI
    | BaseDocumentUri
    | BaseInt
    | BaseDecimal
    | BaseString
    | BaseBool

    static member FromName(name) =
        match name with
        | "URI" -> BaseURI
        | "DocumentUri" -> BaseDocumentUri
        | "integer"
        | "uinteger" -> BaseInt
        | "decimal" -> BaseDecimal
        | "RegExp"
        | "string" -> BaseString
        | "boolean" -> BaseBool
        | _ -> invalidArg (nameof name) ""

    member baseType.FSharpName =
        match baseType with
        | BaseURI -> "global.System.Uri"
        | BaseDocumentUri -> $"%s{lspTypesNs}.LspDocumentUri"
        | BaseInt -> $"%s{fsharpCoreNs}.int"
        | BaseDecimal -> $"%s{fsharpCoreNs}.double"
        | BaseString -> $"%s{lspTypesNs}.LspString"
        | BaseBool -> $"%s{fsharpCoreNs}.bool"

type TypeRefModel =
    | StructModel of LspMetaModel.Structure
    | EnumModel of LspMetaModel.Enumeration
    | AliasModel of LspMetaModel.TypeAliasis

    member model.Name =
        match model with
        | StructModel model -> model.Name
        | EnumModel model -> model.Name
        | AliasModel model -> model.Name

let typeRefLookup =
    seq {
        for structModel in metaModel.Structures -> structModel.Name, StructModel structModel
        for enumModel in metaModel.Enumerations -> enumModel.Name, EnumModel enumModel
        for aliasModel in metaModel.TypeAliases -> aliasModel.Name, AliasModel aliasModel
    }
    |> readOnlyDict

let (|BaseAlias|RefAlias|ComplexAlias|BrokenAlias|) (aliasModel: LspMetaModel.TypeAliasis) =
    match TypeKind.FromKind aliasModel.Type.Kind, aliasModel.Type.Name with
    | KindBase, Some name -> BaseAlias(BaseType.FromName name)
    | KindReference, Some name -> RefAlias typeRefLookup[name]
    | _, None -> ComplexAlias
    | _ -> BrokenAlias

//
// Generated.fs
//

printfn $"// This file was auto-generated."
printfn $"namespace rec Amongonz.LspTypes"
printfn $""
printfn $"#nowarn \"44\" // Obsolete warnings"

//
// Enumerations
//

for enumModel in metaModel.Enumerations do
    printfn $""

    match TypeKind.FromKind enumModel.Type.Kind, enumModel.Type.Name with
    | KindBase, name ->
        match BaseType.FromName name with
        | BaseString ->
            for line in docLines enumModel.Documentation do
                printfn $"/// %s{line}"

            printfn $"[<%s{fsharpCoreNs}.Struct>]"
            printfn $"type %s{enumModel.Name}(element: %s{jsonNs}.JsonElement) ="
            printfn $"    member _.AsElement = element"
            printfn $"    member _.GetString() = element.GetString()"
            printfn $""
            printfn $"[<%s{fsharpCoreNs}.RequireQualifiedAccess>]"
            printfn $"module %s{enumModel.Name} ="

            for case in enumModel.Values do
                printfn $""

                for line in docLines case.Documentation do
                    printfn $"    /// %s{line}"

                let name = uppercaseFirst case.Name
                let literal = defaultArg case.Value.String ""

                printfn $"    [<return: Struct>]"
                printfn $"    let (|%s{name}|_|) (value: %s{enumModel.Name}) ="
                printfn $"        if value.AsElement.ValueEquals(%A{literal}) then"
                printfn $"            %s{fsharpCoreNs}.ValueSome()"
                printfn $"        else"
                printfn $"            %s{fsharpCoreNs}.ValueNone"

            printfn ""
            printfn $"type %s{enumModel.Name} with"

            if defaultArg enumModel.SupportsCustomValues false then
                printfn $"    static member Parse(element: %s{jsonNs}.JsonElement) ="
                printfn $"        match element.ValueKind with"
                printfn $"        | %s{jsonNs}.JsonValueKind.String ->"
                printfn $"            Ok(%s{enumModel.Name}(element))"
                printfn $"        | _ -> Error()"
            else
                printfn $"    static member Parse(element: %s{jsonNs}.JsonElement) ="
                printfn $"        match element.ValueKind with"
                printfn $"        | %s{jsonNs}.JsonValueKind.String ->"
                printfn $"            let value = %s{enumModel.Name}(element)"
                printfn $"            match value with"
                printf $"            "

                for case in enumModel.Values do
                    let name = uppercaseFirst case.Name
                    printf $"| %s{enumModel.Name}.%s{name} "

                printfn $"-> Ok(value)"
                printfn $"            | _ -> Error()"
                printfn $"        | _ -> Error()"
        | BaseInt ->
            for line in docLines enumModel.Documentation do
                printfn $"/// %s{line}"

            printfn $"type %s{enumModel.Name} ="

            for case in enumModel.Values do
                if case.Documentation.IsSome then
                    printfn $""

                for line in docLines case.Documentation do
                    printfn $"    /// %s{line}"

                let name = uppercaseFirst case.Name
                let literal = defaultArg case.Value.Number 0
                printfn $"    | %s{name} = %A{literal}"
        | _ -> failwith "Not implemented."
    | _ -> failwith "Not implemented."

printfn $""
printfn $"[<%s{fsharpCoreNs}.AutoOpen>]"
printfn $"module EnumerationExtensions ="

for enumModel in metaModel.Enumerations do
    match TypeKind.FromKind enumModel.Type.Kind, enumModel.Type.Name with
    | KindBase, name ->
        match BaseType.FromName name with
        | BaseInt ->
            printfn $""
            printfn $"    type %s{enumModel.Name} with"

            if defaultArg enumModel.SupportsCustomValues false then
                printfn $"        static member Parse(element: %s{jsonNs}.JsonElement) ="

                printfn $"            match element.ValueKind with"
                printfn $"            | %s{jsonNs}.JsonValueKind.Number ->"
                printfn $"                match element.TryGetInt32() with"

                printfn
                    $"                | true, value -> Ok(%s{fsharpCoreNs}.Operators.enum<%s{enumModel.Name}> value)"

                printfn $"                | false, _ -> Error()"
                printfn $"            | _ -> Error()"

            else
                printfn $"        static member Parse(element: %s{jsonNs}.JsonElement) ="

                printfn $"            match element.ValueKind with"
                printfn $"            | %s{jsonNs}.JsonValueKind.Number ->"
                printfn $"                match element.TryGetInt32() with"

                printfn
                    $"                | true, value when global.System.Enum.IsDefined(%s{fsharpCoreNs}.Operators.enum<%s{enumModel.Name}> value) ->"

                printfn $"                    Ok(%s{fsharpCoreNs}.Operators.enum<%s{enumModel.Name}> value)"

                printfn $"                | _ -> Error()"
                printfn $"            | _ -> Error()"
        | _ -> ()
    | _ -> ()

//
// Structures
//

for structModel in metaModel.Structures do
    printfn $""

    for line in docLines structModel.Documentation do
        printfn $"/// %s{line}"

    printfn $"[<Struct>]"
    printfn $"type %s{structModel.Name}(element: %s{jsonNs}.JsonElement) ="

    let properties =
        [| yield! structModel.Properties
           for ext in structModel.Extends do
               yield! metaModel.Structures |> Array.find _.Name.Equals(ext.Name) |> _.Properties
           for mix in structModel.Mixins do
               yield! metaModel.Structures |> Array.find _.Name.Equals(mix.Name) |> _.Properties |]
        |> Array.distinctBy _.Name

    printfn "    member _.AsElement = element"

    let mutable structNeedsSpecialization = false

    for prop in properties do
        printfn $""

        for line in docLines prop.Documentation do
            printfn $"    /// %s{line}"

        match prop.Deprecated with
        | None -> ()
        | Some msg -> printfn $"    [<global.System.Obsolete(%A{msg})>]"

        let name = uppercaseFirst prop.Name
        printfn $"    member _.{name} ="

        let propertyNeedsSpecialization, getValue =
            match TypeKind.FromKind prop.Type.Kind with
            | KindBase ->
                match BaseType.FromName prop.Type.Name.Value with
                | BaseURI -> false, $"%s{BaseURI.FSharpName}(prop.GetString())"
                | BaseDocumentUri -> false, $"%s{BaseDocumentUri.FSharpName}(prop.GetString())"
                | BaseString -> false, $"%s{BaseString.FSharpName}(prop)"
                | BaseInt -> false, "prop.GetInt32()"
                | BaseDecimal -> false, "prop.GetDouble()"
                | BaseBool -> false, "prop.GetBoolean()"
            | KindReference ->
                match typeRefLookup[prop.Type.Name.Value] with
                | StructModel structModel
                | AliasModel(RefAlias(StructModel structModel)) -> false, $"%s{structModel.Name}(prop)"
                | EnumModel enumModel
                | AliasModel(RefAlias(EnumModel enumModel)) ->
                    match TypeKind.FromKind enumModel.Type.Kind with
                    | KindBase ->
                        match BaseType.FromName enumModel.Type.Name with
                        | BaseString -> false, $"%s{enumModel.Name}(prop)"
                        | BaseInt -> false, $"enum<%s{enumModel.Name}>(prop.GetInt32())"
                        | name -> failwith $"Not implemented: KindBase, %A{name}"
                    | kind -> failwith $"Not implemented: %A{kind}"
                | AliasModel(BaseAlias BaseString as aliasModel) ->
                    false, $"(%s{BaseString.FSharpName}(prop): %s{aliasModel.Name})"
                | AliasModel(ComplexAlias _ as aliasModel) -> false, $"%s{aliasModel.Name}(prop)"
                | AliasModel(BaseAlias BaseInt as aliasModel) -> false, $"(prop.GetInt32(): %s{aliasModel.Name})"
                | AliasModel aliasModel -> failwith $"Not implemented: %s{aliasModel.Name}"
            | KindOr
            | KindArray
            | KindMap
            | KindLiteral
            | KindStringLiteral -> true, "prop"
            | kind -> failwith $"Unhandled type kind: %A{kind}"

        structNeedsSpecialization <- structNeedsSpecialization || propertyNeedsSpecialization

        if propertyNeedsSpecialization then
            printfn $"        // Complex type kind: %s{prop.Type.Kind}."
            printfn $""

        if defaultArg prop.Optional false then
            printfn $"        match element.TryGetProperty(%A{prop.Name}) with"
            printfn $"        | false, _ -> ValueNone"
            printfn $"        | true, prop -> ValueSome(%s{getValue})"
        else
            printfn $"        let prop = element.GetProperty(%A{prop.Name})"
            printfn $"        %s{getValue}"

    printfn $""
    printfn $"    static member Parse(element: %s{jsonNs}.JsonElement) ="

    if structNeedsSpecialization then
        printfn $"        Ok(%s{structModel.Name}(element))"
    else
        printfn $"        if"
        printfn $"            true"

        for prop in properties do
            let isPropValid =
                match TypeKind.FromKind prop.Type.Kind with
                | KindBase ->
                    match BaseType.FromName prop.Type.Name.Value with
                    | BaseURI
                    | BaseDocumentUri -> $"%s{lspTypesNs}.Validation.isValidUri prop"
                    | BaseString as baseType -> $"%s{fsharpCoreNs}.Result.isOk (%s{baseType.FSharpName}.Parse(prop))"
                    | BaseInt -> $"%s{lspTypesNs}.Validation.isValidInteger prop"
                    | BaseDecimal -> $"%s{lspTypesNs}.Validation.isValidDecimal prop"
                    | BaseBool -> $"%s{lspTypesNs}.Validation.isValidBool prop"
                | KindReference ->
                    match typeRefLookup[prop.Type.Name.Value] with
                    | StructModel structModel
                    | AliasModel(RefAlias(StructModel structModel)) ->
                        $"%s{fsharpCoreNs}.Result.isOk (%s{structModel.Name}.Parse(prop))"
                    | EnumModel enumModel
                    | AliasModel(RefAlias(EnumModel enumModel)) ->
                        match TypeKind.FromKind enumModel.Type.Kind with
                        | KindBase ->
                            match BaseType.FromName enumModel.Type.Name with
                            | BaseString -> $"%s{fsharpCoreNs}.Result.isOk (%s{enumModel.Name}.Parse(prop))"
                            | BaseInt -> "true"
                            | name -> failwith $"Not implemented: KindBase, %A{name}"
                        | kind -> failwith $"Not implemented: %A{kind}"
                    | AliasModel(BaseAlias BaseString) ->
                        $"%s{fsharpCoreNs}.Result.isOk (%s{BaseString.FSharpName}.Parse(prop))"
                    | AliasModel(BaseAlias BaseInt) -> $"%s{lspTypesNs}.Validation.isValidInteger prop"
                    | AliasModel(ComplexAlias _ as aliasModel) ->
                        $"%s{fsharpCoreNs}.Result.isOk (%s{aliasModel.Name}.Parse(prop))"
                    | AliasModel aliasModel -> failwith $"Not implemented: %s{aliasModel.Name}"
                | KindOr
                | KindArray
                | KindMap
                | KindLiteral
                | KindStringLiteral -> "true"
                | kind -> failwith $"Unhandled type kind: %A{kind}"

            printfn $"            && begin"

            printfn $"                %s{lspTypesNs}.Validation.optionalProperty %A{prop.Name} element"

            if defaultArg prop.Optional false then
                printfn $"                |> %s{fsharpCoreNs}.ValueOption.forall (fun prop -> %s{isPropValid})"
            else
                printfn $"                |> %s{fsharpCoreNs}.ValueOption.exists (fun prop -> %s{isPropValid})"

            printfn $"            end"

        printfn $"        then Ok(%s{structModel.Name}(element))"
        printfn $"        else Error()"

//
// Type aliases
//

for aliasModel in metaModel.TypeAliases do
    printfn $""

    for line in docLines aliasModel.Documentation do
        printfn $"/// {line}"

    match aliasModel.Deprecated with
    | None -> ()
    | Some msg -> printfn $"[<global.System.Obsolete(%A{msg})>]"

    match aliasModel with
    | BaseAlias baseType -> printfn $"type %s{aliasModel.Name} = %s{baseType.FSharpName}"
    | RefAlias model -> printfn $"type %s{aliasModel.Name} = %s{model.Name}"
    | ComplexAlias ->
        printfn $"[<%s{fsharpCoreNs}.Struct>]"
        printfn $"type %s{aliasModel.Name}(element: %s{jsonNs}.JsonElement) ="
        printfn $"    // Complex type kind: %s{aliasModel.Type.Kind}."
        printfn $""
        printfn $"    member _.AsElement = element"
        printfn $""
        printfn $"    static member Parse(element) = Ok(%s{aliasModel.Name}(element))"
    | BrokenAlias -> failwith "Broken alias."
