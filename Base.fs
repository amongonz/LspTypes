namespace Amongonz.LspTypes

open System
open System.Runtime.CompilerServices
open System.Text.Json

type ILspJsonBackingObj =
    abstract WriteTo: writer: Utf8JsonWriter -> unit

[<RequireQualifiedAccess>]
[<Struct; IsReadOnly>]
type LspJsonBacking<'Backing when 'Backing :> ILspJsonBackingObj> =
    | Element of Element: JsonElement
    | Obj of Backing: 'Backing

    member backing.Boxed =
        match backing with
        | Element elem -> Element elem
        | Obj backingObj -> Obj(backingObj :> ILspJsonBackingObj)

    interface ILspJsonBackingObj with
        member backing.WriteTo(writer) =
            match backing with
            | Element elem -> elem.WriteTo(writer)
            | Obj backingObj -> backingObj.WriteTo(writer)

    member backing.WriteTo(writer) =
        (backing :> ILspJsonBackingObj).WriteTo(writer)

    member backing.GetElement() =
        match backing with
        | Element elem -> elem
        | _ -> invalidOp "Not backed by JsonElement."

    member backing.GetObj() =
        match backing with
        | Obj backingObj -> backingObj
        | _ -> invalidOp "Not backed by an object."

    static member ObjArray(items: seq<'Backing>) =
        Obj(
            { new ILspJsonBackingObj with
                member _.WriteTo(writer) =
                    writer.WriteStartArray()

                    for item in items do
                        item.WriteTo(writer)

                    writer.WriteEndArray()
            }
        )

type private ILspString =
    inherit ILspJsonBackingObj
    abstract Value: string

[<Struct; IsReadOnly>]
type LspString private (backing: LspJsonBacking<ILspString>) =
    member _.GetBacking() = backing.Boxed

    interface ILspJsonBackingObj with
        member _.WriteTo(writer) = backing.WriteTo(writer)

    member lspString.WriteTo(writer) =
        (lspString :> ILspJsonBackingObj).WriteTo(writer)

    member _.GetString() =
        match backing with
        | LspJsonBacking.Element elem -> elem.GetString()
        | LspJsonBacking.Obj backingObj -> backingObj.Value

    member _.ValueEquals(other: string) =
        match backing with
        | LspJsonBacking.Element elem -> elem.ValueEquals(other)
        | LspJsonBacking.Obj backingObj -> backingObj.Value.Equals(other, StringComparison.Ordinal)

    static member FromElement(element) =
        LspString(LspJsonBacking.Element element)

    static member FromString(value) =
        LspString(
            LspJsonBacking.Obj(
                { new ILspString with
                    member _.Value = value
                    member _.WriteTo(writer) = writer.WriteStringValue(value)
                }
            )
        )

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
