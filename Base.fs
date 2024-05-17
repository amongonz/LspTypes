namespace Amongonz.LspTypes

open System
open System.Text.Json

[<Struct>]
type LspString(element: JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

    static member Parse(element: JsonElement) =
        match element.ValueKind with
        | JsonValueKind.String -> Ok(LspString(element))
        | _ -> Error()

[<Struct>]
type LspUri(element: JsonElement) =
    member _.AsElement = element
    member _.GetUri() = Uri(element.GetString())

    static member Parse(element: JsonElement) =
        match LspString.Parse(element) with
        | Ok str when Uri.IsWellFormedUriString(str.GetString(), UriKind.Absolute) ->
            Ok(LspUri(element))
        | _ -> Error()

type LspDocumentUri = LspUri

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
