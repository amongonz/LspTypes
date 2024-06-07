namespace Amongonz.LspTypes

open System
open System.Runtime.CompilerServices
open System.Text.Json

[<RequireQualifiedAccess>]
[<Struct; IsReadOnly>]
type LspJsonBacking<'Backing> =
    | Element of Element: JsonElement
    | Obj of Backing: 'Backing * WriteTo: ('Backing -> Utf8JsonWriter -> unit)

    member backing.GetBoxed() =
        match backing with
        | Element elem -> Element elem
        | Obj(backingObj, writeTo) -> Obj(box backingObj, unbox<'Backing> >> writeTo)

    member backing.WriteTo(writer) =
        match backing with
        | Element elem -> elem.WriteTo(writer)
        | Obj(backingObj, writeTo) -> writeTo backingObj writer

    member backing.GetElement() =
        match backing with
        | Element elem -> elem
        | _ -> invalidOp "Not backed by JsonElement."

    member backing.GetObj() =
        match backing with
        | Obj(backingObj, _) -> backingObj
        | _ -> invalidOp "Not backed by obj."

[<Struct; IsReadOnly>]
type LspString(backing: LspJsonBacking<string>) =
    member _.GetBacking() = backing
    member _.WriteTo(writer) = backing.WriteTo(writer)

    member _.GetString() =
        match backing with
        | LspJsonBacking.Element elem -> elem.GetString()
        | LspJsonBacking.Obj(backing, _) -> backing

    member _.ValueEquals(other: string) =
        match backing with
        | LspJsonBacking.Element elem -> elem.ValueEquals(other)
        | LspJsonBacking.Obj(backing, _) -> backing.Equals(other, StringComparison.Ordinal)

    static member FromElement(element) =
        LspString(LspJsonBacking.Element element)

    static member FromString(value) =
        LspString(LspJsonBacking.Obj(value, (fun value writer -> writer.WriteStringValue(value))))

    static member Parse(element: JsonElement) =
        match element.ValueKind with
        | JsonValueKind.String -> Ok(LspString(LspJsonBacking.Element element))
        | _ -> Error()

type LspDocumentUri = Uri

module internal Validation =
    let optionalProperty (name: string) (element: JsonElement) =
        match element.TryGetProperty(name) with
        | false, _ -> ValueNone
        | true, value -> ValueSome value

    let isValidInteger (element: JsonElement) =
        match element.ValueKind with
        | JsonValueKind.Number ->
            match element.TryGetInt32() with
            | false, _ -> false
            | true, _ -> true
        | _ -> false

    let isValidDecimal (element: JsonElement) =
        match element.ValueKind with
        | JsonValueKind.Number ->
            match element.TryGetDouble() with
            | false, _ -> false
            | true, _ -> true
        | _ -> false

    let isValidBool (element: JsonElement) =
        match element.ValueKind with
        | JsonValueKind.True
        | JsonValueKind.False -> true
        | _ -> false

    let isValidUri (element: JsonElement) =
        // NOTE: This allocates both the string and an Uri;
        // IsWellFormedUriString() calls TryCreate().
        match element.ValueKind with
        | JsonValueKind.String -> Uri.IsWellFormedUriString(element.GetString(), UriKind.Absolute)
        | _ -> false
