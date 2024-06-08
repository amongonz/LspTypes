#r "nuget: FSharp.Data, 6.4.0"

open System

open FSharp.Data

type LspMetaModel = JsonProvider<"metaModel.json">

let metaModel = LspMetaModel.GetSample()

let pascalCase (str: string) =
    match str with
    | "" -> ""
    | str when Char.IsAsciiLetterLower str[0] -> $"%c{Char.ToUpperInvariant str[0]}%s{str[1..]}"
    | _ -> str

let camelCase (str: string) =
    match str with
    | "" -> ""
    | str when Char.IsAsciiLetterUpper str[0] -> $"``%c{(Char.ToLowerInvariant str[0])}%s{str[1..]}``"
    | _ -> $"``%s{str}``"

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

let writer = new CodeDom.Compiler.IndentedTextWriter(stdout)
let printf fmt = fprintf writer fmt
let printfn fmt = fprintfn writer fmt

let indented action =
    writer.Indent <- writer.Indent + 1
    action ()
    writer.Indent <- writer.Indent - 1

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

            if defaultArg enumModel.SupportsCustomValues false then
                printfn $"type %s{enumModel.Name} = %s{lspTypesNs}.LspString"
            else
                printfn $"[<%s{fsharpCoreNs}.Struct; global.System.Runtime.CompilerServices.IsReadOnly>]"
                printfn $"type %s{enumModel.Name}(stringValue: %s{lspTypesNs}.LspString) ="

                indented (fun () ->
                    printfn $"static let validate value ="

                    indented (fun () ->
                        printfn $"match value with"

                        for case in enumModel.Values do
                            let name = pascalCase case.Name
                            printf $"| %s{enumModel.Name}.%s{name} "

                        printfn $"as value -> %s{fsharpCoreNs}.Ok(value)"

                        printfn $"| _ -> %s{fsharpCoreNs}.Error()")

                    printfn $""
                    printfn $"member _.GetBacking() = stringValue.GetBacking()"
                    printfn $"member _.WriteTo(writer) = stringValue.WriteTo(writer)"
                    printfn $""
                    printfn $"member _.StringValue = stringValue"
                    printfn $"member _.ValueEquals(other) = stringValue.ValueEquals(other)"
                    printfn $""
                    printfn $"static member FromElement(element) ="
                    indented (fun () -> printfn $"%s{enumModel.Name}(%s{lspTypesNs}.LspString.FromElement(element))")
                    printfn $""
                    printfn $"static member FromString(value) ="

                    indented (fun () ->
                        printfn $"match validate (%s{enumModel.Name}(value)) with"
                        printfn $"| %s{fsharpCoreNs}.Ok value -> value"
                        printfn $"| %s{fsharpCoreNs}.Error() ->"

                        indented (fun () ->
                            fprintfn
                                writer
                                $"%s{fsharpCoreNs}.Operators.invalidArg \"value\" \"Invalid string enum constant.\""))

                    printfn $""
                    printfn $"static member Parse(element: %s{jsonNs}.JsonElement) ="

                    indented (fun () ->
                        printfn $"match LspString.Parse(element) with"
                        printfn $"| %s{fsharpCoreNs}.Ok stringValue ->"
                        indented (fun () -> printfn $"validate (%s{enumModel.Name}(stringValue))")
                        printfn $"| %s{fsharpCoreNs}.Error() -> %s{fsharpCoreNs}.Error()"))

            printfn $""
            printfn $"[<%s{fsharpCoreNs}.RequireQualifiedAccess>]"
            printfn $"module %s{enumModel.Name} ="

            indented (fun () ->
                for case in enumModel.Values do
                    printfn $""

                    for line in docLines case.Documentation do
                        printfn $"/// %s{line}"

                    let name = pascalCase case.Name
                    let literal = defaultArg case.Value.String ""

                    printfn $"[<return: Struct>]"
                    printfn $"let (|%s{name}|_|) (value: %s{enumModel.Name}) ="

                    indented (fun () ->
                        printfn $"if value.ValueEquals(%A{literal}) then"
                        indented (fun () -> printfn $"%s{fsharpCoreNs}.ValueSome()")
                        printfn $"else"
                        indented (fun () -> printfn $"%s{fsharpCoreNs}.ValueNone")))
        | BaseInt ->
            for line in docLines enumModel.Documentation do
                printfn $"/// %s{line}"

            if defaultArg enumModel.SupportsCustomValues false then
                printfn $"type %s{enumModel.Name} = int"
                printfn $""
                printfn $"module %s{enumModel.Name} ="

                indented (fun () ->
                    for case in enumModel.Values do
                        printfn $""

                        for line in docLines case.Documentation do
                            printfn $"/// %s{line}"

                        let name = pascalCase case.Name
                        let literal = defaultArg case.Value.Number 0
                        printfn $"[<Literal>]"
                        printfn $"let %s{name} = %A{literal}")
            else
                printfn $"type %s{enumModel.Name} ="

                indented (fun () ->
                    for case in enumModel.Values do
                        if case.Documentation.IsSome then
                            printfn $""

                        for line in docLines case.Documentation do
                            printfn $"/// %s{line}"

                        let name = pascalCase case.Name
                        let literal = defaultArg case.Value.Number 0
                        printfn $"| %s{name} = %A{literal}")
        | _ -> failwith "Not implemented."
    | _ -> failwith "Not implemented."

printfn $""
printfn $"[<%s{fsharpCoreNs}.AutoOpen>]"
printfn $"module EnumerationExtensions ="

indented (fun () ->
    for enumModel in metaModel.Enumerations do
        match TypeKind.FromKind enumModel.Type.Kind, enumModel.Type.Name with
        | KindBase, name ->
            match BaseType.FromName name with
            | BaseInt when not (defaultArg enumModel.SupportsCustomValues false) ->
                printfn $""
                printfn $"type %s{enumModel.Name} with"

                indented (fun () ->
                    printfn $"static member FromElement(element: %s{jsonNs}.JsonElement) ="

                    indented (fun () ->
                        printfn $"%s{fsharpCoreNs}.Operators.enum<%s{enumModel.Name}> (element.GetInt32())")

                    printfn $""
                    printfn $"static member Parse(element: %s{jsonNs}.JsonElement) ="

                    indented (fun () ->
                        printfn $"match element.ValueKind with"
                        printfn $"| %s{jsonNs}.JsonValueKind.Number ->"

                        indented (fun () ->
                            printfn $"match element.TryGetInt32() with"

                            fprintfn
                                writer
                                $"| true, value when global.System.Enum.IsDefined(%s{fsharpCoreNs}.Operators.enum<%s{enumModel.Name}> value) ->"

                            indented (fun () ->
                                printfn
                                    $"%s{fsharpCoreNs}.Ok(%s{fsharpCoreNs}.Operators.enum<%s{enumModel.Name}> value)")

                            printfn $"| _ -> %s{fsharpCoreNs}.Error()")

                        printfn $"| _ -> %s{fsharpCoreNs}.Error()"))
            | _ -> ()
        | _ -> ())

//
// Structures
//

let fsharpInnerTypeForProperty (prop: LspMetaModel.Property) =
    match TypeKind.FromKind prop.Type.Kind with
    | KindBase -> BaseType.FromName(prop.Type.Name.Value).FSharpName
    | KindReference -> pascalCase typeRefLookup[prop.Type.Name.Value].Name
    | KindOr
    | KindArray
    | KindMap
    | KindLiteral
    | KindStringLiteral -> $"%s{lspTypesNs}.LspJsonBacking<ILspJsonBackingObj>"
    | kind -> failwith $"Unhandled type kind: %A{kind}"

let fsharpOuterTypeForProperty (prop: LspMetaModel.Property) =
    let inner = fsharpInnerTypeForProperty prop

    if defaultArg prop.Optional false then
        $"%s{inner} option"
    else
        inner

for structModel in metaModel.Structures do
    let properties =
        [|
            yield! structModel.Properties
            for ext in structModel.Extends do
                yield! metaModel.Structures |> Array.find _.Name.Equals(ext.Name) |> _.Properties
            for mix in structModel.Mixins do
                yield! metaModel.Structures |> Array.find _.Name.Equals(mix.Name) |> _.Properties
        |]
        |> Array.distinctBy _.Name

    let backingType =
        if properties.Length > 0 then
            printfn $""
            printfn $"type private I%s{pascalCase structModel.Name} ="

            indented (fun () ->
                printfn $"inherit %s{lspTypesNs}.ILspJsonBackingObj"

                for prop in properties do
                    printfn $"abstract %s{camelCase prop.Name}: %s{fsharpOuterTypeForProperty prop}")

            $"I%s{pascalCase structModel.Name}"
        else
            $"%s{lspTypesNs}.ILspJsonBackingObj"

    printfn $""

    for line in docLines structModel.Documentation do
        printfn $"/// %s{line}"

    printfn $"[<%s{fsharpCoreNs}.Struct; global.System.Runtime.CompilerServices.IsReadOnly>]"
    printfn $"type %s{pascalCase structModel.Name} private (backing: %s{lspTypesNs}.LspJsonBacking<%s{backingType}>) ="

    indented (fun () ->
        printfn $"member _.GetBacking() = backing.Boxed"
        printfn $"member _.WriteTo(writer) = backing.WriteTo(writer)"
        printfn $""
        printfn $"static member FromElement(element) ="
        indented (fun () -> printfn $"%s{structModel.Name}(%s{lspTypesNs}.LspJsonBacking.Element element)")

        let mutable structNeedsSpecialization = false

        for prop in properties do
            printfn $""

            for line in docLines prop.Documentation do
                printfn $"/// %s{line}"

            match prop.Deprecated with
            | None -> ()
            | Some msg -> printfn $"[<global.System.Obsolete(%A{msg})>]"

            printfn $"member _.%s{pascalCase prop.Name} ="

            indented (fun () ->
                let propertyNeedsSpecialization, getValue =
                    match TypeKind.FromKind prop.Type.Kind with
                    | KindBase ->
                        match BaseType.FromName prop.Type.Name.Value with
                        | BaseURI -> false, $"%s{BaseURI.FSharpName}(prop.GetString())"
                        | BaseDocumentUri -> false, $"%s{BaseDocumentUri.FSharpName}(prop.GetString())"
                        | BaseString -> false, $"%s{BaseString.FSharpName}.FromElement(prop)"
                        | BaseInt -> false, "prop.GetInt32()"
                        | BaseDecimal -> false, "prop.GetDouble()"
                        | BaseBool -> false, "prop.GetBoolean()"
                    | KindReference ->
                        match typeRefLookup[prop.Type.Name.Value] with
                        | StructModel structModel
                        | AliasModel(RefAlias(StructModel structModel)) ->
                            false, $"%s{structModel.Name}.FromElement(prop)"
                        | EnumModel enumModel
                        | AliasModel(RefAlias(EnumModel enumModel)) ->
                            match TypeKind.FromKind enumModel.Type.Kind with
                            | KindBase ->
                                match BaseType.FromName enumModel.Type.Name with
                                | BaseInt when defaultArg enumModel.SupportsCustomValues false ->
                                    false, $"(prop.GetInt32(): %s{enumModel.Name})"
                                | BaseString
                                | BaseInt -> false, $"%s{enumModel.Name}.FromElement(prop)"
                                | name -> failwith $"Not implemented: KindBase, %A{name}"
                            | kind -> failwith $"Not implemented: %A{kind}"
                        | AliasModel(BaseAlias BaseString as aliasModel) ->
                            false, $"(%s{BaseString.FSharpName}.FromElement(prop): %s{aliasModel.Name})"
                        | AliasModel(ComplexAlias _ as aliasModel) -> false, $"%s{aliasModel.Name}.FromElement(prop)"
                        | AliasModel(BaseAlias BaseInt as aliasModel) ->
                            false, $"(prop.GetInt32(): %s{aliasModel.Name})"
                        | AliasModel aliasModel -> failwith $"Not implemented: %s{aliasModel.Name}"
                    | KindOr
                    | KindArray
                    | KindMap
                    | KindLiteral
                    | KindStringLiteral -> true, "LspJsonBacking.Element prop"
                    | kind -> failwith $"Unhandled type kind: %A{kind}"

                structNeedsSpecialization <- structNeedsSpecialization || propertyNeedsSpecialization

                if propertyNeedsSpecialization then
                    printfn $"// Complex type kind: %s{prop.Type.Kind}."
                    printfn $""

                if defaultArg prop.Optional false then
                    printfn $"match backing with"
                    printfn $"| LspJsonBacking.Obj backingObj ->"

                    indented (fun () ->
                        printfn $"match backingObj.%s{camelCase prop.Name} with"
                        printfn $"| None -> ValueNone"
                        printfn $"| Some value -> ValueSome value")

                    printfn $"| LspJsonBacking.Element elem ->"

                    indented (fun () ->
                        printfn $"match elem.TryGetProperty(%A{prop.Name}) with"
                        printfn $"| false, _ -> ValueNone"
                        printfn $"| true, prop -> ValueSome(%s{getValue})")
                else
                    printfn $"match backing with"
                    printfn $"| LspJsonBacking.Obj backingObj -> backingObj.%s{camelCase prop.Name}"
                    printfn $"| LspJsonBacking.Element elem ->"

                    indented (fun () ->
                        printfn $"let prop = elem.GetProperty(%A{prop.Name})"
                        printfn $"%s{getValue}"))

        printfn $""
        printf $"static member Create("

        if properties.Length > 0 then
            printfn $""

            indented (fun () ->
                let sortedProperties = [|
                    for prop in properties do
                        if not (defaultArg prop.Optional false) then
                            prop

                    for prop in properties do
                        if defaultArg prop.Optional false then
                            prop
                |]

                for p = 0 to sortedProperties.Length - 1 do
                    let prop = sortedProperties[p]

                    if defaultArg prop.Optional false then
                        printf $"?"

                    printf $"%s{camelCase prop.Name}: %s{fsharpInnerTypeForProperty prop}"

                    if p < sortedProperties.Length - 1 then
                        printfn $","
                    else
                        printfn $"")

        printfn $") ="

        indented (fun () ->
            printfn $"%s{structModel.Name}(%s{lspTypesNs}.LspJsonBacking.Obj("

            indented (fun () ->
                printfn $"{{ new %s{backingType} with"

                indented (fun () ->
                    for prop in properties do
                        let name = camelCase prop.Name
                        printfn $"member _.%s{name} = %s{name}"

                    printfn $""
                    printfn $"member _.WriteTo(``json writer``) ="

                    indented (fun () ->
                        printfn $"``json writer``.WriteStartObject()"

                        for prop in properties do
                            let writeProperty () =
                                match TypeKind.FromKind prop.Type.Kind with
                                | KindBase ->
                                    match BaseType.FromName prop.Type.Name.Value with
                                    | BaseBool ->
                                        printfn
                                            $"``json writer``.WriteBoolean(%A{prop.Name}, %s{camelCase prop.Name})"
                                    | BaseDecimal ->
                                        printfn
                                            $"``json writer``.WriteNumber(%A{prop.Name}, %s{camelCase prop.Name})"
                                    | BaseInt ->
                                        printfn
                                            $"``json writer``.WriteNumber(%A{prop.Name}, %s{camelCase prop.Name})"
                                    | BaseString ->
                                        printfn $"``json writer``.WritePropertyName(%A{prop.Name})"
                                        printfn $"%s{camelCase prop.Name}.WriteTo(``json writer``)"
                                    | BaseURI
                                    | BaseDocumentUri ->
                                        printfn
                                            $"``json writer``.WriteString(%A{prop.Name}, %s{camelCase prop.Name}.OriginalString)"
                                | KindReference ->
                                    match typeRefLookup[prop.Type.Name.Value] with
                                    | StructModel _
                                    | AliasModel(RefAlias(StructModel _)) ->
                                        printfn $"``json writer``.WritePropertyName(%A{prop.Name})"
                                        printfn $"%s{camelCase prop.Name}.WriteTo(``json writer``)"
                                    | EnumModel enumModel
                                    | AliasModel(RefAlias(EnumModel enumModel)) ->
                                        match TypeKind.FromKind enumModel.Type.Kind with
                                        | KindBase ->
                                            match BaseType.FromName enumModel.Type.Name with
                                            | BaseString ->
                                                printfn $"``json writer``.WritePropertyName(%A{prop.Name})"
                                                printfn $"%s{camelCase prop.Name}.WriteTo(``json writer``)"
                                            | BaseInt ->
                                                printfn
                                                    $"``json writer``.WriteNumber(%A{prop.Name}, int %s{camelCase prop.Name})"
                                            | name -> failwith $"Not implemented: KindBase, %A{name}"
                                        | kind -> failwith $"Not implemented: %A{kind}"
                                    | AliasModel(BaseAlias BaseString) ->
                                        printfn $"``json writer``.WritePropertyName(%A{prop.Name})"
                                        printfn $"%s{camelCase prop.Name}.WriteTo(``json writer``)"
                                    | AliasModel(BaseAlias BaseInt) ->
                                        printfn
                                            $"``json writer``.WriteNumber(%A{prop.Name}, %s{camelCase prop.Name})"
                                    | AliasModel(ComplexAlias _) ->
                                        printfn $"``json writer``.WritePropertyName(%A{prop.Name})"
                                        printfn $"%s{camelCase prop.Name}.WriteTo(``json writer``)"
                                    | AliasModel aliasModel -> failwith $"Not implemented: %s{aliasModel.Name}"
                                | KindOr
                                | KindArray
                                | KindMap
                                | KindLiteral
                                | KindStringLiteral ->
                                    printfn $"``json writer``.WritePropertyName(%A{prop.Name})"
                                    printfn $"%s{camelCase prop.Name}.WriteTo(``json writer``)"
                                | kind -> failwith $"Unhandled type kind: %A{kind}"

                            if defaultArg prop.Optional false then
                                printfn $"match %s{camelCase prop.Name} with"
                                printfn $"| %s{fsharpCoreNs}.None -> ()"
                                printfn $"| %s{fsharpCoreNs}.Some %s{camelCase prop.Name} ->"
                                indented writeProperty
                            else
                                writeProperty ()

                        printfn $"``json writer``.WriteEndObject()"))

                printfn $"}}")

            printfn $"))")

        printfn $""
        printfn $"static member Parse(element: %s{jsonNs}.JsonElement) ="

        indented (fun () ->
            if structNeedsSpecialization then
                printfn $"%s{fsharpCoreNs}.Ok(%s{structModel.Name}.FromElement(element))"
            else
                printfn $"if"

                indented (fun () ->
                    printfn $"true"

                    for prop in properties do
                        let writeIsValid () =
                            match TypeKind.FromKind prop.Type.Kind with
                            | KindBase ->
                                match BaseType.FromName prop.Type.Name.Value with
                                | BaseURI
                                | BaseDocumentUri -> printfn $"%s{lspTypesNs}.Validation.isValidUri prop"
                                | BaseString as baseType ->
                                    printfn $"%s{fsharpCoreNs}.Result.isOk (%s{baseType.FSharpName}.Parse(prop))"
                                | BaseInt -> printfn $"%s{lspTypesNs}.Validation.isValidInteger prop"
                                | BaseDecimal -> printfn $"%s{lspTypesNs}.Validation.isValidDecimal prop"
                                | BaseBool -> printfn $"%s{lspTypesNs}.Validation.isValidBool prop"
                            | KindReference ->
                                match typeRefLookup[prop.Type.Name.Value] with
                                | StructModel structModel
                                | AliasModel(RefAlias(StructModel structModel)) ->
                                    printfn $"%s{fsharpCoreNs}.Result.isOk (%s{structModel.Name}.Parse(prop))"
                                | EnumModel enumModel
                                | AliasModel(RefAlias(EnumModel enumModel)) ->
                                    match TypeKind.FromKind enumModel.Type.Kind with
                                    | KindBase ->
                                        match BaseType.FromName enumModel.Type.Name with
                                        | BaseString ->
                                            printfn $"%s{fsharpCoreNs}.Result.isOk (%s{enumModel.Name}.Parse(prop))"
                                        | BaseInt -> printfn $"true"
                                        | name -> failwith $"Not implemented: KindBase, %A{name}"
                                    | kind -> failwith $"Not implemented: %A{kind}"
                                | AliasModel(BaseAlias BaseString) ->
                                    printfn $"%s{fsharpCoreNs}.Result.isOk (%s{BaseString.FSharpName}.Parse(prop))"
                                | AliasModel(BaseAlias BaseInt) ->
                                    printfn $"%s{lspTypesNs}.Validation.isValidInteger prop"
                                | AliasModel(ComplexAlias _ as aliasModel) ->
                                    printfn $"%s{fsharpCoreNs}.Result.isOk (%s{aliasModel.Name}.Parse(prop))"
                                | AliasModel aliasModel -> failwith $"Not implemented: %s{aliasModel.Name}"
                            | KindOr
                            | KindArray
                            | KindMap
                            | KindLiteral
                            | KindStringLiteral -> printfn $"true"
                            | kind -> failwith $"Unhandled type kind: %A{kind}"

                        printfn $"&&"

                        indented (fun () ->
                            printfn $"%s{lspTypesNs}.Validation.optionalProperty %A{prop.Name} element"

                            if defaultArg prop.Optional false then
                                printfn $"|> %s{fsharpCoreNs}.ValueOption.forall (fun prop ->"
                            else
                                printfn $"|> %s{fsharpCoreNs}.ValueOption.exists (fun prop ->"

                            indented (fun () -> writeIsValid ())
                            printfn $")"))

                printfn $"then"
                indented (fun () -> printfn $"%s{fsharpCoreNs}.Ok(%s{structModel.Name}.FromElement(element))")
                printfn $"else"
                indented (fun () -> printfn $"%s{fsharpCoreNs}.Error()")))

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
        printfn $"[<%s{fsharpCoreNs}.Struct; global.System.Runtime.CompilerServices.IsReadOnly>]"
        printfn $"type %s{aliasModel.Name}(backing: %s{lspTypesNs}.LspJsonBacking<ILspJsonBackingObj>) ="

        indented (fun () ->
            printfn $"// Complex type kind: %s{aliasModel.Type.Kind}."
            printfn $""
            printfn $"member _.GetBacking() = backing"
            printfn $"member _.WriteTo(writer) = backing.WriteTo(writer)"
            printfn $""
            printfn $"static member FromElement(element) ="
            indented (fun () -> printfn $"%s{aliasModel.Name}(%s{lspTypesNs}.LspJsonBacking.Element element)")
            printfn $""
            printfn $"static member Parse(element) ="
            indented (fun () -> printfn $"%s{fsharpCoreNs}.Ok(%s{aliasModel.Name}.FromElement(element))"))
    | BrokenAlias -> failwith "Broken alias."

writer.Dispose()
