// This file was auto-generated.
namespace rec Amongonz.LspTypes

/// A set of predefined token types. This set is not fixed
/// an clients can specify additional token types via the
/// corresponding client capabilities.
/// 
/// @since 3.16.0
[<global.FSharp.Core.Struct>]
type SemanticTokenTypes(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module SemanticTokenTypes =

    [<return: Struct>]
    let (|Namespace|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("namespace") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Represents a generic type. Acts as a fallback for types which can&apos;t be mapped to
    /// a specific type like class or enum.
    [<return: Struct>]
    let (|Type|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("type") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Class|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("class") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Enum|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("enum") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Interface|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("interface") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Struct|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("struct") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|TypeParameter|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("typeParameter") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Parameter|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("parameter") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Variable|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("variable") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Property|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("property") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|EnumMember|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("enumMember") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Event|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("event") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Function|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("function") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Method|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("method") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Macro|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("macro") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Keyword|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("keyword") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Modifier|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("modifier") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Comment|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("comment") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|String|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("string") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Number|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("number") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Regexp|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("regexp") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Operator|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("operator") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// @since 3.17.0
    [<return: Struct>]
    let (|Decorator|_|) (value: SemanticTokenTypes) =
        if value.AsElement.ValueEquals("decorator") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type SemanticTokenTypes with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            Ok(SemanticTokenTypes(element))
        | _ -> Error()

/// A set of predefined token modifiers. This set is not fixed
/// an clients can specify additional token types via the
/// corresponding client capabilities.
/// 
/// @since 3.16.0
[<global.FSharp.Core.Struct>]
type SemanticTokenModifiers(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module SemanticTokenModifiers =

    [<return: Struct>]
    let (|Declaration|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("declaration") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Definition|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("definition") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Readonly|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("readonly") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Static|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("static") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Deprecated|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("deprecated") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Abstract|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("abstract") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Async|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("async") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Modification|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("modification") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|Documentation|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("documentation") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    [<return: Struct>]
    let (|DefaultLibrary|_|) (value: SemanticTokenModifiers) =
        if value.AsElement.ValueEquals("defaultLibrary") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type SemanticTokenModifiers with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            Ok(SemanticTokenModifiers(element))
        | _ -> Error()

/// The document diagnostic report kinds.
/// 
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type DocumentDiagnosticReportKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module DocumentDiagnosticReportKind =

    /// A diagnostic report with a full
    /// set of problems.
    [<return: Struct>]
    let (|Full|_|) (value: DocumentDiagnosticReportKind) =
        if value.AsElement.ValueEquals("full") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// A report indicating that the last
    /// returned report is still accurate.
    [<return: Struct>]
    let (|Unchanged|_|) (value: DocumentDiagnosticReportKind) =
        if value.AsElement.ValueEquals("unchanged") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type DocumentDiagnosticReportKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = DocumentDiagnosticReportKind(element)
            match value with
            | DocumentDiagnosticReportKind.Full | DocumentDiagnosticReportKind.Unchanged -> Ok(value)
            | _ -> Error()
        | _ -> Error()

/// Predefined error codes.
type ErrorCodes =
    | ParseError = -32700
    | InvalidRequest = -32600
    | MethodNotFound = -32601
    | InvalidParams = -32602
    | InternalError = -32603

    /// Error code indicating that a server received a notification or
    /// request before the server has received the `initialize` request.
    | ServerNotInitialized = -32002
    | UnknownErrorCode = -32001

type LSPErrorCodes =

    /// A request failed but it was syntactically correct, e.g the
    /// method name was known and the parameters were valid. The error
    /// message should contain human readable information about why
    /// the request failed.
    /// 
    /// @since 3.17.0
    | RequestFailed = -32803

    /// The server cancelled the request. This error code should
    /// only be used for requests that explicitly support being
    /// server cancellable.
    /// 
    /// @since 3.17.0
    | ServerCancelled = -32802

    /// The server detected that the content of a document got
    /// modified outside normal conditions. A server should
    /// NOT send this error code if it detects a content change
    /// in it unprocessed messages. The result even computed
    /// on an older state might still be useful for the client.
    /// 
    /// If a client decides that a result is not of any use anymore
    /// the client should cancel the request.
    | ContentModified = -32801

    /// The client has canceled a request and a server has detected
    /// the cancel.
    | RequestCancelled = -32800

/// A set of predefined range kinds.
[<global.FSharp.Core.Struct>]
type FoldingRangeKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module FoldingRangeKind =

    /// Folding range for a comment
    [<return: Struct>]
    let (|Comment|_|) (value: FoldingRangeKind) =
        if value.AsElement.ValueEquals("comment") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Folding range for an import or include
    [<return: Struct>]
    let (|Imports|_|) (value: FoldingRangeKind) =
        if value.AsElement.ValueEquals("imports") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Folding range for a region (e.g. `#region`)
    [<return: Struct>]
    let (|Region|_|) (value: FoldingRangeKind) =
        if value.AsElement.ValueEquals("region") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type FoldingRangeKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            Ok(FoldingRangeKind(element))
        | _ -> Error()

/// A symbol kind.
type SymbolKind =
    | File = 1
    | Module = 2
    | Namespace = 3
    | Package = 4
    | Class = 5
    | Method = 6
    | Property = 7
    | Field = 8
    | Constructor = 9
    | Enum = 10
    | Interface = 11
    | Function = 12
    | Variable = 13
    | Constant = 14
    | String = 15
    | Number = 16
    | Boolean = 17
    | Array = 18
    | Object = 19
    | Key = 20
    | Null = 21
    | EnumMember = 22
    | Struct = 23
    | Event = 24
    | Operator = 25
    | TypeParameter = 26

/// Symbol tags are extra annotations that tweak the rendering of a symbol.
/// 
/// @since 3.16
type SymbolTag =

    /// Render a symbol as obsolete, usually using a strike-out.
    | Deprecated = 1

/// Moniker uniqueness level to define scope of the moniker.
/// 
/// @since 3.16.0
[<global.FSharp.Core.Struct>]
type UniquenessLevel(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module UniquenessLevel =

    /// The moniker is only unique inside a document
    [<return: Struct>]
    let (|Document|_|) (value: UniquenessLevel) =
        if value.AsElement.ValueEquals("document") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// The moniker is unique inside a project for which a dump got created
    [<return: Struct>]
    let (|Project|_|) (value: UniquenessLevel) =
        if value.AsElement.ValueEquals("project") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// The moniker is unique inside the group to which a project belongs
    [<return: Struct>]
    let (|Group|_|) (value: UniquenessLevel) =
        if value.AsElement.ValueEquals("group") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// The moniker is unique inside the moniker scheme.
    [<return: Struct>]
    let (|Scheme|_|) (value: UniquenessLevel) =
        if value.AsElement.ValueEquals("scheme") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// The moniker is globally unique
    [<return: Struct>]
    let (|Global|_|) (value: UniquenessLevel) =
        if value.AsElement.ValueEquals("global") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type UniquenessLevel with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = UniquenessLevel(element)
            match value with
            | UniquenessLevel.Document | UniquenessLevel.Project | UniquenessLevel.Group | UniquenessLevel.Scheme | UniquenessLevel.Global -> Ok(value)
            | _ -> Error()
        | _ -> Error()

/// The moniker kind.
/// 
/// @since 3.16.0
[<global.FSharp.Core.Struct>]
type MonikerKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module MonikerKind =

    /// The moniker represent a symbol that is imported into a project
    [<return: Struct>]
    let (|Import|_|) (value: MonikerKind) =
        if value.AsElement.ValueEquals("import") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// The moniker represents a symbol that is exported from a project
    [<return: Struct>]
    let (|Export|_|) (value: MonikerKind) =
        if value.AsElement.ValueEquals("export") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// The moniker represents a symbol that is local to a project (e.g. a local
    /// variable of a function, a class not visible outside the project, ...)
    [<return: Struct>]
    let (|Local|_|) (value: MonikerKind) =
        if value.AsElement.ValueEquals("local") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type MonikerKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = MonikerKind(element)
            match value with
            | MonikerKind.Import | MonikerKind.Export | MonikerKind.Local -> Ok(value)
            | _ -> Error()
        | _ -> Error()

/// Inlay hint kinds.
/// 
/// @since 3.17.0
type InlayHintKind =

    /// An inlay hint that for a type annotation.
    | Type = 1

    /// An inlay hint that is for a parameter.
    | Parameter = 2

/// The message type
type MessageType =

    /// An error message.
    | Error = 1

    /// A warning message.
    | Warning = 2

    /// An information message.
    | Info = 3

    /// A log message.
    | Log = 4

    /// A debug message.
    /// 
    /// @since 3.18.0
    | Debug = 5

/// Defines how the host (editor) should sync
/// document changes to the language server.
type TextDocumentSyncKind =

    /// Documents should not be synced at all.
    | None = 0

    /// Documents are synced by always sending the full content
    /// of the document.
    | Full = 1

    /// Documents are synced by sending the full content on open.
    /// After that only incremental updates to the document are
    /// send.
    | Incremental = 2

/// Represents reasons why a text document is saved.
type TextDocumentSaveReason =

    /// Manually triggered, e.g. by the user pressing save, by starting debugging,
    /// or by an API call.
    | Manual = 1

    /// Automatic after a delay.
    | AfterDelay = 2

    /// When the editor lost focus.
    | FocusOut = 3

/// The kind of a completion entry.
type CompletionItemKind =
    | Text = 1
    | Method = 2
    | Function = 3
    | Constructor = 4
    | Field = 5
    | Variable = 6
    | Class = 7
    | Interface = 8
    | Module = 9
    | Property = 10
    | Unit = 11
    | Value = 12
    | Enum = 13
    | Keyword = 14
    | Snippet = 15
    | Color = 16
    | File = 17
    | Reference = 18
    | Folder = 19
    | EnumMember = 20
    | Constant = 21
    | Struct = 22
    | Event = 23
    | Operator = 24
    | TypeParameter = 25

/// Completion item tags are extra annotations that tweak the rendering of a completion
/// item.
/// 
/// @since 3.15.0
type CompletionItemTag =

    /// Render a completion as obsolete, usually using a strike-out.
    | Deprecated = 1

/// Defines whether the insert text in a completion item should be interpreted as
/// plain text or a snippet.
type InsertTextFormat =

    /// The primary text to be inserted is treated as a plain string.
    | PlainText = 1

    /// The primary text to be inserted is treated as a snippet.
    /// 
    /// A snippet can define tab stops and placeholders with `$1`, `$2`
    /// and `${3:foo}`. `$0` defines the final tab stop, it defaults to
    /// the end of the snippet. Placeholders with equal identifiers are linked,
    /// that is typing in one will update others too.
    /// 
    /// See also: https://microsoft.github.io/language-server-protocol/specifications/specification-current/#snippet_syntax
    | Snippet = 2

/// How whitespace and indentation is handled during completion
/// item insertion.
/// 
/// @since 3.16.0
type InsertTextMode =

    /// The insertion or replace strings is taken as it is. If the
    /// value is multi line the lines below the cursor will be
    /// inserted using the indentation defined in the string value.
    /// The client will not apply any kind of adjustments to the
    /// string.
    | AsIs = 1

    /// The editor adjusts leading whitespace of new lines so that
    /// they match the indentation up to the cursor of the line for
    /// which the item is accepted.
    /// 
    /// Consider a line like this: &lt;2tabs&gt;&lt;cursor&gt;&lt;3tabs&gt;foo. Accepting a
    /// multi line completion item is indented using 2 tabs and all
    /// following lines inserted will be indented using 2 tabs as well.
    | AdjustIndentation = 2

/// A document highlight kind.
type DocumentHighlightKind =

    /// A textual occurrence.
    | Text = 1

    /// Read-access of a symbol, like reading a variable.
    | Read = 2

    /// Write-access of a symbol, like writing to a variable.
    | Write = 3

/// A set of predefined code action kinds
[<global.FSharp.Core.Struct>]
type CodeActionKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module CodeActionKind =

    /// Empty kind.
    [<return: Struct>]
    let (|Empty|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Base kind for quickfix actions: &apos;quickfix&apos;
    [<return: Struct>]
    let (|QuickFix|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("quickfix") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Base kind for refactoring actions: &apos;refactor&apos;
    [<return: Struct>]
    let (|Refactor|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("refactor") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Base kind for refactoring extraction actions: &apos;refactor.extract&apos;
    /// 
    /// Example extract actions:
    /// 
    /// - Extract method
    /// - Extract function
    /// - Extract variable
    /// - Extract interface from class
    /// - ...
    [<return: Struct>]
    let (|RefactorExtract|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("refactor.extract") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Base kind for refactoring inline actions: &apos;refactor.inline&apos;
    /// 
    /// Example inline actions:
    /// 
    /// - Inline function
    /// - Inline variable
    /// - Inline constant
    /// - ...
    [<return: Struct>]
    let (|RefactorInline|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("refactor.inline") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Base kind for refactoring rewrite actions: &apos;refactor.rewrite&apos;
    /// 
    /// Example rewrite actions:
    /// 
    /// - Convert JavaScript function to class
    /// - Add or remove parameter
    /// - Encapsulate field
    /// - Make method static
    /// - Move method to base class
    /// - ...
    [<return: Struct>]
    let (|RefactorRewrite|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("refactor.rewrite") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Base kind for source actions: `source`
    /// 
    /// Source code actions apply to the entire file.
    [<return: Struct>]
    let (|Source|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("source") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Base kind for an organize imports source action: `source.organizeImports`
    [<return: Struct>]
    let (|SourceOrganizeImports|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("source.organizeImports") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Base kind for auto-fix source actions: `source.fixAll`.
    /// 
    /// Fix all actions automatically fix errors that have a clear fix that do not require user input.
    /// They should not suppress errors or perform unsafe fixes such as generating new types or classes.
    /// 
    /// @since 3.15.0
    [<return: Struct>]
    let (|SourceFixAll|_|) (value: CodeActionKind) =
        if value.AsElement.ValueEquals("source.fixAll") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type CodeActionKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            Ok(CodeActionKind(element))
        | _ -> Error()

[<global.FSharp.Core.Struct>]
type TraceValues(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module TraceValues =

    /// Turn tracing off.
    [<return: Struct>]
    let (|Off|_|) (value: TraceValues) =
        if value.AsElement.ValueEquals("off") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Trace messages only.
    [<return: Struct>]
    let (|Messages|_|) (value: TraceValues) =
        if value.AsElement.ValueEquals("messages") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Verbose message tracing.
    [<return: Struct>]
    let (|Verbose|_|) (value: TraceValues) =
        if value.AsElement.ValueEquals("verbose") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type TraceValues with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = TraceValues(element)
            match value with
            | TraceValues.Off | TraceValues.Messages | TraceValues.Verbose -> Ok(value)
            | _ -> Error()
        | _ -> Error()

/// Describes the content type that a client supports in various
/// result literals like `Hover`, `ParameterInfo` or `CompletionItem`.
/// 
/// Please note that `MarkupKinds` must not start with a `$`. This kinds
/// are reserved for internal usage.
[<global.FSharp.Core.Struct>]
type MarkupKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module MarkupKind =

    /// Plain text is supported as a content format
    [<return: Struct>]
    let (|PlainText|_|) (value: MarkupKind) =
        if value.AsElement.ValueEquals("plaintext") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Markdown is supported as a content format
    [<return: Struct>]
    let (|Markdown|_|) (value: MarkupKind) =
        if value.AsElement.ValueEquals("markdown") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type MarkupKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = MarkupKind(element)
            match value with
            | MarkupKind.PlainText | MarkupKind.Markdown -> Ok(value)
            | _ -> Error()
        | _ -> Error()

/// Describes how an {@link InlineCompletionItemProvider inline completion provider} was triggered.
/// 
/// @since 3.18.0
/// @proposed
type InlineCompletionTriggerKind =

    /// Completion was triggered explicitly by a user gesture.
    | Invoked = 0

    /// Completion was triggered automatically while editing.
    | Automatic = 1

/// A set of predefined position encoding kinds.
/// 
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type PositionEncodingKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module PositionEncodingKind =

    /// Character offsets count UTF-8 code units (e.g. bytes).
    [<return: Struct>]
    let (|UTF8|_|) (value: PositionEncodingKind) =
        if value.AsElement.ValueEquals("utf-8") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Character offsets count UTF-16 code units.
    /// 
    /// This is the default and must always be supported
    /// by servers
    [<return: Struct>]
    let (|UTF16|_|) (value: PositionEncodingKind) =
        if value.AsElement.ValueEquals("utf-16") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Character offsets count UTF-32 code units.
    /// 
    /// Implementation note: these are the same as Unicode codepoints,
    /// so this `PositionEncodingKind` may also be used for an
    /// encoding-agnostic representation of character offsets.
    [<return: Struct>]
    let (|UTF32|_|) (value: PositionEncodingKind) =
        if value.AsElement.ValueEquals("utf-32") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type PositionEncodingKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            Ok(PositionEncodingKind(element))
        | _ -> Error()

/// The file event type
type FileChangeType =

    /// The file got created.
    | Created = 1

    /// The file got changed.
    | Changed = 2

    /// The file got deleted.
    | Deleted = 3

type WatchKind =

    /// Interested in create events.
    | Create = 1

    /// Interested in change events
    | Change = 2

    /// Interested in delete events
    | Delete = 4

/// The diagnostic&apos;s severity.
type DiagnosticSeverity =

    /// Reports an error.
    | Error = 1

    /// Reports a warning.
    | Warning = 2

    /// Reports an information.
    | Information = 3

    /// Reports a hint.
    | Hint = 4

/// The diagnostic tags.
/// 
/// @since 3.15.0
type DiagnosticTag =

    /// Unused or unnecessary code.
    /// 
    /// Clients are allowed to render diagnostics with this tag faded out instead of having
    /// an error squiggle.
    | Unnecessary = 1

    /// Deprecated or obsolete code.
    /// 
    /// Clients are allowed to rendered diagnostics with this tag strike through.
    | Deprecated = 2

/// How a completion was triggered
type CompletionTriggerKind =

    /// Completion was triggered by typing an identifier (24x7 code
    /// complete), manual invocation (e.g Ctrl+Space) or via API.
    | Invoked = 1

    /// Completion was triggered by a trigger character specified by
    /// the `triggerCharacters` properties of the `CompletionRegistrationOptions`.
    | TriggerCharacter = 2

    /// Completion was re-triggered as current completion list is incomplete
    | TriggerForIncompleteCompletions = 3

/// How a signature help was triggered.
/// 
/// @since 3.15.0
type SignatureHelpTriggerKind =

    /// Signature help was invoked manually by the user or by a command.
    | Invoked = 1

    /// Signature help was triggered by a trigger character.
    | TriggerCharacter = 2

    /// Signature help was triggered by the cursor moving or by the document content changing.
    | ContentChange = 3

/// The reason why code actions were requested.
/// 
/// @since 3.17.0
type CodeActionTriggerKind =

    /// Code actions were explicitly requested by the user or by an extension.
    | Invoked = 1

    /// Code actions were requested automatically.
    /// 
    /// This typically happens when current selection in a file changes, but can
    /// also be triggered when file content changes.
    | Automatic = 2

/// A pattern kind describing if a glob pattern matches a file a folder or
/// both.
/// 
/// @since 3.16.0
[<global.FSharp.Core.Struct>]
type FileOperationPatternKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module FileOperationPatternKind =

    /// The pattern matches a file only.
    [<return: Struct>]
    let (|File|_|) (value: FileOperationPatternKind) =
        if value.AsElement.ValueEquals("file") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// The pattern matches a folder only.
    [<return: Struct>]
    let (|Folder|_|) (value: FileOperationPatternKind) =
        if value.AsElement.ValueEquals("folder") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type FileOperationPatternKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = FileOperationPatternKind(element)
            match value with
            | FileOperationPatternKind.File | FileOperationPatternKind.Folder -> Ok(value)
            | _ -> Error()
        | _ -> Error()

/// A notebook cell kind.
/// 
/// @since 3.17.0
type NotebookCellKind =

    /// A markup-cell is formatted source that is used for display.
    | Markup = 1

    /// A code-cell is source code.
    | Code = 2

[<global.FSharp.Core.Struct>]
type ResourceOperationKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module ResourceOperationKind =

    /// Supports creating new files and folders.
    [<return: Struct>]
    let (|Create|_|) (value: ResourceOperationKind) =
        if value.AsElement.ValueEquals("create") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Supports renaming existing files and folders.
    [<return: Struct>]
    let (|Rename|_|) (value: ResourceOperationKind) =
        if value.AsElement.ValueEquals("rename") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// Supports deleting existing files and folders.
    [<return: Struct>]
    let (|Delete|_|) (value: ResourceOperationKind) =
        if value.AsElement.ValueEquals("delete") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type ResourceOperationKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = ResourceOperationKind(element)
            match value with
            | ResourceOperationKind.Create | ResourceOperationKind.Rename | ResourceOperationKind.Delete -> Ok(value)
            | _ -> Error()
        | _ -> Error()

[<global.FSharp.Core.Struct>]
type FailureHandlingKind(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module FailureHandlingKind =

    /// Applying the workspace change is simply aborted if one of the changes provided
    /// fails. All operations executed before the failing operation stay executed.
    [<return: Struct>]
    let (|Abort|_|) (value: FailureHandlingKind) =
        if value.AsElement.ValueEquals("abort") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// All operations are executed transactional. That means they either all
    /// succeed or no changes at all are applied to the workspace.
    [<return: Struct>]
    let (|Transactional|_|) (value: FailureHandlingKind) =
        if value.AsElement.ValueEquals("transactional") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// If the workspace edit contains only textual file changes they are executed transactional.
    /// If resource changes (create, rename or delete file) are part of the change the failure
    /// handling strategy is abort.
    [<return: Struct>]
    let (|TextOnlyTransactional|_|) (value: FailureHandlingKind) =
        if value.AsElement.ValueEquals("textOnlyTransactional") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

    /// The client tries to undo the operations already executed. But there is no
    /// guarantee that this is succeeding.
    [<return: Struct>]
    let (|Undo|_|) (value: FailureHandlingKind) =
        if value.AsElement.ValueEquals("undo") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type FailureHandlingKind with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = FailureHandlingKind(element)
            match value with
            | FailureHandlingKind.Abort | FailureHandlingKind.Transactional | FailureHandlingKind.TextOnlyTransactional | FailureHandlingKind.Undo -> Ok(value)
            | _ -> Error()
        | _ -> Error()

type PrepareSupportDefaultBehavior =

    /// The client&apos;s default behavior is to select the identifier
    /// according the to language&apos;s syntax rule.
    | Identifier = 1

[<global.FSharp.Core.Struct>]
type TokenFormat(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element
    member _.GetString() = element.GetString()

[<global.FSharp.Core.RequireQualifiedAccess>]
module TokenFormat =

    [<return: Struct>]
    let (|Relative|_|) (value: TokenFormat) =
        if value.AsElement.ValueEquals("relative") then
            global.FSharp.Core.ValueSome()
        else
            global.FSharp.Core.ValueNone

type TokenFormat with
    static member Parse(element: global.System.Text.Json.JsonElement) =
        match element.ValueKind with
        | global.System.Text.Json.JsonValueKind.String ->
            let value = TokenFormat(element)
            match value with
            | TokenFormat.Relative -> Ok(value)
            | _ -> Error()
        | _ -> Error()

[<global.FSharp.Core.AutoOpen>]
module EnumerationExtensions =

    type ErrorCodes with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value -> Ok(global.FSharp.Core.Operators.enum<ErrorCodes> value)
                | false, _ -> Error()
            | _ -> Error()

    type LSPErrorCodes with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value -> Ok(global.FSharp.Core.Operators.enum<LSPErrorCodes> value)
                | false, _ -> Error()
            | _ -> Error()

    type SymbolKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<SymbolKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<SymbolKind> value)
                | _ -> Error()
            | _ -> Error()

    type SymbolTag with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<SymbolTag> value) ->
                    Ok(global.FSharp.Core.Operators.enum<SymbolTag> value)
                | _ -> Error()
            | _ -> Error()

    type InlayHintKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<InlayHintKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<InlayHintKind> value)
                | _ -> Error()
            | _ -> Error()

    type MessageType with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<MessageType> value) ->
                    Ok(global.FSharp.Core.Operators.enum<MessageType> value)
                | _ -> Error()
            | _ -> Error()

    type TextDocumentSyncKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<TextDocumentSyncKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<TextDocumentSyncKind> value)
                | _ -> Error()
            | _ -> Error()

    type TextDocumentSaveReason with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<TextDocumentSaveReason> value) ->
                    Ok(global.FSharp.Core.Operators.enum<TextDocumentSaveReason> value)
                | _ -> Error()
            | _ -> Error()

    type CompletionItemKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<CompletionItemKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<CompletionItemKind> value)
                | _ -> Error()
            | _ -> Error()

    type CompletionItemTag with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<CompletionItemTag> value) ->
                    Ok(global.FSharp.Core.Operators.enum<CompletionItemTag> value)
                | _ -> Error()
            | _ -> Error()

    type InsertTextFormat with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<InsertTextFormat> value) ->
                    Ok(global.FSharp.Core.Operators.enum<InsertTextFormat> value)
                | _ -> Error()
            | _ -> Error()

    type InsertTextMode with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<InsertTextMode> value) ->
                    Ok(global.FSharp.Core.Operators.enum<InsertTextMode> value)
                | _ -> Error()
            | _ -> Error()

    type DocumentHighlightKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<DocumentHighlightKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<DocumentHighlightKind> value)
                | _ -> Error()
            | _ -> Error()

    type InlineCompletionTriggerKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<InlineCompletionTriggerKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<InlineCompletionTriggerKind> value)
                | _ -> Error()
            | _ -> Error()

    type FileChangeType with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<FileChangeType> value) ->
                    Ok(global.FSharp.Core.Operators.enum<FileChangeType> value)
                | _ -> Error()
            | _ -> Error()

    type WatchKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value -> Ok(global.FSharp.Core.Operators.enum<WatchKind> value)
                | false, _ -> Error()
            | _ -> Error()

    type DiagnosticSeverity with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<DiagnosticSeverity> value) ->
                    Ok(global.FSharp.Core.Operators.enum<DiagnosticSeverity> value)
                | _ -> Error()
            | _ -> Error()

    type DiagnosticTag with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<DiagnosticTag> value) ->
                    Ok(global.FSharp.Core.Operators.enum<DiagnosticTag> value)
                | _ -> Error()
            | _ -> Error()

    type CompletionTriggerKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<CompletionTriggerKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<CompletionTriggerKind> value)
                | _ -> Error()
            | _ -> Error()

    type SignatureHelpTriggerKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<SignatureHelpTriggerKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<SignatureHelpTriggerKind> value)
                | _ -> Error()
            | _ -> Error()

    type CodeActionTriggerKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<CodeActionTriggerKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<CodeActionTriggerKind> value)
                | _ -> Error()
            | _ -> Error()

    type NotebookCellKind with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<NotebookCellKind> value) ->
                    Ok(global.FSharp.Core.Operators.enum<NotebookCellKind> value)
                | _ -> Error()
            | _ -> Error()

    type PrepareSupportDefaultBehavior with
        static member Parse(element: global.System.Text.Json.JsonElement) =
            match element.ValueKind with
            | global.System.Text.Json.JsonValueKind.Number ->
                match element.TryGetInt32() with
                | true, value when global.System.Enum.IsDefined(global.FSharp.Core.Operators.enum<PrepareSupportDefaultBehavior> value) ->
                    Ok(global.FSharp.Core.Operators.enum<PrepareSupportDefaultBehavior> value)
                | _ -> Error()
            | _ -> Error()

[<Struct>]
type ImplementationParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(ImplementationParams(element))
        else Error()

/// Represents a location inside a resource, such as a line
/// inside a text file.
[<Struct>]
type Location(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
        then Ok(Location(element))
        else Error()

[<Struct>]
type ImplementationRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ImplementationRegistrationOptions(element))

[<Struct>]
type TypeDefinitionParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(TypeDefinitionParams(element))
        else Error()

[<Struct>]
type TypeDefinitionRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(TypeDefinitionRegistrationOptions(element))

/// A workspace folder inside a client.
[<Struct>]
type WorkspaceFolder(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The associated URI for this workspace folder.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.System.Uri(prop.GetString())

    /// The name of the workspace folder. Used to refer to this
    /// workspace folder in the user interface.
    member _.Name =
        let prop = element.GetProperty("name")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "name" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(WorkspaceFolder(element))
        else Error()

/// The parameters of a `workspace/didChangeWorkspaceFolders` notification.
[<Struct>]
type DidChangeWorkspaceFoldersParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The actual workspace folder change event.
    member _.Event =
        let prop = element.GetProperty("event")
        WorkspaceFoldersChangeEvent(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "event" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (WorkspaceFoldersChangeEvent.Parse(prop)))
            end
        then Ok(DidChangeWorkspaceFoldersParams(element))
        else Error()

/// The parameters of a configuration request.
[<Struct>]
type ConfigurationParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Items =
        // Requires specialization: "array"

        let prop = element.GetProperty("items")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ConfigurationParams(element))

/// Parameters for a {@link DocumentColorRequest}.
[<Struct>]
type DocumentColorParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DocumentColorParams(element))
        else Error()

/// Represents a color range from a document.
[<Struct>]
type ColorInformation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The range in the document where this color appears.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The actual color value for this color range.
    member _.Color =
        let prop = element.GetProperty("color")
        Color(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "color" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Color.Parse(prop)))
            end
        then Ok(ColorInformation(element))
        else Error()

[<Struct>]
type DocumentColorRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentColorRegistrationOptions(element))

/// Parameters for a {@link ColorPresentationRequest}.
[<Struct>]
type ColorPresentationParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The color to request presentations for.
    member _.Color =
        let prop = element.GetProperty("color")
        Color(prop)

    /// The range where the color would be inserted. Serves as a context.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "color" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Color.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(ColorPresentationParams(element))
        else Error()

[<Struct>]
type ColorPresentation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The label of this color presentation. It will be shown on the color
    /// picker header. By default this is also the text that is inserted when selecting
    /// this color presentation.
    member _.Label =
        let prop = element.GetProperty("label")
        global.Amongonz.LspTypes.LspString(prop)

    /// An {@link TextEdit edit} which is applied to a document when selecting
    /// this presentation for the color.  When `falsy` the {@link ColorPresentation.label label}
    /// is used.
    member _.TextEdit =
        match element.TryGetProperty("textEdit") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(TextEdit(prop))

    /// An optional array of additional {@link TextEdit text edits} that are applied when
    /// selecting this color presentation. Edits must not overlap with the main {@link ColorPresentation.textEdit edit} nor with themselves.
    member _.AdditionalTextEdits =
        // Requires specialization: "array"

        match element.TryGetProperty("additionalTextEdits") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ColorPresentation(element))

[<Struct>]
type WorkDoneProgressOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(WorkDoneProgressOptions(element))
        else Error()

/// General text document registration options.
[<Struct>]
type TextDocumentRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(TextDocumentRegistrationOptions(element))

/// Parameters for a {@link FoldingRangeRequest}.
[<Struct>]
type FoldingRangeParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(FoldingRangeParams(element))
        else Error()

/// Represents a folding range. To be valid, start and end line must be bigger than zero and smaller
/// than the number of lines in the document. Clients are free to ignore invalid ranges.
[<Struct>]
type FoldingRange(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The zero-based start line of the range to fold. The folded area starts after the line&apos;s last character.
    /// To be valid, the end must be zero or larger and smaller than the number of lines in the document.
    member _.StartLine =
        let prop = element.GetProperty("startLine")
        prop.GetInt32()

    /// The zero-based character offset from where the folded range starts. If not defined, defaults to the length of the start line.
    member _.StartCharacter =
        match element.TryGetProperty("startCharacter") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    /// The zero-based end line of the range to fold. The folded area ends with the line&apos;s last character.
    /// To be valid, the end must be zero or larger and smaller than the number of lines in the document.
    member _.EndLine =
        let prop = element.GetProperty("endLine")
        prop.GetInt32()

    /// The zero-based character offset before the folded range ends. If not defined, defaults to the length of the end line.
    member _.EndCharacter =
        match element.TryGetProperty("endCharacter") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    /// Describes the kind of the folding range such as `comment&apos; or &apos;region&apos;. The kind
    /// is used to categorize folding ranges and used by commands like &apos;Fold all comments&apos;.
    /// See {@link FoldingRangeKind} for an enumeration of standardized kinds.
    member _.Kind =
        match element.TryGetProperty("kind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FoldingRangeKind(prop))

    /// The text that the client should show when the specified range is
    /// collapsed. If not defined or not supported by the client, a default
    /// will be chosen by the client.
    /// 
    /// @since 3.17.0
    member _.CollapsedText =
        match element.TryGetProperty("collapsedText") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "startLine" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "startCharacter" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "endLine" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "endCharacter" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "kind" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FoldingRangeKind.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "collapsedText" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(FoldingRange(element))
        else Error()

[<Struct>]
type FoldingRangeRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(FoldingRangeRegistrationOptions(element))

[<Struct>]
type DeclarationParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DeclarationParams(element))
        else Error()

[<Struct>]
type DeclarationRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DeclarationRegistrationOptions(element))

/// A parameter literal used in selection range requests.
[<Struct>]
type SelectionRangeParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The positions inside the text document.
    member _.Positions =
        // Requires specialization: "array"

        let prop = element.GetProperty("positions")
        prop

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SelectionRangeParams(element))

/// A selection range represents a part of a selection hierarchy. A selection range
/// may have a parent selection range that contains it.
[<Struct>]
type SelectionRange(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The {@link Range range} of this selection range.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The parent selection range containing this range. Therefore `parent.range` must contain `this.range`.
    member _.Parent =
        match element.TryGetProperty("parent") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SelectionRange(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "parent" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (SelectionRange.Parse(prop)))
            end
        then Ok(SelectionRange(element))
        else Error()

[<Struct>]
type SelectionRangeRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SelectionRangeRegistrationOptions(element))

[<Struct>]
type WorkDoneProgressCreateParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The token to be used to report progress.
    member _.Token =
        let prop = element.GetProperty("token")
        ProgressToken(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "token" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(WorkDoneProgressCreateParams(element))
        else Error()

[<Struct>]
type WorkDoneProgressCancelParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The token to be used to report progress.
    member _.Token =
        let prop = element.GetProperty("token")
        ProgressToken(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "token" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(WorkDoneProgressCancelParams(element))
        else Error()

/// The parameter of a `textDocument/prepareCallHierarchy` request.
/// 
/// @since 3.16.0
[<Struct>]
type CallHierarchyPrepareParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(CallHierarchyPrepareParams(element))
        else Error()

/// Represents programming constructs like functions or constructors in the context
/// of call hierarchy.
/// 
/// @since 3.16.0
[<Struct>]
type CallHierarchyItem(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The name of this item.
    member _.Name =
        let prop = element.GetProperty("name")
        global.Amongonz.LspTypes.LspString(prop)

    /// The kind of this item.
    member _.Kind =
        let prop = element.GetProperty("kind")
        enum<SymbolKind>(prop.GetInt32())

    /// Tags for this item.
    member _.Tags =
        // Requires specialization: "array"

        match element.TryGetProperty("tags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// More detail for this item, e.g. the signature of a function.
    member _.Detail =
        match element.TryGetProperty("detail") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The resource identifier of this item.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The range enclosing this symbol not including leading/trailing whitespace but everything else, e.g. comments and code.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The range that should be selected and revealed when this symbol is being picked, e.g. the name of a function.
    /// Must be contained by the {@link CallHierarchyItem.range `range`}.
    member _.SelectionRange =
        let prop = element.GetProperty("selectionRange")
        Range(prop)

    /// A data entry field that is preserved between a call hierarchy prepare and
    /// incoming calls or outgoing calls requests.
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CallHierarchyItem(element))

/// Call hierarchy options used during static or dynamic registration.
/// 
/// @since 3.16.0
[<Struct>]
type CallHierarchyRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CallHierarchyRegistrationOptions(element))

/// The parameter of a `callHierarchy/incomingCalls` request.
/// 
/// @since 3.16.0
[<Struct>]
type CallHierarchyIncomingCallsParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Item =
        let prop = element.GetProperty("item")
        CallHierarchyItem(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "item" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (CallHierarchyItem.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(CallHierarchyIncomingCallsParams(element))
        else Error()

/// Represents an incoming call, e.g. a caller of a method or constructor.
/// 
/// @since 3.16.0
[<Struct>]
type CallHierarchyIncomingCall(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The item that makes the call.
    member _.From =
        let prop = element.GetProperty("from")
        CallHierarchyItem(prop)

    /// The ranges at which the calls appear. This is relative to the caller
    /// denoted by {@link CallHierarchyIncomingCall.from `this.from`}.
    member _.FromRanges =
        // Requires specialization: "array"

        let prop = element.GetProperty("fromRanges")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CallHierarchyIncomingCall(element))

/// The parameter of a `callHierarchy/outgoingCalls` request.
/// 
/// @since 3.16.0
[<Struct>]
type CallHierarchyOutgoingCallsParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Item =
        let prop = element.GetProperty("item")
        CallHierarchyItem(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "item" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (CallHierarchyItem.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(CallHierarchyOutgoingCallsParams(element))
        else Error()

/// Represents an outgoing call, e.g. calling a getter from a method or a method from a constructor etc.
/// 
/// @since 3.16.0
[<Struct>]
type CallHierarchyOutgoingCall(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The item that is called.
    member _.To =
        let prop = element.GetProperty("to")
        CallHierarchyItem(prop)

    /// The range at which this item is called. This is the range relative to the caller, e.g the item
    /// passed to {@link CallHierarchyItemProvider.provideCallHierarchyOutgoingCalls `provideCallHierarchyOutgoingCalls`}
    /// and not {@link CallHierarchyOutgoingCall.to `this.to`}.
    member _.FromRanges =
        // Requires specialization: "array"

        let prop = element.GetProperty("fromRanges")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CallHierarchyOutgoingCall(element))

/// @since 3.16.0
[<Struct>]
type SemanticTokensParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(SemanticTokensParams(element))
        else Error()

/// @since 3.16.0
[<Struct>]
type SemanticTokens(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An optional result id. If provided and clients support delta updating
    /// the client will include the result id in the next semantic token request.
    /// A server can then instead of computing all semantic tokens again simply
    /// send a delta.
    member _.ResultId =
        match element.TryGetProperty("resultId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The actual tokens.
    member _.Data =
        // Requires specialization: "array"

        let prop = element.GetProperty("data")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokens(element))

/// @since 3.16.0
[<Struct>]
type SemanticTokensPartialResult(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Data =
        // Requires specialization: "array"

        let prop = element.GetProperty("data")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokensPartialResult(element))

/// @since 3.16.0
[<Struct>]
type SemanticTokensRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The legend used by the server
    member _.Legend =
        let prop = element.GetProperty("legend")
        SemanticTokensLegend(prop)

    /// Server supports providing semantic tokens for a specific range
    /// of a document.
    member _.Range =
        // Requires specialization: "or"

        match element.TryGetProperty("range") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Server supports providing semantic tokens for a full document.
    member _.Full =
        // Requires specialization: "or"

        match element.TryGetProperty("full") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokensRegistrationOptions(element))

/// @since 3.16.0
[<Struct>]
type SemanticTokensDeltaParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The result id of a previous response. The result Id can either point to a full response
    /// or a delta response depending on what was received last.
    member _.PreviousResultId =
        let prop = element.GetProperty("previousResultId")
        global.Amongonz.LspTypes.LspString(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "previousResultId" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(SemanticTokensDeltaParams(element))
        else Error()

/// @since 3.16.0
[<Struct>]
type SemanticTokensDelta(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.ResultId =
        match element.TryGetProperty("resultId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The semantic token edits to transform a previous result into a new result.
    member _.Edits =
        // Requires specialization: "array"

        let prop = element.GetProperty("edits")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokensDelta(element))

/// @since 3.16.0
[<Struct>]
type SemanticTokensDeltaPartialResult(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Edits =
        // Requires specialization: "array"

        let prop = element.GetProperty("edits")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokensDeltaPartialResult(element))

/// @since 3.16.0
[<Struct>]
type SemanticTokensRangeParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The range the semantic tokens are requested for.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(SemanticTokensRangeParams(element))
        else Error()

/// Params to show a resource in the UI.
/// 
/// @since 3.16.0
[<Struct>]
type ShowDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The uri to show.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.System.Uri(prop.GetString())

    /// Indicates to show the resource in an external program.
    /// To show, for example, `https://code.visualstudio.com/`
    /// in the default WEB browser set `external` to `true`.
    member _.External =
        match element.TryGetProperty("external") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// An optional property to indicate whether the editor
    /// showing the document should take focus or not.
    /// Clients might ignore this property if an external
    /// program is started.
    member _.TakeFocus =
        match element.TryGetProperty("takeFocus") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// An optional selection range if the document is a text
    /// document. Clients might ignore the property if an
    /// external program is started or the file is not a text
    /// file.
    member _.Selection =
        match element.TryGetProperty("selection") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Range(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "external" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "takeFocus" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "selection" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
        then Ok(ShowDocumentParams(element))
        else Error()

/// The result of a showDocument request.
/// 
/// @since 3.16.0
[<Struct>]
type ShowDocumentResult(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A boolean indicating if the show was successful.
    member _.Success =
        let prop = element.GetProperty("success")
        prop.GetBoolean()

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "success" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ShowDocumentResult(element))
        else Error()

[<Struct>]
type LinkedEditingRangeParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(LinkedEditingRangeParams(element))
        else Error()

/// The result of a linked editing range request.
/// 
/// @since 3.16.0
[<Struct>]
type LinkedEditingRanges(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A list of ranges that can be edited together. The ranges must have
    /// identical length and contain identical text content. The ranges cannot overlap.
    member _.Ranges =
        // Requires specialization: "array"

        let prop = element.GetProperty("ranges")
        prop

    /// An optional word pattern (regular expression) that describes valid contents for
    /// the given ranges. If no pattern is provided, the client configuration&apos;s word
    /// pattern will be used.
    member _.WordPattern =
        match element.TryGetProperty("wordPattern") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(LinkedEditingRanges(element))

[<Struct>]
type LinkedEditingRangeRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(LinkedEditingRangeRegistrationOptions(element))

/// The parameters sent in notifications/requests for user-initiated creation of
/// files.
/// 
/// @since 3.16.0
[<Struct>]
type CreateFilesParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An array of all files/folders created in this operation.
    member _.Files =
        // Requires specialization: "array"

        let prop = element.GetProperty("files")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CreateFilesParams(element))

/// A workspace edit represents changes to many resources managed in the workspace. The edit
/// should either provide `changes` or `documentChanges`. If documentChanges are present
/// they are preferred over `changes` if the client can handle versioned document edits.
/// 
/// Since version 3.13.0 a workspace edit can contain resource operations as well. If resource
/// operations are present clients need to execute the operations in the order in which they
/// are provided. So a workspace edit for example can consist of the following two changes:
/// (1) a create file a.txt and (2) a text document edit which insert text into file a.txt.
/// 
/// An invalid sequence (e.g. (1) delete file a.txt and (2) insert text into file a.txt) will
/// cause failure of the operation. How the client recovers from the failure is described by
/// the client capability: `workspace.workspaceEdit.failureHandling`
[<Struct>]
type WorkspaceEdit(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Holds changes to existing resources.
    member _.Changes =
        // Requires specialization: "map"

        match element.TryGetProperty("changes") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Depending on the client capability `workspace.workspaceEdit.resourceOperations` document changes
    /// are either an array of `TextDocumentEdit`s to express changes to n different text documents
    /// where each text document edit addresses a specific version of a text document. Or it can contain
    /// above `TextDocumentEdit`s mixed with create, rename and delete file / folder operations.
    /// 
    /// Whether a client supports versioned document edits is expressed via
    /// `workspace.workspaceEdit.documentChanges` client capability.
    /// 
    /// If a client neither supports `documentChanges` nor `workspace.workspaceEdit.resourceOperations` then
    /// only plain `TextEdit`s using the `changes` property are supported.
    member _.DocumentChanges =
        // Requires specialization: "array"

        match element.TryGetProperty("documentChanges") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// A map of change annotations that can be referenced in `AnnotatedTextEdit`s or create, rename and
    /// delete file / folder operations.
    /// 
    /// Whether clients honor this property depends on the client capability `workspace.changeAnnotationSupport`.
    /// 
    /// @since 3.16.0
    member _.ChangeAnnotations =
        // Requires specialization: "map"

        match element.TryGetProperty("changeAnnotations") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceEdit(element))

/// The options to register for file operations.
/// 
/// @since 3.16.0
[<Struct>]
type FileOperationRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The actual filters.
    member _.Filters =
        // Requires specialization: "array"

        let prop = element.GetProperty("filters")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(FileOperationRegistrationOptions(element))

/// The parameters sent in notifications/requests for user-initiated renames of
/// files.
/// 
/// @since 3.16.0
[<Struct>]
type RenameFilesParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An array of all files/folders renamed in this operation. When a folder is renamed, only
    /// the folder will be included, and not its children.
    member _.Files =
        // Requires specialization: "array"

        let prop = element.GetProperty("files")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(RenameFilesParams(element))

/// The parameters sent in notifications/requests for user-initiated deletes of
/// files.
/// 
/// @since 3.16.0
[<Struct>]
type DeleteFilesParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An array of all files/folders deleted in this operation.
    member _.Files =
        // Requires specialization: "array"

        let prop = element.GetProperty("files")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DeleteFilesParams(element))

[<Struct>]
type MonikerParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(MonikerParams(element))
        else Error()

/// Moniker definition to match LSIF 0.5 moniker definition.
/// 
/// @since 3.16.0
[<Struct>]
type Moniker(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The scheme of the moniker. For example tsc or .Net
    member _.Scheme =
        let prop = element.GetProperty("scheme")
        global.Amongonz.LspTypes.LspString(prop)

    /// The identifier of the moniker. The value is opaque in LSIF however
    /// schema owners are allowed to define the structure if they want.
    member _.Identifier =
        let prop = element.GetProperty("identifier")
        global.Amongonz.LspTypes.LspString(prop)

    /// The scope in which the moniker is unique
    member _.Unique =
        let prop = element.GetProperty("unique")
        UniquenessLevel(prop)

    /// The moniker kind if known.
    member _.Kind =
        match element.TryGetProperty("kind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(MonikerKind(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "scheme" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "identifier" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "unique" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (UniquenessLevel.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "kind" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (MonikerKind.Parse(prop)))
            end
        then Ok(Moniker(element))
        else Error()

[<Struct>]
type MonikerRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(MonikerRegistrationOptions(element))

/// The parameter of a `textDocument/prepareTypeHierarchy` request.
/// 
/// @since 3.17.0
[<Struct>]
type TypeHierarchyPrepareParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(TypeHierarchyPrepareParams(element))
        else Error()

/// @since 3.17.0
[<Struct>]
type TypeHierarchyItem(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The name of this item.
    member _.Name =
        let prop = element.GetProperty("name")
        global.Amongonz.LspTypes.LspString(prop)

    /// The kind of this item.
    member _.Kind =
        let prop = element.GetProperty("kind")
        enum<SymbolKind>(prop.GetInt32())

    /// Tags for this item.
    member _.Tags =
        // Requires specialization: "array"

        match element.TryGetProperty("tags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// More detail for this item, e.g. the signature of a function.
    member _.Detail =
        match element.TryGetProperty("detail") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The resource identifier of this item.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The range enclosing this symbol not including leading/trailing whitespace
    /// but everything else, e.g. comments and code.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The range that should be selected and revealed when this symbol is being
    /// picked, e.g. the name of a function. Must be contained by the
    /// {@link TypeHierarchyItem.range `range`}.
    member _.SelectionRange =
        let prop = element.GetProperty("selectionRange")
        Range(prop)

    /// A data entry field that is preserved between a type hierarchy prepare and
    /// supertypes or subtypes requests. It could also be used to identify the
    /// type hierarchy in the server, helping improve the performance on
    /// resolving supertypes and subtypes.
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(TypeHierarchyItem(element))

/// Type hierarchy options used during static or dynamic registration.
/// 
/// @since 3.17.0
[<Struct>]
type TypeHierarchyRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(TypeHierarchyRegistrationOptions(element))

/// The parameter of a `typeHierarchy/supertypes` request.
/// 
/// @since 3.17.0
[<Struct>]
type TypeHierarchySupertypesParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Item =
        let prop = element.GetProperty("item")
        TypeHierarchyItem(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "item" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TypeHierarchyItem.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(TypeHierarchySupertypesParams(element))
        else Error()

/// The parameter of a `typeHierarchy/subtypes` request.
/// 
/// @since 3.17.0
[<Struct>]
type TypeHierarchySubtypesParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Item =
        let prop = element.GetProperty("item")
        TypeHierarchyItem(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "item" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TypeHierarchyItem.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(TypeHierarchySubtypesParams(element))
        else Error()

/// A parameter literal used in inline value requests.
/// 
/// @since 3.17.0
[<Struct>]
type InlineValueParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The document range for which inline values should be computed.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// Additional information about the context in which inline values were
    /// requested.
    member _.Context =
        let prop = element.GetProperty("context")
        InlineValueContext(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "context" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (InlineValueContext.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(InlineValueParams(element))
        else Error()

/// Inline value options used during static or dynamic registration.
/// 
/// @since 3.17.0
[<Struct>]
type InlineValueRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InlineValueRegistrationOptions(element))

/// A parameter literal used in inlay hint requests.
/// 
/// @since 3.17.0
[<Struct>]
type InlayHintParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The document range for which inlay hints should be computed.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(InlayHintParams(element))
        else Error()

/// Inlay hint information.
/// 
/// @since 3.17.0
[<Struct>]
type InlayHint(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The position of this hint.
    /// 
    /// If multiple hints have the same position, they will be shown in the order
    /// they appear in the response.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// The label of this hint. A human readable string or an array of
    /// InlayHintLabelPart label parts.
    /// 
    /// *Note* that neither the string nor the label part can be empty.
    member _.Label =
        // Requires specialization: "or"

        let prop = element.GetProperty("label")
        prop

    /// The kind of this hint. Can be omitted in which case the client
    /// should fall back to a reasonable default.
    member _.Kind =
        match element.TryGetProperty("kind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<InlayHintKind>(prop.GetInt32()))

    /// Optional text edits that are performed when accepting this inlay hint.
    /// 
    /// *Note* that edits are expected to change the document so that the inlay
    /// hint (or its nearest variant) is now part of the document and the inlay
    /// hint itself is now obsolete.
    member _.TextEdits =
        // Requires specialization: "array"

        match element.TryGetProperty("textEdits") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The tooltip text when you hover over this item.
    member _.Tooltip =
        // Requires specialization: "or"

        match element.TryGetProperty("tooltip") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Render padding before the hint.
    /// 
    /// Note: Padding should use the editor&apos;s background color, not the
    /// background color of the hint itself. That means padding can be used
    /// to visually align/separate an inlay hint.
    member _.PaddingLeft =
        match element.TryGetProperty("paddingLeft") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Render padding after the hint.
    /// 
    /// Note: Padding should use the editor&apos;s background color, not the
    /// background color of the hint itself. That means padding can be used
    /// to visually align/separate an inlay hint.
    member _.PaddingRight =
        match element.TryGetProperty("paddingRight") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// A data entry field that is preserved on an inlay hint between
    /// a `textDocument/inlayHint` and a `inlayHint/resolve` request.
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InlayHint(element))

/// Inlay hint options used during static or dynamic registration.
/// 
/// @since 3.17.0
[<Struct>]
type InlayHintRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The server provides support to resolve additional
    /// information for an inlay hint item.
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InlayHintRegistrationOptions(element))

/// Parameters of the document diagnostic request.
/// 
/// @since 3.17.0
[<Struct>]
type DocumentDiagnosticParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The additional identifier  provided during registration.
    member _.Identifier =
        match element.TryGetProperty("identifier") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The result id of a previous response if provided.
    member _.PreviousResultId =
        match element.TryGetProperty("previousResultId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "identifier" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "previousResultId" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DocumentDiagnosticParams(element))
        else Error()

/// A partial result for a document diagnostic report.
/// 
/// @since 3.17.0
[<Struct>]
type DocumentDiagnosticReportPartialResult(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.RelatedDocuments =
        // Requires specialization: "map"

        let prop = element.GetProperty("relatedDocuments")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentDiagnosticReportPartialResult(element))

/// Cancellation data returned from a diagnostic request.
/// 
/// @since 3.17.0
[<Struct>]
type DiagnosticServerCancellationData(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.RetriggerRequest =
        let prop = element.GetProperty("retriggerRequest")
        prop.GetBoolean()

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "retriggerRequest" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DiagnosticServerCancellationData(element))
        else Error()

/// Diagnostic registration options.
/// 
/// @since 3.17.0
[<Struct>]
type DiagnosticRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// An optional identifier under which the diagnostics are
    /// managed by the client.
    member _.Identifier =
        match element.TryGetProperty("identifier") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// Whether the language has inter file dependencies meaning that
    /// editing code in one file can result in a different diagnostic
    /// set in another file. Inter file dependencies are common for
    /// most programming languages and typically uncommon for linters.
    member _.InterFileDependencies =
        let prop = element.GetProperty("interFileDependencies")
        prop.GetBoolean()

    /// The server provides support for workspace diagnostics as well.
    member _.WorkspaceDiagnostics =
        let prop = element.GetProperty("workspaceDiagnostics")
        prop.GetBoolean()

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DiagnosticRegistrationOptions(element))

/// Parameters of the workspace diagnostic request.
/// 
/// @since 3.17.0
[<Struct>]
type WorkspaceDiagnosticParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The additional identifier provided during registration.
    member _.Identifier =
        match element.TryGetProperty("identifier") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The currently known diagnostic reports with their
    /// previous result ids.
    member _.PreviousResultIds =
        // Requires specialization: "array"

        let prop = element.GetProperty("previousResultIds")
        prop

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceDiagnosticParams(element))

/// A workspace diagnostic report.
/// 
/// @since 3.17.0
[<Struct>]
type WorkspaceDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Items =
        // Requires specialization: "array"

        let prop = element.GetProperty("items")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceDiagnosticReport(element))

/// A partial result for a workspace diagnostic report.
/// 
/// @since 3.17.0
[<Struct>]
type WorkspaceDiagnosticReportPartialResult(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Items =
        // Requires specialization: "array"

        let prop = element.GetProperty("items")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceDiagnosticReportPartialResult(element))

/// The params sent in an open notebook document notification.
/// 
/// @since 3.17.0
[<Struct>]
type DidOpenNotebookDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The notebook document that got opened.
    member _.NotebookDocument =
        let prop = element.GetProperty("notebookDocument")
        NotebookDocument(prop)

    /// The text documents that represent the content
    /// of a notebook cell.
    member _.CellTextDocuments =
        // Requires specialization: "array"

        let prop = element.GetProperty("cellTextDocuments")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DidOpenNotebookDocumentParams(element))

/// The params sent in a change notebook document notification.
/// 
/// @since 3.17.0
[<Struct>]
type DidChangeNotebookDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The notebook document that did change. The version number points
    /// to the version after all provided changes have been applied. If
    /// only the text document content of a cell changes the notebook version
    /// doesn&apos;t necessarily have to change.
    member _.NotebookDocument =
        let prop = element.GetProperty("notebookDocument")
        VersionedNotebookDocumentIdentifier(prop)

    /// The actual changes to the notebook document.
    /// 
    /// The changes describe single state changes to the notebook document.
    /// So if there are two changes c1 (at array index 0) and c2 (at array
    /// index 1) for a notebook in state S then c1 moves the notebook from
    /// S to S&apos; and c2 from S&apos; to S&apos;&apos;. So c1 is computed on the state S and
    /// c2 is computed on the state S&apos;.
    /// 
    /// To mirror the content of a notebook using change events use the following approach:
    /// - start with the same initial content
    /// - apply the &apos;notebookDocument/didChange&apos; notifications in the order you receive them.
    /// - apply the `NotebookChangeEvent`s in a single notification in the order
    ///   you receive them.
    member _.Change =
        let prop = element.GetProperty("change")
        NotebookDocumentChangeEvent(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "notebookDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (VersionedNotebookDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "change" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (NotebookDocumentChangeEvent.Parse(prop)))
            end
        then Ok(DidChangeNotebookDocumentParams(element))
        else Error()

/// The params sent in a save notebook document notification.
/// 
/// @since 3.17.0
[<Struct>]
type DidSaveNotebookDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The notebook document that got saved.
    member _.NotebookDocument =
        let prop = element.GetProperty("notebookDocument")
        NotebookDocumentIdentifier(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "notebookDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (NotebookDocumentIdentifier.Parse(prop)))
            end
        then Ok(DidSaveNotebookDocumentParams(element))
        else Error()

/// The params sent in a close notebook document notification.
/// 
/// @since 3.17.0
[<Struct>]
type DidCloseNotebookDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The notebook document that got closed.
    member _.NotebookDocument =
        let prop = element.GetProperty("notebookDocument")
        NotebookDocumentIdentifier(prop)

    /// The text documents that represent the content
    /// of a notebook cell that got closed.
    member _.CellTextDocuments =
        // Requires specialization: "array"

        let prop = element.GetProperty("cellTextDocuments")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DidCloseNotebookDocumentParams(element))

/// A parameter literal used in inline completion requests.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type InlineCompletionParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Additional information about the context in which inline completions were
    /// requested.
    member _.Context =
        let prop = element.GetProperty("context")
        InlineCompletionContext(prop)

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "context" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (InlineCompletionContext.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(InlineCompletionParams(element))
        else Error()

/// Represents a collection of {@link InlineCompletionItem inline completion items} to be presented in the editor.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type InlineCompletionList(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The inline completion items
    member _.Items =
        // Requires specialization: "array"

        let prop = element.GetProperty("items")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InlineCompletionList(element))

/// An inline completion item represents a text snippet that is proposed inline to complete text that is being typed.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type InlineCompletionItem(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text to replace the range with. Must be set.
    member _.InsertText =
        // Requires specialization: "or"

        let prop = element.GetProperty("insertText")
        prop

    /// A text that is used to decide if this inline completion should be shown. When `falsy` the {@link InlineCompletionItem.insertText} is used.
    member _.FilterText =
        match element.TryGetProperty("filterText") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The range to replace. Must begin and end on the same line.
    member _.Range =
        match element.TryGetProperty("range") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Range(prop))

    /// An optional {@link Command} that is executed *after* inserting this completion.
    member _.Command =
        match element.TryGetProperty("command") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Command(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InlineCompletionItem(element))

/// Inline completion options used during static or dynamic registration.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type InlineCompletionRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InlineCompletionRegistrationOptions(element))

[<Struct>]
type RegistrationParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Registrations =
        // Requires specialization: "array"

        let prop = element.GetProperty("registrations")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(RegistrationParams(element))

[<Struct>]
type UnregistrationParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Unregisterations =
        // Requires specialization: "array"

        let prop = element.GetProperty("unregisterations")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(UnregistrationParams(element))

[<Struct>]
type InitializeParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The process Id of the parent process that started
    /// the server.
    /// 
    /// Is `null` if the process has not been started by another process.
    /// If the parent process is not alive then the server should exit.
    member _.ProcessId =
        // Requires specialization: "or"

        let prop = element.GetProperty("processId")
        prop

    /// Information about the client
    /// 
    /// @since 3.15.0
    member _.ClientInfo =
        // Requires specialization: "literal"

        match element.TryGetProperty("clientInfo") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The locale the client is currently showing the user interface
    /// in. This must not necessarily be the locale of the operating
    /// system.
    /// 
    /// Uses IETF language tags as the value&apos;s syntax
    /// (See https://en.wikipedia.org/wiki/IETF_language_tag)
    /// 
    /// @since 3.16.0
    member _.Locale =
        match element.TryGetProperty("locale") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The rootPath of the workspace. Is null
    /// if no folder is open.
    /// 
    /// @deprecated in favour of rootUri.
    member _.RootPath =
        // Requires specialization: "or"

        match element.TryGetProperty("rootPath") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The rootUri of the workspace. Is null if no
    /// folder is open. If both `rootPath` and `rootUri` are set
    /// `rootUri` wins.
    /// 
    /// @deprecated in favour of workspaceFolders.
    member _.RootUri =
        // Requires specialization: "or"

        let prop = element.GetProperty("rootUri")
        prop

    /// The capabilities provided by the client (editor or tool)
    member _.Capabilities =
        let prop = element.GetProperty("capabilities")
        ClientCapabilities(prop)

    /// User provided initialization options.
    member _.InitializationOptions =
        match element.TryGetProperty("initializationOptions") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    /// The initial trace setting. If omitted trace is disabled (&apos;off&apos;).
    member _.Trace =
        match element.TryGetProperty("trace") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(TraceValues(prop))

    /// The workspace folders configured in the client when the server starts.
    /// 
    /// This property is only available if the client supports workspace folders.
    /// It can be `null` if the client supports workspace folders but none are
    /// configured.
    /// 
    /// @since 3.6.0
    member _.WorkspaceFolders =
        // Requires specialization: "or"

        match element.TryGetProperty("workspaceFolders") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InitializeParams(element))

/// The result returned from an initialize request.
[<Struct>]
type InitializeResult(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The capabilities the language server provides.
    member _.Capabilities =
        let prop = element.GetProperty("capabilities")
        ServerCapabilities(prop)

    /// Information about the server.
    /// 
    /// @since 3.15.0
    member _.ServerInfo =
        // Requires specialization: "literal"

        match element.TryGetProperty("serverInfo") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InitializeResult(element))

/// The data type of the ResponseError if the
/// initialize request fails.
[<Struct>]
type InitializeError(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Indicates whether the client execute the following retry logic:
    /// (1) show the message provided by the ResponseError to the user
    /// (2) user selects retry or cancel
    /// (3) if user selected retry the initialize method is sent again.
    member _.Retry =
        let prop = element.GetProperty("retry")
        prop.GetBoolean()

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "retry" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InitializeError(element))
        else Error()

[<Struct>]
type InitializedParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
        then Ok(InitializedParams(element))
        else Error()

/// The parameters of a change configuration notification.
[<Struct>]
type DidChangeConfigurationParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The actual changed settings
    member _.Settings =
        let prop = element.GetProperty("settings")
        LSPAny(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "settings" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (LSPAny.Parse(prop)))
            end
        then Ok(DidChangeConfigurationParams(element))
        else Error()

[<Struct>]
type DidChangeConfigurationRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Section =
        // Requires specialization: "or"

        match element.TryGetProperty("section") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DidChangeConfigurationRegistrationOptions(element))

/// The parameters of a notification message.
[<Struct>]
type ShowMessageParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The message type. See {@link MessageType}
    member _.Type =
        let prop = element.GetProperty("type")
        enum<MessageType>(prop.GetInt32())

    /// The actual message.
    member _.Message =
        let prop = element.GetProperty("message")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "type" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> true)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "message" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(ShowMessageParams(element))
        else Error()

[<Struct>]
type ShowMessageRequestParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The message type. See {@link MessageType}
    member _.Type =
        let prop = element.GetProperty("type")
        enum<MessageType>(prop.GetInt32())

    /// The actual message.
    member _.Message =
        let prop = element.GetProperty("message")
        global.Amongonz.LspTypes.LspString(prop)

    /// The message action items to present.
    member _.Actions =
        // Requires specialization: "array"

        match element.TryGetProperty("actions") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ShowMessageRequestParams(element))

[<Struct>]
type MessageActionItem(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A short title like &apos;Retry&apos;, &apos;Open Log&apos; etc.
    member _.Title =
        let prop = element.GetProperty("title")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "title" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(MessageActionItem(element))
        else Error()

/// The log message parameters.
[<Struct>]
type LogMessageParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The message type. See {@link MessageType}
    member _.Type =
        let prop = element.GetProperty("type")
        enum<MessageType>(prop.GetInt32())

    /// The actual message.
    member _.Message =
        let prop = element.GetProperty("message")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "type" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> true)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "message" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(LogMessageParams(element))
        else Error()

/// The parameters sent in an open text document notification
[<Struct>]
type DidOpenTextDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document that was opened.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentItem(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentItem.Parse(prop)))
            end
        then Ok(DidOpenTextDocumentParams(element))
        else Error()

/// The change text document notification&apos;s parameters.
[<Struct>]
type DidChangeTextDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document that did change. The version number points
    /// to the version after all provided content changes have
    /// been applied.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        VersionedTextDocumentIdentifier(prop)

    /// The actual content changes. The content changes describe single state changes
    /// to the document. So if there are two content changes c1 (at array index 0) and
    /// c2 (at array index 1) for a document in state S then c1 moves the document from
    /// S to S&apos; and c2 from S&apos; to S&apos;&apos;. So c1 is computed on the state S and c2 is computed
    /// on the state S&apos;.
    /// 
    /// To mirror the content of a document using change events use the following approach:
    /// - start with the same initial content
    /// - apply the &apos;textDocument/didChange&apos; notifications in the order you receive them.
    /// - apply the `TextDocumentContentChangeEvent`s in a single notification in the order
    ///   you receive them.
    member _.ContentChanges =
        // Requires specialization: "array"

        let prop = element.GetProperty("contentChanges")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DidChangeTextDocumentParams(element))

/// Describe options to be used when registered for text document change events.
[<Struct>]
type TextDocumentChangeRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// How documents are synced to the server.
    member _.SyncKind =
        let prop = element.GetProperty("syncKind")
        enum<TextDocumentSyncKind>(prop.GetInt32())

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(TextDocumentChangeRegistrationOptions(element))

/// The parameters sent in a close text document notification
[<Struct>]
type DidCloseTextDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document that was closed.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
        then Ok(DidCloseTextDocumentParams(element))
        else Error()

/// The parameters sent in a save text document notification
[<Struct>]
type DidSaveTextDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document that was saved.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// Optional the content when saved. Depends on the includeText value
    /// when the save notification was requested.
    member _.Text =
        match element.TryGetProperty("text") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "text" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(DidSaveTextDocumentParams(element))
        else Error()

/// Save registration options.
[<Struct>]
type TextDocumentSaveRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// The client is supposed to include the content on save.
    member _.IncludeText =
        match element.TryGetProperty("includeText") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(TextDocumentSaveRegistrationOptions(element))

/// The parameters sent in a will save text document notification.
[<Struct>]
type WillSaveTextDocumentParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document that will be saved.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The &apos;TextDocumentSaveReason&apos;.
    member _.Reason =
        let prop = element.GetProperty("reason")
        enum<TextDocumentSaveReason>(prop.GetInt32())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "reason" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> true)
            end
        then Ok(WillSaveTextDocumentParams(element))
        else Error()

/// A text edit applicable to a text document.
[<Struct>]
type TextEdit(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The range of the text document to be manipulated. To insert
    /// text into a document create a range where start === end.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The string to be inserted. For delete operations use an
    /// empty string.
    member _.NewText =
        let prop = element.GetProperty("newText")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "newText" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(TextEdit(element))
        else Error()

/// The watched files change notification&apos;s parameters.
[<Struct>]
type DidChangeWatchedFilesParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The actual file events.
    member _.Changes =
        // Requires specialization: "array"

        let prop = element.GetProperty("changes")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DidChangeWatchedFilesParams(element))

/// Describe options to be used when registered for text document change events.
[<Struct>]
type DidChangeWatchedFilesRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The watchers to register.
    member _.Watchers =
        // Requires specialization: "array"

        let prop = element.GetProperty("watchers")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DidChangeWatchedFilesRegistrationOptions(element))

/// The publish diagnostic notification&apos;s parameters.
[<Struct>]
type PublishDiagnosticsParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The URI for which diagnostic information is reported.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// Optional the version number of the document the diagnostics are published for.
    /// 
    /// @since 3.15.0
    member _.Version =
        match element.TryGetProperty("version") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    /// An array of diagnostic information items.
    member _.Diagnostics =
        // Requires specialization: "array"

        let prop = element.GetProperty("diagnostics")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(PublishDiagnosticsParams(element))

/// Completion parameters
[<Struct>]
type CompletionParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The completion context. This is only available it the client specifies
    /// to send this using the client capability `textDocument.completion.contextSupport === true`
    member _.Context =
        match element.TryGetProperty("context") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CompletionContext(prop))

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "context" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (CompletionContext.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(CompletionParams(element))
        else Error()

/// A completion item represents a text snippet that is
/// proposed to complete text that is being typed.
[<Struct>]
type CompletionItem(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The label of this completion item.
    /// 
    /// The label property is also by default the text that
    /// is inserted when selecting this completion.
    /// 
    /// If label details are provided the label itself should
    /// be an unqualified name of the completion item.
    member _.Label =
        let prop = element.GetProperty("label")
        global.Amongonz.LspTypes.LspString(prop)

    /// Additional details for the label
    /// 
    /// @since 3.17.0
    member _.LabelDetails =
        match element.TryGetProperty("labelDetails") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CompletionItemLabelDetails(prop))

    /// The kind of this completion item. Based of the kind
    /// an icon is chosen by the editor.
    member _.Kind =
        match element.TryGetProperty("kind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<CompletionItemKind>(prop.GetInt32()))

    /// Tags for this completion item.
    /// 
    /// @since 3.15.0
    member _.Tags =
        // Requires specialization: "array"

        match element.TryGetProperty("tags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// A human-readable string with additional information
    /// about this item, like type or symbol information.
    member _.Detail =
        match element.TryGetProperty("detail") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// A human-readable string that represents a doc-comment.
    member _.Documentation =
        // Requires specialization: "or"

        match element.TryGetProperty("documentation") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Indicates if this item is deprecated.
    /// @deprecated Use `tags` instead.
    member _.Deprecated =
        match element.TryGetProperty("deprecated") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Select this item when showing.
    /// 
    /// *Note* that only one completion item can be selected and that the
    /// tool / client decides which item that is. The rule is that the *first*
    /// item of those that match best is selected.
    member _.Preselect =
        match element.TryGetProperty("preselect") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// A string that should be used when comparing this item
    /// with other items. When `falsy` the {@link CompletionItem.label label}
    /// is used.
    member _.SortText =
        match element.TryGetProperty("sortText") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// A string that should be used when filtering a set of
    /// completion items. When `falsy` the {@link CompletionItem.label label}
    /// is used.
    member _.FilterText =
        match element.TryGetProperty("filterText") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// A string that should be inserted into a document when selecting
    /// this completion. When `falsy` the {@link CompletionItem.label label}
    /// is used.
    /// 
    /// The `insertText` is subject to interpretation by the client side.
    /// Some tools might not take the string literally. For example
    /// VS Code when code complete is requested in this example
    /// `con&lt;cursor position&gt;` and a completion item with an `insertText` of
    /// `console` is provided it will only insert `sole`. Therefore it is
    /// recommended to use `textEdit` instead since it avoids additional client
    /// side interpretation.
    member _.InsertText =
        match element.TryGetProperty("insertText") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The format of the insert text. The format applies to both the
    /// `insertText` property and the `newText` property of a provided
    /// `textEdit`. If omitted defaults to `InsertTextFormat.PlainText`.
    /// 
    /// Please note that the insertTextFormat doesn&apos;t apply to
    /// `additionalTextEdits`.
    member _.InsertTextFormat =
        match element.TryGetProperty("insertTextFormat") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<InsertTextFormat>(prop.GetInt32()))

    /// How whitespace and indentation is handled during completion
    /// item insertion. If not provided the clients default value depends on
    /// the `textDocument.completion.insertTextMode` client capability.
    /// 
    /// @since 3.16.0
    member _.InsertTextMode =
        match element.TryGetProperty("insertTextMode") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<InsertTextMode>(prop.GetInt32()))

    /// An {@link TextEdit edit} which is applied to a document when selecting
    /// this completion. When an edit is provided the value of
    /// {@link CompletionItem.insertText insertText} is ignored.
    /// 
    /// Most editors support two different operations when accepting a completion
    /// item. One is to insert a completion text and the other is to replace an
    /// existing text with a completion text. Since this can usually not be
    /// predetermined by a server it can report both ranges. Clients need to
    /// signal support for `InsertReplaceEdits` via the
    /// `textDocument.completion.insertReplaceSupport` client capability
    /// property.
    /// 
    /// *Note 1:* The text edit&apos;s range as well as both ranges from an insert
    /// replace edit must be a [single line] and they must contain the position
    /// at which completion has been requested.
    /// *Note 2:* If an `InsertReplaceEdit` is returned the edit&apos;s insert range
    /// must be a prefix of the edit&apos;s replace range, that means it must be
    /// contained and starting at the same position.
    /// 
    /// @since 3.16.0 additional type `InsertReplaceEdit`
    member _.TextEdit =
        // Requires specialization: "or"

        match element.TryGetProperty("textEdit") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The edit text used if the completion item is part of a CompletionList and
    /// CompletionList defines an item default for the text edit range.
    /// 
    /// Clients will only honor this property if they opt into completion list
    /// item defaults using the capability `completionList.itemDefaults`.
    /// 
    /// If not provided and a list&apos;s default range is provided the label
    /// property is used as a text.
    /// 
    /// @since 3.17.0
    member _.TextEditText =
        match element.TryGetProperty("textEditText") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// An optional array of additional {@link TextEdit text edits} that are applied when
    /// selecting this completion. Edits must not overlap (including the same insert position)
    /// with the main {@link CompletionItem.textEdit edit} nor with themselves.
    /// 
    /// Additional text edits should be used to change text unrelated to the current cursor position
    /// (for example adding an import statement at the top of the file if the completion item will
    /// insert an unqualified type).
    member _.AdditionalTextEdits =
        // Requires specialization: "array"

        match element.TryGetProperty("additionalTextEdits") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// An optional set of characters that when pressed while this completion is active will accept it first and
    /// then type that character. *Note* that all commit characters should have `length=1` and that superfluous
    /// characters will be ignored.
    member _.CommitCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("commitCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// An optional {@link Command command} that is executed *after* inserting this completion. *Note* that
    /// additional modifications to the current document should be described with the
    /// {@link CompletionItem.additionalTextEdits additionalTextEdits}-property.
    member _.Command =
        match element.TryGetProperty("command") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Command(prop))

    /// A data entry field that is preserved on a completion item between a
    /// {@link CompletionRequest} and a {@link CompletionResolveRequest}.
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CompletionItem(element))

/// Represents a collection of {@link CompletionItem completion items} to be presented
/// in the editor.
[<Struct>]
type CompletionList(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// This list it not complete. Further typing results in recomputing this list.
    /// 
    /// Recomputed lists have all their items replaced (not appended) in the
    /// incomplete completion sessions.
    member _.IsIncomplete =
        let prop = element.GetProperty("isIncomplete")
        prop.GetBoolean()

    /// In many cases the items of an actual completion result share the same
    /// value for properties like `commitCharacters` or the range of a text
    /// edit. A completion list can therefore define item defaults which will
    /// be used if a completion item itself doesn&apos;t specify the value.
    /// 
    /// If a completion list specifies a default value and a completion item
    /// also specifies a corresponding value the one from the item is used.
    /// 
    /// Servers are only allowed to return default values if the client
    /// signals support for this via the `completionList.itemDefaults`
    /// capability.
    /// 
    /// @since 3.17.0
    member _.ItemDefaults =
        // Requires specialization: "literal"

        match element.TryGetProperty("itemDefaults") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The completion items.
    member _.Items =
        // Requires specialization: "array"

        let prop = element.GetProperty("items")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CompletionList(element))

/// Registration options for a {@link CompletionRequest}.
[<Struct>]
type CompletionRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// Most tools trigger completion request automatically without explicitly requesting
    /// it using a keyboard shortcut (e.g. Ctrl+Space). Typically they do so when the user
    /// starts to type an identifier. For example if the user types `c` in a JavaScript file
    /// code complete will automatically pop up present `console` besides others as a
    /// completion item. Characters that make up identifiers don&apos;t need to be listed here.
    /// 
    /// If code complete should automatically be trigger on characters not being valid inside
    /// an identifier (for example `.` in JavaScript) list them in `triggerCharacters`.
    member _.TriggerCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("triggerCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The list of all possible characters that commit a completion. This field can be used
    /// if clients don&apos;t support individual commit characters per completion item. See
    /// `ClientCapabilities.textDocument.completion.completionItem.commitCharactersSupport`
    /// 
    /// If a server provides both `allCommitCharacters` and commit characters on an individual
    /// completion item the ones on the completion item win.
    /// 
    /// @since 3.2.0
    member _.AllCommitCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("allCommitCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides support to resolve additional
    /// information for a completion item.
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The server supports the following `CompletionItem` specific
    /// capabilities.
    /// 
    /// @since 3.17.0
    member _.CompletionItem =
        // Requires specialization: "literal"

        match element.TryGetProperty("completionItem") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CompletionRegistrationOptions(element))

/// Parameters for a {@link HoverRequest}.
[<Struct>]
type HoverParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(HoverParams(element))
        else Error()

/// The result of a hover request.
[<Struct>]
type Hover(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The hover&apos;s content
    member _.Contents =
        // Requires specialization: "or"

        let prop = element.GetProperty("contents")
        prop

    /// An optional range inside the text document that is used to
    /// visualize the hover, e.g. by changing the background color.
    member _.Range =
        match element.TryGetProperty("range") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Range(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(Hover(element))

/// Registration options for a {@link HoverRequest}.
[<Struct>]
type HoverRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(HoverRegistrationOptions(element))

/// Parameters for a {@link SignatureHelpRequest}.
[<Struct>]
type SignatureHelpParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The signature help context. This is only available if the client specifies
    /// to send this using the client capability `textDocument.signatureHelp.contextSupport === true`
    /// 
    /// @since 3.15.0
    member _.Context =
        match element.TryGetProperty("context") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SignatureHelpContext(prop))

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "context" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (SignatureHelpContext.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(SignatureHelpParams(element))
        else Error()

/// Signature help represents the signature of something
/// callable. There can be multiple signature but only one
/// active and only one active parameter.
[<Struct>]
type SignatureHelp(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// One or more signatures.
    member _.Signatures =
        // Requires specialization: "array"

        let prop = element.GetProperty("signatures")
        prop

    /// The active signature. If omitted or the value lies outside the
    /// range of `signatures` the value defaults to zero or is ignored if
    /// the `SignatureHelp` has no signatures.
    /// 
    /// Whenever possible implementors should make an active decision about
    /// the active signature and shouldn&apos;t rely on a default value.
    /// 
    /// In future version of the protocol this property might become
    /// mandatory to better express this.
    member _.ActiveSignature =
        match element.TryGetProperty("activeSignature") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    /// The active parameter of the active signature. If omitted or the value
    /// lies outside the range of `signatures[activeSignature].parameters`
    /// defaults to 0 if the active signature has parameters. If
    /// the active signature has no parameters it is ignored.
    /// In future version of the protocol this property might become
    /// mandatory to better express the active parameter if the
    /// active signature does have any.
    member _.ActiveParameter =
        match element.TryGetProperty("activeParameter") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SignatureHelp(element))

/// Registration options for a {@link SignatureHelpRequest}.
[<Struct>]
type SignatureHelpRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// List of characters that trigger signature help automatically.
    member _.TriggerCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("triggerCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// List of characters that re-trigger signature help.
    /// 
    /// These trigger characters are only active when signature help is already showing. All trigger characters
    /// are also counted as re-trigger characters.
    /// 
    /// @since 3.15.0
    member _.RetriggerCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("retriggerCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SignatureHelpRegistrationOptions(element))

/// Parameters for a {@link DefinitionRequest}.
[<Struct>]
type DefinitionParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DefinitionParams(element))
        else Error()

/// Registration options for a {@link DefinitionRequest}.
[<Struct>]
type DefinitionRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DefinitionRegistrationOptions(element))

/// Parameters for a {@link ReferencesRequest}.
[<Struct>]
type ReferenceParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Context =
        let prop = element.GetProperty("context")
        ReferenceContext(prop)

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "context" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (ReferenceContext.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(ReferenceParams(element))
        else Error()

/// Registration options for a {@link ReferencesRequest}.
[<Struct>]
type ReferenceRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ReferenceRegistrationOptions(element))

/// Parameters for a {@link DocumentHighlightRequest}.
[<Struct>]
type DocumentHighlightParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DocumentHighlightParams(element))
        else Error()

/// A document highlight is a range inside a text document which deserves
/// special attention. Usually a document highlight is visualized by changing
/// the background color of its range.
[<Struct>]
type DocumentHighlight(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The range this highlight applies to.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The highlight kind, default is {@link DocumentHighlightKind.Text text}.
    member _.Kind =
        match element.TryGetProperty("kind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<DocumentHighlightKind>(prop.GetInt32()))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "kind" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> true)
            end
        then Ok(DocumentHighlight(element))
        else Error()

/// Registration options for a {@link DocumentHighlightRequest}.
[<Struct>]
type DocumentHighlightRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentHighlightRegistrationOptions(element))

/// Parameters for a {@link DocumentSymbolRequest}.
[<Struct>]
type DocumentSymbolParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DocumentSymbolParams(element))
        else Error()

/// Represents information about programming constructs like variables, classes,
/// interfaces etc.
[<Struct>]
type SymbolInformation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Indicates if this symbol is deprecated.
    /// 
    /// @deprecated Use tags instead
    member _.Deprecated =
        match element.TryGetProperty("deprecated") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The location of this symbol. The location&apos;s range is used by a tool
    /// to reveal the location in the editor. If the symbol is selected in the
    /// tool the range&apos;s start information is used to position the cursor. So
    /// the range usually spans more than the actual symbol&apos;s name and does
    /// normally include things like visibility modifiers.
    /// 
    /// The range doesn&apos;t have to denote a node range in the sense of an abstract
    /// syntax tree. It can therefore not be used to re-construct a hierarchy of
    /// the symbols.
    member _.Location =
        let prop = element.GetProperty("location")
        Location(prop)

    /// The name of this symbol.
    member _.Name =
        let prop = element.GetProperty("name")
        global.Amongonz.LspTypes.LspString(prop)

    /// The kind of this symbol.
    member _.Kind =
        let prop = element.GetProperty("kind")
        enum<SymbolKind>(prop.GetInt32())

    /// Tags for this symbol.
    /// 
    /// @since 3.16.0
    member _.Tags =
        // Requires specialization: "array"

        match element.TryGetProperty("tags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The name of the symbol containing this symbol. This information is for
    /// user interface purposes (e.g. to render a qualifier in the user interface
    /// if necessary). It can&apos;t be used to re-infer a hierarchy for the document
    /// symbols.
    member _.ContainerName =
        match element.TryGetProperty("containerName") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SymbolInformation(element))

/// Represents programming constructs like variables, classes, interfaces etc.
/// that appear in a document. Document symbols can be hierarchical and they
/// have two ranges: one that encloses its definition and one that points to
/// its most interesting range, e.g. the range of an identifier.
[<Struct>]
type DocumentSymbol(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The name of this symbol. Will be displayed in the user interface and therefore must not be
    /// an empty string or a string only consisting of white spaces.
    member _.Name =
        let prop = element.GetProperty("name")
        global.Amongonz.LspTypes.LspString(prop)

    /// More detail for this symbol, e.g the signature of a function.
    member _.Detail =
        match element.TryGetProperty("detail") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The kind of this symbol.
    member _.Kind =
        let prop = element.GetProperty("kind")
        enum<SymbolKind>(prop.GetInt32())

    /// Tags for this document symbol.
    /// 
    /// @since 3.16.0
    member _.Tags =
        // Requires specialization: "array"

        match element.TryGetProperty("tags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Indicates if this symbol is deprecated.
    /// 
    /// @deprecated Use tags instead
    member _.Deprecated =
        match element.TryGetProperty("deprecated") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The range enclosing this symbol not including leading/trailing whitespace but everything else
    /// like comments. This information is typically used to determine if the clients cursor is
    /// inside the symbol to reveal in the symbol in the UI.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The range that should be selected and revealed when this symbol is being picked, e.g the name of a function.
    /// Must be contained by the `range`.
    member _.SelectionRange =
        let prop = element.GetProperty("selectionRange")
        Range(prop)

    /// Children of this symbol, e.g. properties of a class.
    member _.Children =
        // Requires specialization: "array"

        match element.TryGetProperty("children") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentSymbol(element))

/// Registration options for a {@link DocumentSymbolRequest}.
[<Struct>]
type DocumentSymbolRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// A human-readable string that is shown when multiple outlines trees
    /// are shown for the same document.
    /// 
    /// @since 3.16.0
    member _.Label =
        match element.TryGetProperty("label") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentSymbolRegistrationOptions(element))

/// The parameters of a {@link CodeActionRequest}.
[<Struct>]
type CodeActionParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document in which the command was invoked.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The range for which the command was invoked.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// Context carrying additional information.
    member _.Context =
        let prop = element.GetProperty("context")
        CodeActionContext(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "context" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (CodeActionContext.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(CodeActionParams(element))
        else Error()

/// Represents a reference to a command. Provides a title which
/// will be used to represent a command in the UI and, optionally,
/// an array of arguments which will be passed to the command handler
/// function when invoked.
[<Struct>]
type Command(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Title of the command, like `save`.
    member _.Title =
        let prop = element.GetProperty("title")
        global.Amongonz.LspTypes.LspString(prop)

    /// The identifier of the actual command handler.
    member _.Command =
        let prop = element.GetProperty("command")
        global.Amongonz.LspTypes.LspString(prop)

    /// Arguments that the command handler should be
    /// invoked with.
    member _.Arguments =
        // Requires specialization: "array"

        match element.TryGetProperty("arguments") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(Command(element))

/// A code action represents a change that can be performed in code, e.g. to fix a problem or
/// to refactor code.
/// 
/// A CodeAction must set either `edit` and/or a `command`. If both are supplied, the `edit` is applied first, then the `command` is executed.
[<Struct>]
type CodeAction(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A short, human-readable, title for this code action.
    member _.Title =
        let prop = element.GetProperty("title")
        global.Amongonz.LspTypes.LspString(prop)

    /// The kind of the code action.
    /// 
    /// Used to filter code actions.
    member _.Kind =
        match element.TryGetProperty("kind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CodeActionKind(prop))

    /// The diagnostics that this code action resolves.
    member _.Diagnostics =
        // Requires specialization: "array"

        match element.TryGetProperty("diagnostics") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Marks this as a preferred action. Preferred actions are used by the `auto fix` command and can be targeted
    /// by keybindings.
    /// 
    /// A quick fix should be marked preferred if it properly addresses the underlying error.
    /// A refactoring should be marked preferred if it is the most reasonable choice of actions to take.
    /// 
    /// @since 3.15.0
    member _.IsPreferred =
        match element.TryGetProperty("isPreferred") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Marks that the code action cannot currently be applied.
    /// 
    /// Clients should follow the following guidelines regarding disabled code actions:
    /// 
    ///   - Disabled code actions are not shown in automatic [lightbulbs](https://code.visualstudio.com/docs/editor/editingevolved#_code-action)
    ///     code action menus.
    /// 
    ///   - Disabled actions are shown as faded out in the code action menu when the user requests a more specific type
    ///     of code action, such as refactorings.
    /// 
    ///   - If the user has a [keybinding](https://code.visualstudio.com/docs/editor/refactoring#_keybindings-for-code-actions)
    ///     that auto applies a code action and only disabled code actions are returned, the client should show the user an
    ///     error message with `reason` in the editor.
    /// 
    /// @since 3.16.0
    member _.Disabled =
        // Requires specialization: "literal"

        match element.TryGetProperty("disabled") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The workspace edit this code action performs.
    member _.Edit =
        match element.TryGetProperty("edit") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(WorkspaceEdit(prop))

    /// A command this code action executes. If a code action
    /// provides an edit and a command, first the edit is
    /// executed and then the command.
    member _.Command =
        match element.TryGetProperty("command") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Command(prop))

    /// A data entry field that is preserved on a code action between
    /// a `textDocument/codeAction` and a `codeAction/resolve` request.
    /// 
    /// @since 3.16.0
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CodeAction(element))

/// Registration options for a {@link CodeActionRequest}.
[<Struct>]
type CodeActionRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// CodeActionKinds that this server may return.
    /// 
    /// The list of kinds may be generic, such as `CodeActionKind.Refactor`, or the server
    /// may list out every specific kind they provide.
    member _.CodeActionKinds =
        // Requires specialization: "array"

        match element.TryGetProperty("codeActionKinds") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides support to resolve additional
    /// information for a code action.
    /// 
    /// @since 3.16.0
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CodeActionRegistrationOptions(element))

/// The parameters of a {@link WorkspaceSymbolRequest}.
[<Struct>]
type WorkspaceSymbolParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A query string to filter symbols by. Clients may send an empty
    /// string here to request all symbols.
    member _.Query =
        let prop = element.GetProperty("query")
        global.Amongonz.LspTypes.LspString(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "query" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(WorkspaceSymbolParams(element))
        else Error()

/// A special workspace symbol that supports locations without a range.
/// 
/// See also SymbolInformation.
/// 
/// @since 3.17.0
[<Struct>]
type WorkspaceSymbol(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The location of the symbol. Whether a server is allowed to
    /// return a location without a range depends on the client
    /// capability `workspace.symbol.resolveSupport`.
    /// 
    /// See SymbolInformation#location for more details.
    member _.Location =
        // Requires specialization: "or"

        let prop = element.GetProperty("location")
        prop

    /// A data entry field that is preserved on a workspace symbol between a
    /// workspace symbol request and a workspace symbol resolve request.
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    /// The name of this symbol.
    member _.Name =
        let prop = element.GetProperty("name")
        global.Amongonz.LspTypes.LspString(prop)

    /// The kind of this symbol.
    member _.Kind =
        let prop = element.GetProperty("kind")
        enum<SymbolKind>(prop.GetInt32())

    /// Tags for this symbol.
    /// 
    /// @since 3.16.0
    member _.Tags =
        // Requires specialization: "array"

        match element.TryGetProperty("tags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The name of the symbol containing this symbol. This information is for
    /// user interface purposes (e.g. to render a qualifier in the user interface
    /// if necessary). It can&apos;t be used to re-infer a hierarchy for the document
    /// symbols.
    member _.ContainerName =
        match element.TryGetProperty("containerName") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceSymbol(element))

/// Registration options for a {@link WorkspaceSymbolRequest}.
[<Struct>]
type WorkspaceSymbolRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The server provides support to resolve additional
    /// information for a workspace symbol.
    /// 
    /// @since 3.17.0
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "resolveProvider" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(WorkspaceSymbolRegistrationOptions(element))
        else Error()

/// The parameters of a {@link CodeLensRequest}.
[<Struct>]
type CodeLensParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document to request code lens for.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(CodeLensParams(element))
        else Error()

/// A code lens represents a {@link Command command} that should be shown along with
/// source text, like the number of references, a way to run tests, etc.
/// 
/// A code lens is _unresolved_ when no command is associated to it. For performance
/// reasons the creation of a code lens and resolving should be done in two stages.
[<Struct>]
type CodeLens(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The range in which this code lens is valid. Should only span a single line.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The command this code lens represents.
    member _.Command =
        match element.TryGetProperty("command") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Command(prop))

    /// A data entry field that is preserved on a code lens item between
    /// a {@link CodeLensRequest} and a {@link CodeLensResolveRequest}
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "command" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (Command.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "data" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (LSPAny.Parse(prop)))
            end
        then Ok(CodeLens(element))
        else Error()

/// Registration options for a {@link CodeLensRequest}.
[<Struct>]
type CodeLensRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// Code lens has a resolve provider as well.
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CodeLensRegistrationOptions(element))

/// The parameters of a {@link DocumentLinkRequest}.
[<Struct>]
type DocumentLinkParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document to provide document links for.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DocumentLinkParams(element))
        else Error()

/// A document link is a range in a text document that links to an internal or external resource, like another
/// text document or a web site.
[<Struct>]
type DocumentLink(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The range this link applies to.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The uri this link points to. If missing a resolve request is sent later.
    member _.Target =
        match element.TryGetProperty("target") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.System.Uri(prop.GetString()))

    /// The tooltip text when you hover over this link.
    /// 
    /// If a tooltip is provided, is will be displayed in a string that includes instructions on how to
    /// trigger the link, such as `{0} (ctrl + click)`. The specific instructions vary depending on OS,
    /// user settings, and localization.
    /// 
    /// @since 3.15.0
    member _.Tooltip =
        match element.TryGetProperty("tooltip") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// A data entry field that is preserved on a document link between a
    /// DocumentLinkRequest and a DocumentLinkResolveRequest.
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "target" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "tooltip" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "data" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (LSPAny.Parse(prop)))
            end
        then Ok(DocumentLink(element))
        else Error()

/// Registration options for a {@link DocumentLinkRequest}.
[<Struct>]
type DocumentLinkRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// Document links have a resolve provider as well.
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentLinkRegistrationOptions(element))

/// The parameters of a {@link DocumentFormattingRequest}.
[<Struct>]
type DocumentFormattingParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document to format.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The format options.
    member _.Options =
        let prop = element.GetProperty("options")
        FormattingOptions(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "options" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (FormattingOptions.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DocumentFormattingParams(element))
        else Error()

/// Registration options for a {@link DocumentFormattingRequest}.
[<Struct>]
type DocumentFormattingRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentFormattingRegistrationOptions(element))

/// The parameters of a {@link DocumentRangeFormattingRequest}.
[<Struct>]
type DocumentRangeFormattingParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document to format.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The range to format
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The format options
    member _.Options =
        let prop = element.GetProperty("options")
        FormattingOptions(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "options" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (FormattingOptions.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(DocumentRangeFormattingParams(element))
        else Error()

/// Registration options for a {@link DocumentRangeFormattingRequest}.
[<Struct>]
type DocumentRangeFormattingRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// Whether the server supports formatting multiple ranges at once.
    /// 
    /// @since 3.18.0
    /// @proposed
    member _.RangesSupport =
        match element.TryGetProperty("rangesSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentRangeFormattingRegistrationOptions(element))

/// The parameters of a {@link DocumentRangesFormattingRequest}.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type DocumentRangesFormattingParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document to format.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The ranges to format
    member _.Ranges =
        // Requires specialization: "array"

        let prop = element.GetProperty("ranges")
        prop

    /// The format options
    member _.Options =
        let prop = element.GetProperty("options")
        FormattingOptions(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentRangesFormattingParams(element))

/// The parameters of a {@link DocumentOnTypeFormattingRequest}.
[<Struct>]
type DocumentOnTypeFormattingParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document to format.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position around which the on type formatting should happen.
    /// This is not necessarily the exact position where the character denoted
    /// by the property `ch` got typed.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// The character that has been typed that triggered the formatting
    /// on type request. That is not necessarily the last character that
    /// got inserted into the document since the client could auto insert
    /// characters as well (e.g. like automatic brace completion).
    member _.Ch =
        let prop = element.GetProperty("ch")
        global.Amongonz.LspTypes.LspString(prop)

    /// The formatting options.
    member _.Options =
        let prop = element.GetProperty("options")
        FormattingOptions(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "ch" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "options" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (FormattingOptions.Parse(prop)))
            end
        then Ok(DocumentOnTypeFormattingParams(element))
        else Error()

/// Registration options for a {@link DocumentOnTypeFormattingRequest}.
[<Struct>]
type DocumentOnTypeFormattingRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// A character on which formatting should be triggered, like `{`.
    member _.FirstTriggerCharacter =
        let prop = element.GetProperty("firstTriggerCharacter")
        global.Amongonz.LspTypes.LspString(prop)

    /// More trigger characters.
    member _.MoreTriggerCharacter =
        // Requires specialization: "array"

        match element.TryGetProperty("moreTriggerCharacter") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentOnTypeFormattingRegistrationOptions(element))

/// The parameters of a {@link RenameRequest}.
[<Struct>]
type RenameParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document to rename.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position at which this request was sent.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// The new name of the symbol. If the given name is not valid the
    /// request must return a {@link ResponseError} with an
    /// appropriate message set.
    member _.NewName =
        let prop = element.GetProperty("newName")
        global.Amongonz.LspTypes.LspString(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "newName" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(RenameParams(element))
        else Error()

/// Registration options for a {@link RenameRequest}.
[<Struct>]
type RenameRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document selector to identify the scope of the registration. If set to null
    /// the document selector provided on the client side will be used.
    member _.DocumentSelector =
        // Requires specialization: "or"

        let prop = element.GetProperty("documentSelector")
        prop

    /// Renames should be checked and tested before being executed.
    /// 
    /// @since version 3.12.0
    member _.PrepareProvider =
        match element.TryGetProperty("prepareProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(RenameRegistrationOptions(element))

[<Struct>]
type PrepareRenameParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(PrepareRenameParams(element))
        else Error()

/// The parameters of a {@link ExecuteCommandRequest}.
[<Struct>]
type ExecuteCommandParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The identifier of the actual command handler.
    member _.Command =
        let prop = element.GetProperty("command")
        global.Amongonz.LspTypes.LspString(prop)

    /// Arguments that the command should be invoked with.
    member _.Arguments =
        // Requires specialization: "array"

        match element.TryGetProperty("arguments") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ExecuteCommandParams(element))

/// Registration options for a {@link ExecuteCommandRequest}.
[<Struct>]
type ExecuteCommandRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The commands to be executed on the server
    member _.Commands =
        // Requires specialization: "array"

        let prop = element.GetProperty("commands")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ExecuteCommandRegistrationOptions(element))

/// The parameters passed via an apply workspace edit request.
[<Struct>]
type ApplyWorkspaceEditParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An optional label of the workspace edit. This label is
    /// presented in the user interface for example on an undo
    /// stack to undo the workspace edit.
    member _.Label =
        match element.TryGetProperty("label") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The edits to apply.
    member _.Edit =
        let prop = element.GetProperty("edit")
        WorkspaceEdit(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "label" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "edit" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (WorkspaceEdit.Parse(prop)))
            end
        then Ok(ApplyWorkspaceEditParams(element))
        else Error()

/// The result returned from the apply workspace edit request.
/// 
/// @since 3.17 renamed from ApplyWorkspaceEditResponse
[<Struct>]
type ApplyWorkspaceEditResult(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Indicates whether the edit was applied or not.
    member _.Applied =
        let prop = element.GetProperty("applied")
        prop.GetBoolean()

    /// An optional textual description for why the edit was not applied.
    /// This may be used by the server for diagnostic logging or to provide
    /// a suitable error for a request that triggered the edit.
    member _.FailureReason =
        match element.TryGetProperty("failureReason") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// Depending on the client&apos;s failure handling strategy `failedChange` might
    /// contain the index of the change that failed. This property is only available
    /// if the client signals a `failureHandlingStrategy` in its client capabilities.
    member _.FailedChange =
        match element.TryGetProperty("failedChange") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "applied" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "failureReason" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "failedChange" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
        then Ok(ApplyWorkspaceEditResult(element))
        else Error()

[<Struct>]
type WorkDoneProgressBegin(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// Mandatory title of the progress operation. Used to briefly inform about
    /// the kind of operation being performed.
    /// 
    /// Examples: &quot;Indexing&quot; or &quot;Linking dependencies&quot;.
    member _.Title =
        let prop = element.GetProperty("title")
        global.Amongonz.LspTypes.LspString(prop)

    /// Controls if a cancel button should show to allow the user to cancel the
    /// long running operation. Clients that don&apos;t support cancellation are allowed
    /// to ignore the setting.
    member _.Cancellable =
        match element.TryGetProperty("cancellable") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Optional, more detailed associated progress message. Contains
    /// complementary information to the `title`.
    /// 
    /// Examples: &quot;3/25 files&quot;, &quot;project/src/module2&quot;, &quot;node_modules/some_dep&quot;.
    /// If unset, the previous progress message (if any) is still valid.
    member _.Message =
        match element.TryGetProperty("message") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// Optional progress percentage to display (value 100 is considered 100%).
    /// If not provided infinite progress is assumed and clients are allowed
    /// to ignore the `percentage` value in subsequent in report notifications.
    /// 
    /// The value should be steadily rising. Clients are free to ignore values
    /// that are not following this rule. The value range is [0, 100].
    member _.Percentage =
        match element.TryGetProperty("percentage") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkDoneProgressBegin(element))

[<Struct>]
type WorkDoneProgressReport(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// Controls enablement state of a cancel button.
    /// 
    /// Clients that don&apos;t support cancellation or don&apos;t support controlling the button&apos;s
    /// enablement state are allowed to ignore the property.
    member _.Cancellable =
        match element.TryGetProperty("cancellable") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Optional, more detailed associated progress message. Contains
    /// complementary information to the `title`.
    /// 
    /// Examples: &quot;3/25 files&quot;, &quot;project/src/module2&quot;, &quot;node_modules/some_dep&quot;.
    /// If unset, the previous progress message (if any) is still valid.
    member _.Message =
        match element.TryGetProperty("message") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// Optional progress percentage to display (value 100 is considered 100%).
    /// If not provided infinite progress is assumed and clients are allowed
    /// to ignore the `percentage` value in subsequent in report notifications.
    /// 
    /// The value should be steadily rising. Clients are free to ignore values
    /// that are not following this rule. The value range is [0, 100]
    member _.Percentage =
        match element.TryGetProperty("percentage") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkDoneProgressReport(element))

[<Struct>]
type WorkDoneProgressEnd(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// Optional, a final message indicating to for example indicate the outcome
    /// of the operation.
    member _.Message =
        match element.TryGetProperty("message") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkDoneProgressEnd(element))

[<Struct>]
type SetTraceParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Value =
        let prop = element.GetProperty("value")
        TraceValues(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "value" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TraceValues.Parse(prop)))
            end
        then Ok(SetTraceParams(element))
        else Error()

[<Struct>]
type LogTraceParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.Message =
        let prop = element.GetProperty("message")
        global.Amongonz.LspTypes.LspString(prop)

    member _.Verbose =
        match element.TryGetProperty("verbose") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "message" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "verbose" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(LogTraceParams(element))
        else Error()

[<Struct>]
type CancelParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The request id to cancel.
    member _.Id =
        // Requires specialization: "or"

        let prop = element.GetProperty("id")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CancelParams(element))

[<Struct>]
type ProgressParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The progress token provided by the client or server.
    member _.Token =
        let prop = element.GetProperty("token")
        ProgressToken(prop)

    /// The progress data.
    member _.Value =
        let prop = element.GetProperty("value")
        LSPAny(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "token" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "value" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (LSPAny.Parse(prop)))
            end
        then Ok(ProgressParams(element))
        else Error()

/// A parameter literal used in requests to pass a text document and a position inside that
/// document.
[<Struct>]
type TextDocumentPositionParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        TextDocumentIdentifier(prop)

    /// The position inside the text document.
    member _.Position =
        let prop = element.GetProperty("position")
        Position(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentIdentifier.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "position" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
        then Ok(TextDocumentPositionParams(element))
        else Error()

[<Struct>]
type WorkDoneProgressParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(WorkDoneProgressParams(element))
        else Error()

[<Struct>]
type PartialResultParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An optional token that a server can use to report partial results (e.g. streaming) to
    /// the client.
    member _.PartialResultToken =
        match element.TryGetProperty("partialResultToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "partialResultToken" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ProgressToken.Parse(prop)))
            end
        then Ok(PartialResultParams(element))
        else Error()

/// Represents the connection of two locations. Provides additional metadata over normal {@link Location locations},
/// including an origin range.
[<Struct>]
type LocationLink(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Span of the origin of this link.
    /// 
    /// Used as the underlined span for mouse interaction. Defaults to the word range at
    /// the definition position.
    member _.OriginSelectionRange =
        match element.TryGetProperty("originSelectionRange") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Range(prop))

    /// The target resource identifier of this link.
    member _.TargetUri =
        let prop = element.GetProperty("targetUri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The full target range of this link. If the target for example is a symbol then target range is the
    /// range enclosing this symbol not including leading/trailing whitespace but everything else
    /// like comments. This information is typically used to highlight the range in the editor.
    member _.TargetRange =
        let prop = element.GetProperty("targetRange")
        Range(prop)

    /// The range that should be selected and revealed when this link is being followed, e.g the name of a function.
    /// Must be contained by the `targetRange`. See also `DocumentSymbol#range`
    member _.TargetSelectionRange =
        let prop = element.GetProperty("targetSelectionRange")
        Range(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "originSelectionRange" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "targetUri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "targetRange" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "targetSelectionRange" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
        then Ok(LocationLink(element))
        else Error()

/// A range in a text document expressed as (zero-based) start and end positions.
/// 
/// If you want to specify a range that contains a line including the line ending
/// character(s) then use an end position denoting the start of the next line.
/// For example:
/// ```ts
/// {
///     start: { line: 5, character: 23 }
///     end : { line 6, character : 0 }
/// }
/// ```
[<Struct>]
type Range(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The range&apos;s start position.
    member _.Start =
        let prop = element.GetProperty("start")
        Position(prop)

    /// The range&apos;s end position.
    member _.End =
        let prop = element.GetProperty("end")
        Position(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "start" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "end" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Position.Parse(prop)))
            end
        then Ok(Range(element))
        else Error()

[<Struct>]
type ImplementationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ImplementationOptions(element))
        else Error()

/// Static registration options to be returned in the initialize
/// request.
[<Struct>]
type StaticRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "id" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(StaticRegistrationOptions(element))
        else Error()

[<Struct>]
type TypeDefinitionOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(TypeDefinitionOptions(element))
        else Error()

/// The workspace folder change event.
[<Struct>]
type WorkspaceFoldersChangeEvent(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The array of added workspace folders
    member _.Added =
        // Requires specialization: "array"

        let prop = element.GetProperty("added")
        prop

    /// The array of the removed workspace folders
    member _.Removed =
        // Requires specialization: "array"

        let prop = element.GetProperty("removed")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceFoldersChangeEvent(element))

[<Struct>]
type ConfigurationItem(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The scope to get the configuration section for.
    member _.ScopeUri =
        match element.TryGetProperty("scopeUri") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.System.Uri(prop.GetString()))

    /// The configuration section asked for.
    member _.Section =
        match element.TryGetProperty("section") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "scopeUri" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "section" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(ConfigurationItem(element))
        else Error()

/// A literal to identify a text document in the client.
[<Struct>]
type TextDocumentIdentifier(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document&apos;s uri.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
        then Ok(TextDocumentIdentifier(element))
        else Error()

/// Represents a color in RGBA space.
[<Struct>]
type Color(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The red component of this color in the range [0-1].
    member _.Red =
        let prop = element.GetProperty("red")
        prop.GetDouble()

    /// The green component of this color in the range [0-1].
    member _.Green =
        let prop = element.GetProperty("green")
        prop.GetDouble()

    /// The blue component of this color in the range [0-1].
    member _.Blue =
        let prop = element.GetProperty("blue")
        prop.GetDouble()

    /// The alpha component of this color in the range [0-1].
    member _.Alpha =
        let prop = element.GetProperty("alpha")
        prop.GetDouble()

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "red" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidDecimal prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "green" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidDecimal prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "blue" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidDecimal prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "alpha" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidDecimal prop)
            end
        then Ok(Color(element))
        else Error()

[<Struct>]
type DocumentColorOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentColorOptions(element))
        else Error()

[<Struct>]
type FoldingRangeOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(FoldingRangeOptions(element))
        else Error()

[<Struct>]
type DeclarationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DeclarationOptions(element))
        else Error()

/// Position in a text document expressed as zero-based line and character
/// offset. Prior to 3.17 the offsets were always based on a UTF-16 string
/// representation. So a string of the form `a𐐀b` the character offset of the
/// character `a` is 0, the character offset of `𐐀` is 1 and the character
/// offset of b is 3 since `𐐀` is represented using two code units in UTF-16.
/// Since 3.17 clients and servers can agree on a different string encoding
/// representation (e.g. UTF-8). The client announces it&apos;s supported encoding
/// via the client capability [`general.positionEncodings`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/#clientCapabilities).
/// The value is an array of position encodings the client supports, with
/// decreasing preference (e.g. the encoding at index `0` is the most preferred
/// one). To stay backwards compatible the only mandatory encoding is UTF-16
/// represented via the string `utf-16`. The server can pick one of the
/// encodings offered by the client and signals that encoding back to the
/// client via the initialize result&apos;s property
/// [`capabilities.positionEncoding`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/#serverCapabilities). If the string value
/// `utf-16` is missing from the client&apos;s capability `general.positionEncodings`
/// servers can safely assume that the client supports UTF-16. If the server
/// omits the position encoding in its initialize result the encoding defaults
/// to the string value `utf-16`. Implementation considerations: since the
/// conversion from one encoding into another requires the content of the
/// file / line the conversion is best done where the file is read which is
/// usually on the server side.
/// 
/// Positions are line end character agnostic. So you can not specify a position
/// that denotes `\r|\n` or `\n|` where `|` represents the character offset.
/// 
/// @since 3.17.0 - support for negotiated position encoding.
[<Struct>]
type Position(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Line position in a document (zero-based).
    /// 
    /// If a line number is greater than the number of lines in a document, it defaults back to the number of lines in the document.
    /// If a line number is negative, it defaults to 0.
    member _.Line =
        let prop = element.GetProperty("line")
        prop.GetInt32()

    /// Character offset on a line in a document (zero-based).
    /// 
    /// The meaning of this offset is determined by the negotiated
    /// `PositionEncodingKind`.
    /// 
    /// If the character value is greater than the line length it defaults back to the
    /// line length.
    member _.Character =
        let prop = element.GetProperty("character")
        prop.GetInt32()

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "line" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "character" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
        then Ok(Position(element))
        else Error()

[<Struct>]
type SelectionRangeOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(SelectionRangeOptions(element))
        else Error()

/// Call hierarchy options used during static registration.
/// 
/// @since 3.16.0
[<Struct>]
type CallHierarchyOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(CallHierarchyOptions(element))
        else Error()

/// @since 3.16.0
[<Struct>]
type SemanticTokensOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The legend used by the server
    member _.Legend =
        let prop = element.GetProperty("legend")
        SemanticTokensLegend(prop)

    /// Server supports providing semantic tokens for a specific range
    /// of a document.
    member _.Range =
        // Requires specialization: "or"

        match element.TryGetProperty("range") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Server supports providing semantic tokens for a full document.
    member _.Full =
        // Requires specialization: "or"

        match element.TryGetProperty("full") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokensOptions(element))

/// @since 3.16.0
[<Struct>]
type SemanticTokensEdit(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The start offset of the edit.
    member _.Start =
        let prop = element.GetProperty("start")
        prop.GetInt32()

    /// The count of elements to remove.
    member _.DeleteCount =
        let prop = element.GetProperty("deleteCount")
        prop.GetInt32()

    /// The elements to insert.
    member _.Data =
        // Requires specialization: "array"

        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokensEdit(element))

[<Struct>]
type LinkedEditingRangeOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(LinkedEditingRangeOptions(element))
        else Error()

/// Represents information on a file/folder create.
/// 
/// @since 3.16.0
[<Struct>]
type FileCreate(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A file:// URI for the location of the file/folder being created.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(FileCreate(element))
        else Error()

/// Describes textual changes on a text document. A TextDocumentEdit describes all changes
/// on a document version Si and after they are applied move the document to version Si+1.
/// So the creator of a TextDocumentEdit doesn&apos;t need to sort the array of edits or do any
/// kind of ordering. However the edits must be non overlapping.
[<Struct>]
type TextDocumentEdit(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document to change.
    member _.TextDocument =
        let prop = element.GetProperty("textDocument")
        OptionalVersionedTextDocumentIdentifier(prop)

    /// The edits to be applied.
    /// 
    /// @since 3.16.0 - support for AnnotatedTextEdit. This is guarded using a
    /// client capability.
    member _.Edits =
        // Requires specialization: "array"

        let prop = element.GetProperty("edits")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(TextDocumentEdit(element))

/// Create file operation.
[<Struct>]
type CreateFile(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A create
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// The resource to create.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// Additional options
    member _.Options =
        match element.TryGetProperty("options") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CreateFileOptions(prop))

    /// An optional annotation identifier describing the operation.
    /// 
    /// @since 3.16.0
    member _.AnnotationId =
        match element.TryGetProperty("annotationId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome((global.Amongonz.LspTypes.LspString(prop): ChangeAnnotationIdentifier))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CreateFile(element))

/// Rename file operation
[<Struct>]
type RenameFile(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A rename
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// The old (existing) location.
    member _.OldUri =
        let prop = element.GetProperty("oldUri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The new location.
    member _.NewUri =
        let prop = element.GetProperty("newUri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// Rename options.
    member _.Options =
        match element.TryGetProperty("options") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(RenameFileOptions(prop))

    /// An optional annotation identifier describing the operation.
    /// 
    /// @since 3.16.0
    member _.AnnotationId =
        match element.TryGetProperty("annotationId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome((global.Amongonz.LspTypes.LspString(prop): ChangeAnnotationIdentifier))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(RenameFile(element))

/// Delete file operation
[<Struct>]
type DeleteFile(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A delete
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// The file to delete.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// Delete options.
    member _.Options =
        match element.TryGetProperty("options") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DeleteFileOptions(prop))

    /// An optional annotation identifier describing the operation.
    /// 
    /// @since 3.16.0
    member _.AnnotationId =
        match element.TryGetProperty("annotationId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome((global.Amongonz.LspTypes.LspString(prop): ChangeAnnotationIdentifier))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DeleteFile(element))

/// Additional information that describes document changes.
/// 
/// @since 3.16.0
[<Struct>]
type ChangeAnnotation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A human-readable string describing the actual change. The string
    /// is rendered prominent in the user interface.
    member _.Label =
        let prop = element.GetProperty("label")
        global.Amongonz.LspTypes.LspString(prop)

    /// A flag which indicates that user confirmation is needed
    /// before applying the change.
    member _.NeedsConfirmation =
        match element.TryGetProperty("needsConfirmation") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// A human-readable string which is rendered less prominent in
    /// the user interface.
    member _.Description =
        match element.TryGetProperty("description") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "label" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "needsConfirmation" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "description" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(ChangeAnnotation(element))
        else Error()

/// A filter to describe in which file operation requests or notifications
/// the server is interested in receiving.
/// 
/// @since 3.16.0
[<Struct>]
type FileOperationFilter(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A Uri scheme like `file` or `untitled`.
    member _.Scheme =
        match element.TryGetProperty("scheme") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The actual file operation pattern.
    member _.Pattern =
        let prop = element.GetProperty("pattern")
        FileOperationPattern(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "scheme" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "pattern" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (FileOperationPattern.Parse(prop)))
            end
        then Ok(FileOperationFilter(element))
        else Error()

/// Represents information on a file/folder rename.
/// 
/// @since 3.16.0
[<Struct>]
type FileRename(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A file:// URI for the original location of the file/folder being renamed.
    member _.OldUri =
        let prop = element.GetProperty("oldUri")
        global.Amongonz.LspTypes.LspString(prop)

    /// A file:// URI for the new location of the file/folder being renamed.
    member _.NewUri =
        let prop = element.GetProperty("newUri")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "oldUri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "newUri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(FileRename(element))
        else Error()

/// Represents information on a file/folder delete.
/// 
/// @since 3.16.0
[<Struct>]
type FileDelete(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A file:// URI for the location of the file/folder being deleted.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(FileDelete(element))
        else Error()

[<Struct>]
type MonikerOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(MonikerOptions(element))
        else Error()

/// Type hierarchy options used during static registration.
/// 
/// @since 3.17.0
[<Struct>]
type TypeHierarchyOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(TypeHierarchyOptions(element))
        else Error()

/// @since 3.17.0
[<Struct>]
type InlineValueContext(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The stack frame (as a DAP Id) where the execution has stopped.
    member _.FrameId =
        let prop = element.GetProperty("frameId")
        prop.GetInt32()

    /// The document range where execution has stopped.
    /// Typically the end position of the range denotes the line where the inline values are shown.
    member _.StoppedLocation =
        let prop = element.GetProperty("stoppedLocation")
        Range(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "frameId" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "stoppedLocation" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
        then Ok(InlineValueContext(element))
        else Error()

/// Provide inline value as text.
/// 
/// @since 3.17.0
[<Struct>]
type InlineValueText(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document range for which the inline value applies.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The text of the inline value.
    member _.Text =
        let prop = element.GetProperty("text")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "text" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(InlineValueText(element))
        else Error()

/// Provide inline value through a variable lookup.
/// If only a range is specified, the variable name will be extracted from the underlying document.
/// An optional variable name can be used to override the extracted name.
/// 
/// @since 3.17.0
[<Struct>]
type InlineValueVariableLookup(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document range for which the inline value applies.
    /// The range is used to extract the variable name from the underlying document.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// If specified the name of the variable to look up.
    member _.VariableName =
        match element.TryGetProperty("variableName") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// How to perform the lookup.
    member _.CaseSensitiveLookup =
        let prop = element.GetProperty("caseSensitiveLookup")
        prop.GetBoolean()

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "variableName" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "caseSensitiveLookup" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InlineValueVariableLookup(element))
        else Error()

/// Provide an inline value through an expression evaluation.
/// If only a range is specified, the expression will be extracted from the underlying document.
/// An optional expression can be used to override the extracted expression.
/// 
/// @since 3.17.0
[<Struct>]
type InlineValueEvaluatableExpression(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The document range for which the inline value applies.
    /// The range is used to extract the evaluatable expression from the underlying document.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// If specified the expression overrides the extracted expression.
    member _.Expression =
        match element.TryGetProperty("expression") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "expression" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(InlineValueEvaluatableExpression(element))
        else Error()

/// Inline value options used during static registration.
/// 
/// @since 3.17.0
[<Struct>]
type InlineValueOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InlineValueOptions(element))
        else Error()

/// An inlay hint label part allows for interactive and composite labels
/// of inlay hints.
/// 
/// @since 3.17.0
[<Struct>]
type InlayHintLabelPart(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The value of this label part.
    member _.Value =
        let prop = element.GetProperty("value")
        global.Amongonz.LspTypes.LspString(prop)

    /// The tooltip text when you hover over this label part. Depending on
    /// the client capability `inlayHint.resolveSupport` clients might resolve
    /// this property late using the resolve request.
    member _.Tooltip =
        // Requires specialization: "or"

        match element.TryGetProperty("tooltip") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// An optional source code location that represents this
    /// label part.
    /// 
    /// The editor will use this location for the hover and for code navigation
    /// features: This part will become a clickable link that resolves to the
    /// definition of the symbol at the given location (not necessarily the
    /// location itself), it shows the hover that shows at the given location,
    /// and it shows a context menu with further code navigation commands.
    /// 
    /// Depending on the client capability `inlayHint.resolveSupport` clients
    /// might resolve this property late using the resolve request.
    member _.Location =
        match element.TryGetProperty("location") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Location(prop))

    /// An optional command for this label part.
    /// 
    /// Depending on the client capability `inlayHint.resolveSupport` clients
    /// might resolve this property late using the resolve request.
    member _.Command =
        match element.TryGetProperty("command") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(Command(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InlayHintLabelPart(element))

/// A `MarkupContent` literal represents a string value which content is interpreted base on its
/// kind flag. Currently the protocol supports `plaintext` and `markdown` as markup kinds.
/// 
/// If the kind is `markdown` then the value can contain fenced code blocks like in GitHub issues.
/// See https://help.github.com/articles/creating-and-highlighting-code-blocks/#syntax-highlighting
/// 
/// Here is an example how such a string can be constructed using JavaScript / TypeScript:
/// ```ts
/// let markdown: MarkdownContent = {
///  kind: MarkupKind.Markdown,
///  value: [
///    &apos;# Header&apos;,
///    &apos;Some text&apos;,
///    &apos;```typescript&apos;,
///    &apos;someCode();&apos;,
///    &apos;```&apos;
///  ].join(&apos;\n&apos;)
/// };
/// ```
/// 
/// *Please Note* that clients might sanitize the return markdown. A client could decide to
/// remove HTML from the markdown to avoid script execution.
[<Struct>]
type MarkupContent(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The type of the Markup
    member _.Kind =
        let prop = element.GetProperty("kind")
        MarkupKind(prop)

    /// The content itself
    member _.Value =
        let prop = element.GetProperty("value")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "kind" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (MarkupKind.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "value" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(MarkupContent(element))
        else Error()

/// Inlay hint options used during static registration.
/// 
/// @since 3.17.0
[<Struct>]
type InlayHintOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The server provides support to resolve additional
    /// information for an inlay hint item.
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "resolveProvider" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InlayHintOptions(element))
        else Error()

/// A full diagnostic report with a set of related documents.
/// 
/// @since 3.17.0
[<Struct>]
type RelatedFullDocumentDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Diagnostics of related documents. This information is useful
    /// in programming languages where code in a file A can generate
    /// diagnostics in a file B which A depends on. An example of
    /// such a language is C/C++ where marco definitions in a file
    /// a.cpp and result in errors in a header file b.hpp.
    /// 
    /// @since 3.17.0
    member _.RelatedDocuments =
        // Requires specialization: "map"

        match element.TryGetProperty("relatedDocuments") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// A full document diagnostic report.
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// An optional result id. If provided it will
    /// be sent on the next diagnostic request for the
    /// same document.
    member _.ResultId =
        match element.TryGetProperty("resultId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The actual items.
    member _.Items =
        // Requires specialization: "array"

        let prop = element.GetProperty("items")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(RelatedFullDocumentDiagnosticReport(element))

/// An unchanged diagnostic report with a set of related documents.
/// 
/// @since 3.17.0
[<Struct>]
type RelatedUnchangedDocumentDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Diagnostics of related documents. This information is useful
    /// in programming languages where code in a file A can generate
    /// diagnostics in a file B which A depends on. An example of
    /// such a language is C/C++ where marco definitions in a file
    /// a.cpp and result in errors in a header file b.hpp.
    /// 
    /// @since 3.17.0
    member _.RelatedDocuments =
        // Requires specialization: "map"

        match element.TryGetProperty("relatedDocuments") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// A document diagnostic report indicating
    /// no changes to the last result. A server can
    /// only return `unchanged` if result ids are
    /// provided.
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// A result id which will be sent on the next
    /// diagnostic request for the same document.
    member _.ResultId =
        let prop = element.GetProperty("resultId")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(RelatedUnchangedDocumentDiagnosticReport(element))

/// A diagnostic report with a full set of problems.
/// 
/// @since 3.17.0
[<Struct>]
type FullDocumentDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A full document diagnostic report.
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// An optional result id. If provided it will
    /// be sent on the next diagnostic request for the
    /// same document.
    member _.ResultId =
        match element.TryGetProperty("resultId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The actual items.
    member _.Items =
        // Requires specialization: "array"

        let prop = element.GetProperty("items")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(FullDocumentDiagnosticReport(element))

/// A diagnostic report indicating that the last returned
/// report is still accurate.
/// 
/// @since 3.17.0
[<Struct>]
type UnchangedDocumentDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A document diagnostic report indicating
    /// no changes to the last result. A server can
    /// only return `unchanged` if result ids are
    /// provided.
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// A result id which will be sent on the next
    /// diagnostic request for the same document.
    member _.ResultId =
        let prop = element.GetProperty("resultId")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(UnchangedDocumentDiagnosticReport(element))

/// Diagnostic options.
/// 
/// @since 3.17.0
[<Struct>]
type DiagnosticOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An optional identifier under which the diagnostics are
    /// managed by the client.
    member _.Identifier =
        match element.TryGetProperty("identifier") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// Whether the language has inter file dependencies meaning that
    /// editing code in one file can result in a different diagnostic
    /// set in another file. Inter file dependencies are common for
    /// most programming languages and typically uncommon for linters.
    member _.InterFileDependencies =
        let prop = element.GetProperty("interFileDependencies")
        prop.GetBoolean()

    /// The server provides support for workspace diagnostics as well.
    member _.WorkspaceDiagnostics =
        let prop = element.GetProperty("workspaceDiagnostics")
        prop.GetBoolean()

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "identifier" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "interFileDependencies" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workspaceDiagnostics" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DiagnosticOptions(element))
        else Error()

/// A previous result id in a workspace pull request.
/// 
/// @since 3.17.0
[<Struct>]
type PreviousResultId(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The URI for which the client knowns a
    /// result id.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The value of the previous result id.
    member _.Value =
        let prop = element.GetProperty("value")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "value" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(PreviousResultId(element))
        else Error()

/// A notebook document.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookDocument(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The notebook document&apos;s uri.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.System.Uri(prop.GetString())

    /// The type of the notebook.
    member _.NotebookType =
        let prop = element.GetProperty("notebookType")
        global.Amongonz.LspTypes.LspString(prop)

    /// The version number of this document (it will increase after each
    /// change, including undo/redo).
    member _.Version =
        let prop = element.GetProperty("version")
        prop.GetInt32()

    /// Additional metadata stored with the notebook
    /// document.
    /// 
    /// Note: should always be an object literal (e.g. LSPObject)
    member _.Metadata =
        match element.TryGetProperty("metadata") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPObject(prop))

    /// The cells of a notebook.
    member _.Cells =
        // Requires specialization: "array"

        let prop = element.GetProperty("cells")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(NotebookDocument(element))

/// An item to transfer a text document from the client to the
/// server.
[<Struct>]
type TextDocumentItem(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The text document&apos;s uri.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The text document&apos;s language identifier.
    member _.LanguageId =
        let prop = element.GetProperty("languageId")
        global.Amongonz.LspTypes.LspString(prop)

    /// The version number of this document (it will increase after each
    /// change, including undo/redo).
    member _.Version =
        let prop = element.GetProperty("version")
        prop.GetInt32()

    /// The content of the opened text document.
    member _.Text =
        let prop = element.GetProperty("text")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "languageId" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "version" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "text" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(TextDocumentItem(element))
        else Error()

/// A versioned notebook document identifier.
/// 
/// @since 3.17.0
[<Struct>]
type VersionedNotebookDocumentIdentifier(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The version number of this notebook document.
    member _.Version =
        let prop = element.GetProperty("version")
        prop.GetInt32()

    /// The notebook document&apos;s uri.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.System.Uri(prop.GetString())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "version" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
        then Ok(VersionedNotebookDocumentIdentifier(element))
        else Error()

/// A change event for a notebook document.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookDocumentChangeEvent(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The changed meta data if any.
    /// 
    /// Note: should always be an object literal (e.g. LSPObject)
    member _.Metadata =
        match element.TryGetProperty("metadata") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPObject(prop))

    /// Changes to cells
    member _.Cells =
        // Requires specialization: "literal"

        match element.TryGetProperty("cells") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(NotebookDocumentChangeEvent(element))

/// A literal to identify a notebook document in the client.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookDocumentIdentifier(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The notebook document&apos;s uri.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.System.Uri(prop.GetString())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
        then Ok(NotebookDocumentIdentifier(element))
        else Error()

/// Provides information about the context in which an inline completion was requested.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type InlineCompletionContext(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Describes how the inline completion was triggered.
    member _.TriggerKind =
        let prop = element.GetProperty("triggerKind")
        enum<InlineCompletionTriggerKind>(prop.GetInt32())

    /// Provides information about the currently selected item in the autocomplete widget if it is visible.
    member _.SelectedCompletionInfo =
        match element.TryGetProperty("selectedCompletionInfo") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SelectedCompletionInfo(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "triggerKind" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> true)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "selectedCompletionInfo" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (SelectedCompletionInfo.Parse(prop)))
            end
        then Ok(InlineCompletionContext(element))
        else Error()

/// A string value used as a snippet is a template which allows to insert text
/// and to control the editor cursor when insertion happens.
/// 
/// A snippet can define tab stops and placeholders with `$1`, `$2`
/// and `${3:foo}`. `$0` defines the final tab stop, it defaults to
/// the end of the snippet. Variables are defined with `$name` and
/// `${name:default value}`.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type StringValue(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The kind of string value.
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// The snippet string.
    member _.Value =
        let prop = element.GetProperty("value")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(StringValue(element))

/// Inline completion options used during static registration.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type InlineCompletionOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InlineCompletionOptions(element))
        else Error()

/// General parameters to register for a notification or to register a provider.
[<Struct>]
type Registration(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The id used to register the request. The id can be used to deregister
    /// the request again.
    member _.Id =
        let prop = element.GetProperty("id")
        global.Amongonz.LspTypes.LspString(prop)

    /// The method / capability to register for.
    member _.Method =
        let prop = element.GetProperty("method")
        global.Amongonz.LspTypes.LspString(prop)

    /// Options necessary for the registration.
    member _.RegisterOptions =
        match element.TryGetProperty("registerOptions") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "id" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "method" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "registerOptions" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (LSPAny.Parse(prop)))
            end
        then Ok(Registration(element))
        else Error()

/// General parameters to unregister a request or notification.
[<Struct>]
type Unregistration(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The id used to unregister the request or notification. Usually an id
    /// provided during the register request.
    member _.Id =
        let prop = element.GetProperty("id")
        global.Amongonz.LspTypes.LspString(prop)

    /// The method to unregister for.
    member _.Method =
        let prop = element.GetProperty("method")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "id" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "method" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(Unregistration(element))
        else Error()

/// The initialize parameters
[<Struct>]
type _InitializeParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The process Id of the parent process that started
    /// the server.
    /// 
    /// Is `null` if the process has not been started by another process.
    /// If the parent process is not alive then the server should exit.
    member _.ProcessId =
        // Requires specialization: "or"

        let prop = element.GetProperty("processId")
        prop

    /// Information about the client
    /// 
    /// @since 3.15.0
    member _.ClientInfo =
        // Requires specialization: "literal"

        match element.TryGetProperty("clientInfo") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The locale the client is currently showing the user interface
    /// in. This must not necessarily be the locale of the operating
    /// system.
    /// 
    /// Uses IETF language tags as the value&apos;s syntax
    /// (See https://en.wikipedia.org/wiki/IETF_language_tag)
    /// 
    /// @since 3.16.0
    member _.Locale =
        match element.TryGetProperty("locale") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The rootPath of the workspace. Is null
    /// if no folder is open.
    /// 
    /// @deprecated in favour of rootUri.
    member _.RootPath =
        // Requires specialization: "or"

        match element.TryGetProperty("rootPath") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The rootUri of the workspace. Is null if no
    /// folder is open. If both `rootPath` and `rootUri` are set
    /// `rootUri` wins.
    /// 
    /// @deprecated in favour of workspaceFolders.
    member _.RootUri =
        // Requires specialization: "or"

        let prop = element.GetProperty("rootUri")
        prop

    /// The capabilities provided by the client (editor or tool)
    member _.Capabilities =
        let prop = element.GetProperty("capabilities")
        ClientCapabilities(prop)

    /// User provided initialization options.
    member _.InitializationOptions =
        match element.TryGetProperty("initializationOptions") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    /// The initial trace setting. If omitted trace is disabled (&apos;off&apos;).
    member _.Trace =
        match element.TryGetProperty("trace") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(TraceValues(prop))

    /// An optional token that a server can use to report work done progress.
    member _.WorkDoneToken =
        match element.TryGetProperty("workDoneToken") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ProgressToken(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(_InitializeParams(element))

[<Struct>]
type WorkspaceFoldersInitializeParams(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The workspace folders configured in the client when the server starts.
    /// 
    /// This property is only available if the client supports workspace folders.
    /// It can be `null` if the client supports workspace folders but none are
    /// configured.
    /// 
    /// @since 3.6.0
    member _.WorkspaceFolders =
        // Requires specialization: "or"

        match element.TryGetProperty("workspaceFolders") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceFoldersInitializeParams(element))

/// Defines the capabilities provided by a language
/// server.
[<Struct>]
type ServerCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The position encoding the server picked from the encodings offered
    /// by the client via the client capability `general.positionEncodings`.
    /// 
    /// If the client didn&apos;t provide any position encodings the only valid
    /// value that a server can return is &apos;utf-16&apos;.
    /// 
    /// If omitted it defaults to &apos;utf-16&apos;.
    /// 
    /// @since 3.17.0
    member _.PositionEncoding =
        match element.TryGetProperty("positionEncoding") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(PositionEncodingKind(prop))

    /// Defines how text documents are synced. Is either a detailed structure
    /// defining each notification or for backwards compatibility the
    /// TextDocumentSyncKind number.
    member _.TextDocumentSync =
        // Requires specialization: "or"

        match element.TryGetProperty("textDocumentSync") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Defines how notebook documents are synced.
    /// 
    /// @since 3.17.0
    member _.NotebookDocumentSync =
        // Requires specialization: "or"

        match element.TryGetProperty("notebookDocumentSync") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides completion support.
    member _.CompletionProvider =
        match element.TryGetProperty("completionProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CompletionOptions(prop))

    /// The server provides hover support.
    member _.HoverProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("hoverProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides signature help support.
    member _.SignatureHelpProvider =
        match element.TryGetProperty("signatureHelpProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SignatureHelpOptions(prop))

    /// The server provides Goto Declaration support.
    member _.DeclarationProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("declarationProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides goto definition support.
    member _.DefinitionProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("definitionProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides Goto Type Definition support.
    member _.TypeDefinitionProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("typeDefinitionProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides Goto Implementation support.
    member _.ImplementationProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("implementationProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides find references support.
    member _.ReferencesProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("referencesProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides document highlight support.
    member _.DocumentHighlightProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("documentHighlightProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides document symbol support.
    member _.DocumentSymbolProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("documentSymbolProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides code actions. CodeActionOptions may only be
    /// specified if the client states that it supports
    /// `codeActionLiteralSupport` in its initial `initialize` request.
    member _.CodeActionProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("codeActionProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides code lens.
    member _.CodeLensProvider =
        match element.TryGetProperty("codeLensProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CodeLensOptions(prop))

    /// The server provides document link support.
    member _.DocumentLinkProvider =
        match element.TryGetProperty("documentLinkProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentLinkOptions(prop))

    /// The server provides color provider support.
    member _.ColorProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("colorProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides workspace symbol support.
    member _.WorkspaceSymbolProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("workspaceSymbolProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides document formatting.
    member _.DocumentFormattingProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("documentFormattingProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides document range formatting.
    member _.DocumentRangeFormattingProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("documentRangeFormattingProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides document formatting on typing.
    member _.DocumentOnTypeFormattingProvider =
        match element.TryGetProperty("documentOnTypeFormattingProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentOnTypeFormattingOptions(prop))

    /// The server provides rename support. RenameOptions may only be
    /// specified if the client states that it supports
    /// `prepareSupport` in its initial `initialize` request.
    member _.RenameProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("renameProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides folding provider support.
    member _.FoldingRangeProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("foldingRangeProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides selection range support.
    member _.SelectionRangeProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("selectionRangeProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides execute command support.
    member _.ExecuteCommandProvider =
        match element.TryGetProperty("executeCommandProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ExecuteCommandOptions(prop))

    /// The server provides call hierarchy support.
    /// 
    /// @since 3.16.0
    member _.CallHierarchyProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("callHierarchyProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides linked editing range support.
    /// 
    /// @since 3.16.0
    member _.LinkedEditingRangeProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("linkedEditingRangeProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides semantic tokens support.
    /// 
    /// @since 3.16.0
    member _.SemanticTokensProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("semanticTokensProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides moniker support.
    /// 
    /// @since 3.16.0
    member _.MonikerProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("monikerProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides type hierarchy support.
    /// 
    /// @since 3.17.0
    member _.TypeHierarchyProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("typeHierarchyProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides inline values.
    /// 
    /// @since 3.17.0
    member _.InlineValueProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("inlineValueProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides inlay hints.
    /// 
    /// @since 3.17.0
    member _.InlayHintProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("inlayHintProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server has support for pull model diagnostics.
    /// 
    /// @since 3.17.0
    member _.DiagnosticProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("diagnosticProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Inline completion options used during static registration.
    /// 
    /// @since 3.18.0
    /// @proposed
    member _.InlineCompletionProvider =
        // Requires specialization: "or"

        match element.TryGetProperty("inlineCompletionProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Workspace specific server capabilities.
    member _.Workspace =
        // Requires specialization: "literal"

        match element.TryGetProperty("workspace") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Experimental server capabilities.
    member _.Experimental =
        match element.TryGetProperty("experimental") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ServerCapabilities(element))

/// A text document identifier to denote a specific version of a text document.
[<Struct>]
type VersionedTextDocumentIdentifier(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The version number of this document.
    member _.Version =
        let prop = element.GetProperty("version")
        prop.GetInt32()

    /// The text document&apos;s uri.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "version" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
        then Ok(VersionedTextDocumentIdentifier(element))
        else Error()

/// Save options.
[<Struct>]
type SaveOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The client is supposed to include the content on save.
    member _.IncludeText =
        match element.TryGetProperty("includeText") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "includeText" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(SaveOptions(element))
        else Error()

/// An event describing a file change.
[<Struct>]
type FileEvent(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The file&apos;s uri.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The change type.
    member _.Type =
        let prop = element.GetProperty("type")
        enum<FileChangeType>(prop.GetInt32())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "uri" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "type" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> true)
            end
        then Ok(FileEvent(element))
        else Error()

[<Struct>]
type FileSystemWatcher(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The glob pattern to watch. See {@link GlobPattern glob pattern} for more detail.
    /// 
    /// @since 3.17.0 support for relative patterns.
    member _.GlobPattern =
        let prop = element.GetProperty("globPattern")
        GlobPattern(prop)

    /// The kind of events of interest. If omitted it defaults
    /// to WatchKind.Create | WatchKind.Change | WatchKind.Delete
    /// which is 7.
    member _.Kind =
        match element.TryGetProperty("kind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<WatchKind>(prop.GetInt32()))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "globPattern" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (GlobPattern.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "kind" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> true)
            end
        then Ok(FileSystemWatcher(element))
        else Error()

/// Represents a diagnostic, such as a compiler error or warning. Diagnostic objects
/// are only valid in the scope of a resource.
[<Struct>]
type Diagnostic(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The range at which the message applies
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The diagnostic&apos;s severity. Can be omitted. If omitted it is up to the
    /// client to interpret diagnostics as error, warning, info or hint.
    member _.Severity =
        match element.TryGetProperty("severity") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<DiagnosticSeverity>(prop.GetInt32()))

    /// The diagnostic&apos;s code, which usually appear in the user interface.
    member _.Code =
        // Requires specialization: "or"

        match element.TryGetProperty("code") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// An optional property to describe the error code.
    /// Requires the code field (above) to be present/not null.
    /// 
    /// @since 3.16.0
    member _.CodeDescription =
        match element.TryGetProperty("codeDescription") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CodeDescription(prop))

    /// A human-readable string describing the source of this
    /// diagnostic, e.g. &apos;typescript&apos; or &apos;super lint&apos;. It usually
    /// appears in the user interface.
    member _.Source =
        match element.TryGetProperty("source") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The diagnostic&apos;s message. It usually appears in the user interface
    member _.Message =
        let prop = element.GetProperty("message")
        global.Amongonz.LspTypes.LspString(prop)

    /// Additional metadata about the diagnostic.
    /// 
    /// @since 3.15.0
    member _.Tags =
        // Requires specialization: "array"

        match element.TryGetProperty("tags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// An array of related diagnostic information, e.g. when symbol-names within
    /// a scope collide all definitions can be marked via this property.
    member _.RelatedInformation =
        // Requires specialization: "array"

        match element.TryGetProperty("relatedInformation") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// A data entry field that is preserved between a `textDocument/publishDiagnostics`
    /// notification and `textDocument/codeAction` request.
    /// 
    /// @since 3.16.0
    member _.Data =
        match element.TryGetProperty("data") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(Diagnostic(element))

/// Contains additional information about the context in which a completion request is triggered.
[<Struct>]
type CompletionContext(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// How the completion was triggered.
    member _.TriggerKind =
        let prop = element.GetProperty("triggerKind")
        enum<CompletionTriggerKind>(prop.GetInt32())

    /// The trigger character (a single character) that has trigger code complete.
    /// Is undefined if `triggerKind !== CompletionTriggerKind.TriggerCharacter`
    member _.TriggerCharacter =
        match element.TryGetProperty("triggerCharacter") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "triggerKind" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> true)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "triggerCharacter" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(CompletionContext(element))
        else Error()

/// Additional details for a completion item label.
/// 
/// @since 3.17.0
[<Struct>]
type CompletionItemLabelDetails(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An optional string which is rendered less prominently directly after {@link CompletionItem.label label},
    /// without any spacing. Should be used for function signatures and type annotations.
    member _.Detail =
        match element.TryGetProperty("detail") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// An optional string which is rendered less prominently after {@link CompletionItem.detail}. Should be used
    /// for fully qualified names and file paths.
    member _.Description =
        match element.TryGetProperty("description") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "detail" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "description" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(CompletionItemLabelDetails(element))
        else Error()

/// A special text edit to provide an insert and a replace operation.
/// 
/// @since 3.16.0
[<Struct>]
type InsertReplaceEdit(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The string to be inserted.
    member _.NewText =
        let prop = element.GetProperty("newText")
        global.Amongonz.LspTypes.LspString(prop)

    /// The range if the insert is requested
    member _.Insert =
        let prop = element.GetProperty("insert")
        Range(prop)

    /// The range if the replace is requested.
    member _.Replace =
        let prop = element.GetProperty("replace")
        Range(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "newText" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "insert" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "replace" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
        then Ok(InsertReplaceEdit(element))
        else Error()

/// Completion options.
[<Struct>]
type CompletionOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Most tools trigger completion request automatically without explicitly requesting
    /// it using a keyboard shortcut (e.g. Ctrl+Space). Typically they do so when the user
    /// starts to type an identifier. For example if the user types `c` in a JavaScript file
    /// code complete will automatically pop up present `console` besides others as a
    /// completion item. Characters that make up identifiers don&apos;t need to be listed here.
    /// 
    /// If code complete should automatically be trigger on characters not being valid inside
    /// an identifier (for example `.` in JavaScript) list them in `triggerCharacters`.
    member _.TriggerCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("triggerCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The list of all possible characters that commit a completion. This field can be used
    /// if clients don&apos;t support individual commit characters per completion item. See
    /// `ClientCapabilities.textDocument.completion.completionItem.commitCharactersSupport`
    /// 
    /// If a server provides both `allCommitCharacters` and commit characters on an individual
    /// completion item the ones on the completion item win.
    /// 
    /// @since 3.2.0
    member _.AllCommitCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("allCommitCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides support to resolve additional
    /// information for a completion item.
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The server supports the following `CompletionItem` specific
    /// capabilities.
    /// 
    /// @since 3.17.0
    member _.CompletionItem =
        // Requires specialization: "literal"

        match element.TryGetProperty("completionItem") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CompletionOptions(element))

/// Hover options.
[<Struct>]
type HoverOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(HoverOptions(element))
        else Error()

/// Additional information about the context in which a signature help request was triggered.
/// 
/// @since 3.15.0
[<Struct>]
type SignatureHelpContext(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Action that caused signature help to be triggered.
    member _.TriggerKind =
        let prop = element.GetProperty("triggerKind")
        enum<SignatureHelpTriggerKind>(prop.GetInt32())

    /// Character that caused signature help to be triggered.
    /// 
    /// This is undefined when `triggerKind !== SignatureHelpTriggerKind.TriggerCharacter`
    member _.TriggerCharacter =
        match element.TryGetProperty("triggerCharacter") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// `true` if signature help was already showing when it was triggered.
    /// 
    /// Retriggers occurs when the signature help is already active and can be caused by actions such as
    /// typing a trigger character, a cursor move, or document content changes.
    member _.IsRetrigger =
        let prop = element.GetProperty("isRetrigger")
        prop.GetBoolean()

    /// The currently active `SignatureHelp`.
    /// 
    /// The `activeSignatureHelp` has its `SignatureHelp.activeSignature` field updated based on
    /// the user navigating through available signatures.
    member _.ActiveSignatureHelp =
        match element.TryGetProperty("activeSignatureHelp") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SignatureHelp(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "triggerKind" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> true)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "triggerCharacter" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "isRetrigger" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "activeSignatureHelp" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (SignatureHelp.Parse(prop)))
            end
        then Ok(SignatureHelpContext(element))
        else Error()

/// Represents the signature of something callable. A signature
/// can have a label, like a function-name, a doc-comment, and
/// a set of parameters.
[<Struct>]
type SignatureInformation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The label of this signature. Will be shown in
    /// the UI.
    member _.Label =
        let prop = element.GetProperty("label")
        global.Amongonz.LspTypes.LspString(prop)

    /// The human-readable doc-comment of this signature. Will be shown
    /// in the UI but can be omitted.
    member _.Documentation =
        // Requires specialization: "or"

        match element.TryGetProperty("documentation") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The parameters of this signature.
    member _.Parameters =
        // Requires specialization: "array"

        match element.TryGetProperty("parameters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The index of the active parameter.
    /// 
    /// If provided, this is used in place of `SignatureHelp.activeParameter`.
    /// 
    /// @since 3.16.0
    member _.ActiveParameter =
        match element.TryGetProperty("activeParameter") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SignatureInformation(element))

/// Server Capabilities for a {@link SignatureHelpRequest}.
[<Struct>]
type SignatureHelpOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// List of characters that trigger signature help automatically.
    member _.TriggerCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("triggerCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// List of characters that re-trigger signature help.
    /// 
    /// These trigger characters are only active when signature help is already showing. All trigger characters
    /// are also counted as re-trigger characters.
    /// 
    /// @since 3.15.0
    member _.RetriggerCharacters =
        // Requires specialization: "array"

        match element.TryGetProperty("retriggerCharacters") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SignatureHelpOptions(element))

/// Server Capabilities for a {@link DefinitionRequest}.
[<Struct>]
type DefinitionOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DefinitionOptions(element))
        else Error()

/// Value-object that contains additional information when
/// requesting references.
[<Struct>]
type ReferenceContext(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Include the declaration of the current symbol.
    member _.IncludeDeclaration =
        let prop = element.GetProperty("includeDeclaration")
        prop.GetBoolean()

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "includeDeclaration" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ReferenceContext(element))
        else Error()

/// Reference options.
[<Struct>]
type ReferenceOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ReferenceOptions(element))
        else Error()

/// Provider options for a {@link DocumentHighlightRequest}.
[<Struct>]
type DocumentHighlightOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentHighlightOptions(element))
        else Error()

/// A base for all symbol information.
[<Struct>]
type BaseSymbolInformation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The name of this symbol.
    member _.Name =
        let prop = element.GetProperty("name")
        global.Amongonz.LspTypes.LspString(prop)

    /// The kind of this symbol.
    member _.Kind =
        let prop = element.GetProperty("kind")
        enum<SymbolKind>(prop.GetInt32())

    /// Tags for this symbol.
    /// 
    /// @since 3.16.0
    member _.Tags =
        // Requires specialization: "array"

        match element.TryGetProperty("tags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The name of the symbol containing this symbol. This information is for
    /// user interface purposes (e.g. to render a qualifier in the user interface
    /// if necessary). It can&apos;t be used to re-infer a hierarchy for the document
    /// symbols.
    member _.ContainerName =
        match element.TryGetProperty("containerName") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(BaseSymbolInformation(element))

/// Provider options for a {@link DocumentSymbolRequest}.
[<Struct>]
type DocumentSymbolOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A human-readable string that is shown when multiple outlines trees
    /// are shown for the same document.
    /// 
    /// @since 3.16.0
    member _.Label =
        match element.TryGetProperty("label") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "label" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentSymbolOptions(element))
        else Error()

/// Contains additional diagnostic information about the context in which
/// a {@link CodeActionProvider.provideCodeActions code action} is run.
[<Struct>]
type CodeActionContext(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An array of diagnostics known on the client side overlapping the range provided to the
    /// `textDocument/codeAction` request. They are provided so that the server knows which
    /// errors are currently presented to the user for the given range. There is no guarantee
    /// that these accurately reflect the error state of the resource. The primary parameter
    /// to compute code actions is the provided range.
    member _.Diagnostics =
        // Requires specialization: "array"

        let prop = element.GetProperty("diagnostics")
        prop

    /// Requested kind of actions to return.
    /// 
    /// Actions not of this kind are filtered out by the client before being shown. So servers
    /// can omit computing them.
    member _.Only =
        // Requires specialization: "array"

        match element.TryGetProperty("only") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The reason why code actions were requested.
    /// 
    /// @since 3.17.0
    member _.TriggerKind =
        match element.TryGetProperty("triggerKind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<CodeActionTriggerKind>(prop.GetInt32()))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CodeActionContext(element))

/// Provider options for a {@link CodeActionRequest}.
[<Struct>]
type CodeActionOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// CodeActionKinds that this server may return.
    /// 
    /// The list of kinds may be generic, such as `CodeActionKind.Refactor`, or the server
    /// may list out every specific kind they provide.
    member _.CodeActionKinds =
        // Requires specialization: "array"

        match element.TryGetProperty("codeActionKinds") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The server provides support to resolve additional
    /// information for a code action.
    /// 
    /// @since 3.16.0
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CodeActionOptions(element))

/// Server capabilities for a {@link WorkspaceSymbolRequest}.
[<Struct>]
type WorkspaceSymbolOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The server provides support to resolve additional
    /// information for a workspace symbol.
    /// 
    /// @since 3.17.0
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "resolveProvider" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(WorkspaceSymbolOptions(element))
        else Error()

/// Code Lens provider options of a {@link CodeLensRequest}.
[<Struct>]
type CodeLensOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Code lens has a resolve provider as well.
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "resolveProvider" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(CodeLensOptions(element))
        else Error()

/// Provider options for a {@link DocumentLinkRequest}.
[<Struct>]
type DocumentLinkOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Document links have a resolve provider as well.
    member _.ResolveProvider =
        match element.TryGetProperty("resolveProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "resolveProvider" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentLinkOptions(element))
        else Error()

/// Value-object describing what options formatting should use.
[<Struct>]
type FormattingOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Size of a tab in spaces.
    member _.TabSize =
        let prop = element.GetProperty("tabSize")
        prop.GetInt32()

    /// Prefer spaces over tabs.
    member _.InsertSpaces =
        let prop = element.GetProperty("insertSpaces")
        prop.GetBoolean()

    /// Trim trailing whitespace on a line.
    /// 
    /// @since 3.15.0
    member _.TrimTrailingWhitespace =
        match element.TryGetProperty("trimTrailingWhitespace") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Insert a newline character at the end of the file if one does not exist.
    /// 
    /// @since 3.15.0
    member _.InsertFinalNewline =
        match element.TryGetProperty("insertFinalNewline") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Trim all newlines after the final newline at the end of the file.
    /// 
    /// @since 3.15.0
    member _.TrimFinalNewlines =
        match element.TryGetProperty("trimFinalNewlines") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "tabSize" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "insertSpaces" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "trimTrailingWhitespace" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "insertFinalNewline" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "trimFinalNewlines" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(FormattingOptions(element))
        else Error()

/// Provider options for a {@link DocumentFormattingRequest}.
[<Struct>]
type DocumentFormattingOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentFormattingOptions(element))
        else Error()

/// Provider options for a {@link DocumentRangeFormattingRequest}.
[<Struct>]
type DocumentRangeFormattingOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the server supports formatting multiple ranges at once.
    /// 
    /// @since 3.18.0
    /// @proposed
    member _.RangesSupport =
        match element.TryGetProperty("rangesSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "rangesSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentRangeFormattingOptions(element))
        else Error()

/// Provider options for a {@link DocumentOnTypeFormattingRequest}.
[<Struct>]
type DocumentOnTypeFormattingOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A character on which formatting should be triggered, like `{`.
    member _.FirstTriggerCharacter =
        let prop = element.GetProperty("firstTriggerCharacter")
        global.Amongonz.LspTypes.LspString(prop)

    /// More trigger characters.
    member _.MoreTriggerCharacter =
        // Requires specialization: "array"

        match element.TryGetProperty("moreTriggerCharacter") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentOnTypeFormattingOptions(element))

/// Provider options for a {@link RenameRequest}.
[<Struct>]
type RenameOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Renames should be checked and tested before being executed.
    /// 
    /// @since version 3.12.0
    member _.PrepareProvider =
        match element.TryGetProperty("prepareProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "prepareProvider" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(RenameOptions(element))
        else Error()

/// The server capabilities of a {@link ExecuteCommandRequest}.
[<Struct>]
type ExecuteCommandOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The commands to be executed on the server
    member _.Commands =
        // Requires specialization: "array"

        let prop = element.GetProperty("commands")
        prop

    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ExecuteCommandOptions(element))

/// @since 3.16.0
[<Struct>]
type SemanticTokensLegend(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The token types a server uses.
    member _.TokenTypes =
        // Requires specialization: "array"

        let prop = element.GetProperty("tokenTypes")
        prop

    /// The token modifiers a server uses.
    member _.TokenModifiers =
        // Requires specialization: "array"

        let prop = element.GetProperty("tokenModifiers")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokensLegend(element))

/// A text document identifier to optionally denote a specific version of a text document.
[<Struct>]
type OptionalVersionedTextDocumentIdentifier(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The version number of this document. If a versioned text document identifier
    /// is sent from the server to the client and the file is not open in the editor
    /// (the server has not received an open notification before) the server can send
    /// `null` to indicate that the version is unknown and the content on disk is the
    /// truth (as specified with document content ownership).
    member _.Version =
        // Requires specialization: "or"

        let prop = element.GetProperty("version")
        prop

    /// The text document&apos;s uri.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(OptionalVersionedTextDocumentIdentifier(element))

/// A special text edit with an additional change annotation.
/// 
/// @since 3.16.0.
[<Struct>]
type AnnotatedTextEdit(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The actual identifier of the change annotation
    member _.AnnotationId =
        let prop = element.GetProperty("annotationId")
        (global.Amongonz.LspTypes.LspString(prop): ChangeAnnotationIdentifier)

    /// The range of the text document to be manipulated. To insert
    /// text into a document create a range where start === end.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The string to be inserted. For delete operations use an
    /// empty string.
    member _.NewText =
        let prop = element.GetProperty("newText")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "annotationId" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "newText" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(AnnotatedTextEdit(element))
        else Error()

/// A generic resource operation.
[<Struct>]
type ResourceOperation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The resource operation kind.
    member _.Kind =
        let prop = element.GetProperty("kind")
        global.Amongonz.LspTypes.LspString(prop)

    /// An optional annotation identifier describing the operation.
    /// 
    /// @since 3.16.0
    member _.AnnotationId =
        match element.TryGetProperty("annotationId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome((global.Amongonz.LspTypes.LspString(prop): ChangeAnnotationIdentifier))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "kind" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "annotationId" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(ResourceOperation(element))
        else Error()

/// Options to create a file.
[<Struct>]
type CreateFileOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Overwrite existing file. Overwrite wins over `ignoreIfExists`
    member _.Overwrite =
        match element.TryGetProperty("overwrite") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Ignore if exists.
    member _.IgnoreIfExists =
        match element.TryGetProperty("ignoreIfExists") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "overwrite" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "ignoreIfExists" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(CreateFileOptions(element))
        else Error()

/// Rename file options
[<Struct>]
type RenameFileOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Overwrite target if existing. Overwrite wins over `ignoreIfExists`
    member _.Overwrite =
        match element.TryGetProperty("overwrite") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Ignores if target exists.
    member _.IgnoreIfExists =
        match element.TryGetProperty("ignoreIfExists") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "overwrite" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "ignoreIfExists" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(RenameFileOptions(element))
        else Error()

/// Delete file options
[<Struct>]
type DeleteFileOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Delete the content recursively if a folder is denoted.
    member _.Recursive =
        match element.TryGetProperty("recursive") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Ignore the operation if the file doesn&apos;t exist.
    member _.IgnoreIfNotExists =
        match element.TryGetProperty("ignoreIfNotExists") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "recursive" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "ignoreIfNotExists" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DeleteFileOptions(element))
        else Error()

/// A pattern to describe in which file operation requests or notifications
/// the server is interested in receiving.
/// 
/// @since 3.16.0
[<Struct>]
type FileOperationPattern(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The glob pattern to match. Glob patterns can have the following syntax:
    /// - `*` to match one or more characters in a path segment
    /// - `?` to match on one character in a path segment
    /// - `**` to match any number of path segments, including none
    /// - `{}` to group sub patterns into an OR expression. (e.g. `**​/*.{ts,js}` matches all TypeScript and JavaScript files)
    /// - `[]` to declare a range of characters to match in a path segment (e.g., `example.[0-9]` to match on `example.0`, `example.1`, …)
    /// - `[!...]` to negate a range of characters to match in a path segment (e.g., `example.[!0-9]` to match on `example.a`, `example.b`, but not `example.0`)
    member _.Glob =
        let prop = element.GetProperty("glob")
        global.Amongonz.LspTypes.LspString(prop)

    /// Whether to match files or folders with this pattern.
    /// 
    /// Matches both if undefined.
    member _.Matches =
        match element.TryGetProperty("matches") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationPatternKind(prop))

    /// Additional options used during matching.
    member _.Options =
        match element.TryGetProperty("options") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationPatternOptions(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "glob" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "matches" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationPatternKind.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "options" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationPatternOptions.Parse(prop)))
            end
        then Ok(FileOperationPattern(element))
        else Error()

/// A full document diagnostic report for a workspace diagnostic result.
/// 
/// @since 3.17.0
[<Struct>]
type WorkspaceFullDocumentDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The URI for which diagnostic information is reported.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The version number for which the diagnostics are reported.
    /// If the document is not marked as open `null` can be provided.
    member _.Version =
        // Requires specialization: "or"

        let prop = element.GetProperty("version")
        prop

    /// A full document diagnostic report.
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// An optional result id. If provided it will
    /// be sent on the next diagnostic request for the
    /// same document.
    member _.ResultId =
        match element.TryGetProperty("resultId") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// The actual items.
    member _.Items =
        // Requires specialization: "array"

        let prop = element.GetProperty("items")
        prop

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceFullDocumentDiagnosticReport(element))

/// An unchanged document diagnostic report for a workspace diagnostic result.
/// 
/// @since 3.17.0
[<Struct>]
type WorkspaceUnchangedDocumentDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The URI for which diagnostic information is reported.
    member _.Uri =
        let prop = element.GetProperty("uri")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// The version number for which the diagnostics are reported.
    /// If the document is not marked as open `null` can be provided.
    member _.Version =
        // Requires specialization: "or"

        let prop = element.GetProperty("version")
        prop

    /// A document diagnostic report indicating
    /// no changes to the last result. A server can
    /// only return `unchanged` if result ids are
    /// provided.
    member _.Kind =
        // Requires specialization: "stringLiteral"

        let prop = element.GetProperty("kind")
        prop

    /// A result id which will be sent on the next
    /// diagnostic request for the same document.
    member _.ResultId =
        let prop = element.GetProperty("resultId")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceUnchangedDocumentDiagnosticReport(element))

/// A notebook cell.
/// 
/// A cell&apos;s document URI must be unique across ALL notebook
/// cells and can therefore be used to uniquely identify a
/// notebook cell or the cell&apos;s text document.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookCell(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The cell&apos;s kind
    member _.Kind =
        let prop = element.GetProperty("kind")
        enum<NotebookCellKind>(prop.GetInt32())

    /// The URI of the cell&apos;s text document
    /// content.
    member _.Document =
        let prop = element.GetProperty("document")
        global.Amongonz.LspTypes.LspDocumentUri(prop.GetString())

    /// Additional metadata stored with the cell.
    /// 
    /// Note: should always be an object literal (e.g. LSPObject)
    member _.Metadata =
        match element.TryGetProperty("metadata") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPObject(prop))

    /// Additional execution summary information
    /// if supported by the client.
    member _.ExecutionSummary =
        match element.TryGetProperty("executionSummary") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ExecutionSummary(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "kind" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> true)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "document" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "metadata" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (LSPObject.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "executionSummary" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ExecutionSummary.Parse(prop)))
            end
        then Ok(NotebookCell(element))
        else Error()

/// A change describing how to move a `NotebookCell`
/// array from state S to S&apos;.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookCellArrayChange(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The start oftest of the cell that changed.
    member _.Start =
        let prop = element.GetProperty("start")
        prop.GetInt32()

    /// The deleted cells
    member _.DeleteCount =
        let prop = element.GetProperty("deleteCount")
        prop.GetInt32()

    /// The new cells, if any
    member _.Cells =
        // Requires specialization: "array"

        match element.TryGetProperty("cells") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(NotebookCellArrayChange(element))

/// Describes the currently selected completion item.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type SelectedCompletionInfo(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The range that will be replaced if this completion item is accepted.
    member _.Range =
        let prop = element.GetProperty("range")
        Range(prop)

    /// The text the range will be replaced with if this completion is accepted.
    member _.Text =
        let prop = element.GetProperty("text")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "range" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Range.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "text" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(SelectedCompletionInfo(element))
        else Error()

/// Defines the capabilities provided by the client.
[<Struct>]
type ClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Workspace specific client capabilities.
    member _.Workspace =
        match element.TryGetProperty("workspace") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(WorkspaceClientCapabilities(prop))

    /// Text document specific client capabilities.
    member _.TextDocument =
        match element.TryGetProperty("textDocument") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(TextDocumentClientCapabilities(prop))

    /// Capabilities specific to the notebook document support.
    /// 
    /// @since 3.17.0
    member _.NotebookDocument =
        match element.TryGetProperty("notebookDocument") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(NotebookDocumentClientCapabilities(prop))

    /// Window specific client capabilities.
    member _.Window =
        match element.TryGetProperty("window") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(WindowClientCapabilities(prop))

    /// General client capabilities.
    /// 
    /// @since 3.16.0
    member _.General =
        match element.TryGetProperty("general") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(GeneralClientCapabilities(prop))

    /// Experimental client capabilities.
    member _.Experimental =
        match element.TryGetProperty("experimental") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LSPAny(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workspace" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (WorkspaceClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "textDocument" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "notebookDocument" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (NotebookDocumentClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "window" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (WindowClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "general" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (GeneralClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "experimental" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (LSPAny.Parse(prop)))
            end
        then Ok(ClientCapabilities(element))
        else Error()

[<Struct>]
type TextDocumentSyncOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Open and close notifications are sent to the server. If omitted open close notification should not
    /// be sent.
    member _.OpenClose =
        match element.TryGetProperty("openClose") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Change notifications are sent to the server. See TextDocumentSyncKind.None, TextDocumentSyncKind.Full
    /// and TextDocumentSyncKind.Incremental. If omitted it defaults to TextDocumentSyncKind.None.
    member _.Change =
        match element.TryGetProperty("change") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<TextDocumentSyncKind>(prop.GetInt32()))

    /// If present will save notifications are sent to the server. If omitted the notification should not be
    /// sent.
    member _.WillSave =
        match element.TryGetProperty("willSave") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// If present will save wait until requests are sent to the server. If omitted the request should not be
    /// sent.
    member _.WillSaveWaitUntil =
        match element.TryGetProperty("willSaveWaitUntil") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// If present save notifications are sent to the server. If omitted the notification should not be
    /// sent.
    member _.Save =
        // Requires specialization: "or"

        match element.TryGetProperty("save") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(TextDocumentSyncOptions(element))

/// Options specific to a notebook plus its cells
/// to be synced to the server.
/// 
/// If a selector provides a notebook document
/// filter but no cell selector all cells of a
/// matching notebook document will be synced.
/// 
/// If a selector provides no notebook document
/// filter but only a cell selector all notebook
/// document that contain at least one matching
/// cell will be synced.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookDocumentSyncOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The notebooks to be synced
    member _.NotebookSelector =
        // Requires specialization: "array"

        let prop = element.GetProperty("notebookSelector")
        prop

    /// Whether save notification should be forwarded to
    /// the server. Will only be honored if mode === `notebook`.
    member _.Save =
        match element.TryGetProperty("save") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(NotebookDocumentSyncOptions(element))

/// Registration options specific to a notebook.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookDocumentSyncRegistrationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The notebooks to be synced
    member _.NotebookSelector =
        // Requires specialization: "array"

        let prop = element.GetProperty("notebookSelector")
        prop

    /// Whether save notification should be forwarded to
    /// the server. Will only be honored if mode === `notebook`.
    member _.Save =
        match element.TryGetProperty("save") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The id used to register the request. The id can be used to deregister
    /// the request again. See also Registration#id.
    member _.Id =
        match element.TryGetProperty("id") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(NotebookDocumentSyncRegistrationOptions(element))

[<Struct>]
type WorkspaceFoldersServerCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The server has support for workspace folders
    member _.Supported =
        match element.TryGetProperty("supported") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the server wants to receive workspace folder
    /// change notifications.
    /// 
    /// If a string is provided the string is treated as an ID
    /// under which the notification is registered on the client
    /// side. The ID can be used to unregister for these events
    /// using the `client/unregisterCapability` request.
    member _.ChangeNotifications =
        // Requires specialization: "or"

        match element.TryGetProperty("changeNotifications") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceFoldersServerCapabilities(element))

/// Options for notifications/requests for user operations on files.
/// 
/// @since 3.16.0
[<Struct>]
type FileOperationOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The server is interested in receiving didCreateFiles notifications.
    member _.DidCreate =
        match element.TryGetProperty("didCreate") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationRegistrationOptions(prop))

    /// The server is interested in receiving willCreateFiles requests.
    member _.WillCreate =
        match element.TryGetProperty("willCreate") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationRegistrationOptions(prop))

    /// The server is interested in receiving didRenameFiles notifications.
    member _.DidRename =
        match element.TryGetProperty("didRename") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationRegistrationOptions(prop))

    /// The server is interested in receiving willRenameFiles requests.
    member _.WillRename =
        match element.TryGetProperty("willRename") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationRegistrationOptions(prop))

    /// The server is interested in receiving didDeleteFiles file notifications.
    member _.DidDelete =
        match element.TryGetProperty("didDelete") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationRegistrationOptions(prop))

    /// The server is interested in receiving willDeleteFiles file requests.
    member _.WillDelete =
        match element.TryGetProperty("willDelete") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationRegistrationOptions(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didCreate" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationRegistrationOptions.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "willCreate" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationRegistrationOptions.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didRename" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationRegistrationOptions.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "willRename" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationRegistrationOptions.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didDelete" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationRegistrationOptions.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "willDelete" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationRegistrationOptions.Parse(prop)))
            end
        then Ok(FileOperationOptions(element))
        else Error()

/// Structure to capture a description for an error code.
/// 
/// @since 3.16.0
[<Struct>]
type CodeDescription(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// An URI to open with more information about the diagnostic error.
    member _.Href =
        let prop = element.GetProperty("href")
        global.System.Uri(prop.GetString())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "href" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidUri prop)
            end
        then Ok(CodeDescription(element))
        else Error()

/// Represents a related message and source code location for a diagnostic. This should be
/// used to point to code locations that cause or related to a diagnostics, e.g when duplicating
/// a symbol in a scope.
[<Struct>]
type DiagnosticRelatedInformation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The location of this related diagnostic information.
    member _.Location =
        let prop = element.GetProperty("location")
        Location(prop)

    /// The message of this related diagnostic information.
    member _.Message =
        let prop = element.GetProperty("message")
        global.Amongonz.LspTypes.LspString(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "location" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (Location.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "message" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(DiagnosticRelatedInformation(element))
        else Error()

/// Represents a parameter of a callable-signature. A parameter can
/// have a label and a doc-comment.
[<Struct>]
type ParameterInformation(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The label of this parameter information.
    /// 
    /// Either a string or an inclusive start and exclusive end offsets within its containing
    /// signature label. (see SignatureInformation.label). The offsets are based on a UTF-16
    /// string representation as `Position` and `Range` does.
    /// 
    /// *Note*: a label of type string should be a substring of its containing signature label.
    /// Its intended use case is to highlight the parameter label part in the `SignatureInformation.label`.
    member _.Label =
        // Requires specialization: "or"

        let prop = element.GetProperty("label")
        prop

    /// The human-readable doc-comment of this parameter. Will be shown
    /// in the UI but can be omitted.
    member _.Documentation =
        // Requires specialization: "or"

        match element.TryGetProperty("documentation") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ParameterInformation(element))

/// A notebook cell text document filter denotes a cell text
/// document by different properties.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookCellTextDocumentFilter(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A filter that matches against the notebook
    /// containing the notebook cell. If a string
    /// value is provided it matches against the
    /// notebook type. &apos;*&apos; matches every notebook.
    member _.Notebook =
        // Requires specialization: "or"

        let prop = element.GetProperty("notebook")
        prop

    /// A language id like `python`.
    /// 
    /// Will be matched against the language id of the
    /// notebook cell document. &apos;*&apos; matches every language.
    member _.Language =
        match element.TryGetProperty("language") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(NotebookCellTextDocumentFilter(element))

/// Matching options for the file operation pattern.
/// 
/// @since 3.16.0
[<Struct>]
type FileOperationPatternOptions(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The pattern should be matched ignoring casing.
    member _.IgnoreCase =
        match element.TryGetProperty("ignoreCase") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "ignoreCase" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(FileOperationPatternOptions(element))
        else Error()

[<Struct>]
type ExecutionSummary(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A strict monotonically increasing value
    /// indicating the execution order of a cell
    /// inside a notebook.
    member _.ExecutionOrder =
        let prop = element.GetProperty("executionOrder")
        prop.GetInt32()

    /// Whether the execution was successful or
    /// not if known by the client.
    member _.Success =
        match element.TryGetProperty("success") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "executionOrder" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidInteger prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "success" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ExecutionSummary(element))
        else Error()

/// Workspace specific client capabilities.
[<Struct>]
type WorkspaceClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The client supports applying batch edits
    /// to the workspace by supporting the request
    /// &apos;workspace/applyEdit&apos;
    member _.ApplyEdit =
        match element.TryGetProperty("applyEdit") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Capabilities specific to `WorkspaceEdit`s.
    member _.WorkspaceEdit =
        match element.TryGetProperty("workspaceEdit") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(WorkspaceEditClientCapabilities(prop))

    /// Capabilities specific to the `workspace/didChangeConfiguration` notification.
    member _.DidChangeConfiguration =
        match element.TryGetProperty("didChangeConfiguration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DidChangeConfigurationClientCapabilities(prop))

    /// Capabilities specific to the `workspace/didChangeWatchedFiles` notification.
    member _.DidChangeWatchedFiles =
        match element.TryGetProperty("didChangeWatchedFiles") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DidChangeWatchedFilesClientCapabilities(prop))

    /// Capabilities specific to the `workspace/symbol` request.
    member _.Symbol =
        match element.TryGetProperty("symbol") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(WorkspaceSymbolClientCapabilities(prop))

    /// Capabilities specific to the `workspace/executeCommand` request.
    member _.ExecuteCommand =
        match element.TryGetProperty("executeCommand") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ExecuteCommandClientCapabilities(prop))

    /// The client has support for workspace folders.
    /// 
    /// @since 3.6.0
    member _.WorkspaceFolders =
        match element.TryGetProperty("workspaceFolders") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports `workspace/configuration` requests.
    /// 
    /// @since 3.6.0
    member _.Configuration =
        match element.TryGetProperty("configuration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Capabilities specific to the semantic token requests scoped to the
    /// workspace.
    /// 
    /// @since 3.16.0.
    member _.SemanticTokens =
        match element.TryGetProperty("semanticTokens") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SemanticTokensWorkspaceClientCapabilities(prop))

    /// Capabilities specific to the code lens requests scoped to the
    /// workspace.
    /// 
    /// @since 3.16.0.
    member _.CodeLens =
        match element.TryGetProperty("codeLens") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CodeLensWorkspaceClientCapabilities(prop))

    /// The client has support for file notifications/requests for user operations on files.
    /// 
    /// Since 3.16.0
    member _.FileOperations =
        match element.TryGetProperty("fileOperations") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FileOperationClientCapabilities(prop))

    /// Capabilities specific to the inline values requests scoped to the
    /// workspace.
    /// 
    /// @since 3.17.0.
    member _.InlineValue =
        match element.TryGetProperty("inlineValue") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(InlineValueWorkspaceClientCapabilities(prop))

    /// Capabilities specific to the inlay hint requests scoped to the
    /// workspace.
    /// 
    /// @since 3.17.0.
    member _.InlayHint =
        match element.TryGetProperty("inlayHint") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(InlayHintWorkspaceClientCapabilities(prop))

    /// Capabilities specific to the diagnostic requests scoped to the
    /// workspace.
    /// 
    /// @since 3.17.0.
    member _.Diagnostics =
        match element.TryGetProperty("diagnostics") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DiagnosticWorkspaceClientCapabilities(prop))

    /// Capabilities specific to the folding range requests scoped to the workspace.
    /// 
    /// @since 3.18.0
    /// @proposed
    member _.FoldingRange =
        match element.TryGetProperty("foldingRange") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FoldingRangeWorkspaceClientCapabilities(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "applyEdit" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workspaceEdit" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (WorkspaceEditClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didChangeConfiguration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DidChangeConfigurationClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didChangeWatchedFiles" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DidChangeWatchedFilesClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "symbol" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (WorkspaceSymbolClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "executeCommand" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ExecuteCommandClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workspaceFolders" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "configuration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "semanticTokens" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (SemanticTokensWorkspaceClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "codeLens" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (CodeLensWorkspaceClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "fileOperations" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FileOperationClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "inlineValue" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (InlineValueWorkspaceClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "inlayHint" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (InlayHintWorkspaceClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "diagnostics" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DiagnosticWorkspaceClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "foldingRange" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FoldingRangeWorkspaceClientCapabilities.Parse(prop)))
            end
        then Ok(WorkspaceClientCapabilities(element))
        else Error()

/// Text document specific client capabilities.
[<Struct>]
type TextDocumentClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Defines which synchronization capabilities the client supports.
    member _.Synchronization =
        match element.TryGetProperty("synchronization") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(TextDocumentSyncClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/completion` request.
    member _.Completion =
        match element.TryGetProperty("completion") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CompletionClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/hover` request.
    member _.Hover =
        match element.TryGetProperty("hover") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(HoverClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/signatureHelp` request.
    member _.SignatureHelp =
        match element.TryGetProperty("signatureHelp") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SignatureHelpClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/declaration` request.
    /// 
    /// @since 3.14.0
    member _.Declaration =
        match element.TryGetProperty("declaration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DeclarationClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/definition` request.
    member _.Definition =
        match element.TryGetProperty("definition") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DefinitionClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/typeDefinition` request.
    /// 
    /// @since 3.6.0
    member _.TypeDefinition =
        match element.TryGetProperty("typeDefinition") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(TypeDefinitionClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/implementation` request.
    /// 
    /// @since 3.6.0
    member _.Implementation =
        match element.TryGetProperty("implementation") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ImplementationClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/references` request.
    member _.References =
        match element.TryGetProperty("references") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ReferenceClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/documentHighlight` request.
    member _.DocumentHighlight =
        match element.TryGetProperty("documentHighlight") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentHighlightClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/documentSymbol` request.
    member _.DocumentSymbol =
        match element.TryGetProperty("documentSymbol") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentSymbolClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/codeAction` request.
    member _.CodeAction =
        match element.TryGetProperty("codeAction") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CodeActionClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/codeLens` request.
    member _.CodeLens =
        match element.TryGetProperty("codeLens") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CodeLensClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/documentLink` request.
    member _.DocumentLink =
        match element.TryGetProperty("documentLink") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentLinkClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/documentColor` and the
    /// `textDocument/colorPresentation` request.
    /// 
    /// @since 3.6.0
    member _.ColorProvider =
        match element.TryGetProperty("colorProvider") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentColorClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/formatting` request.
    member _.Formatting =
        match element.TryGetProperty("formatting") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentFormattingClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/rangeFormatting` request.
    member _.RangeFormatting =
        match element.TryGetProperty("rangeFormatting") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentRangeFormattingClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/onTypeFormatting` request.
    member _.OnTypeFormatting =
        match element.TryGetProperty("onTypeFormatting") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DocumentOnTypeFormattingClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/rename` request.
    member _.Rename =
        match element.TryGetProperty("rename") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(RenameClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/foldingRange` request.
    /// 
    /// @since 3.10.0
    member _.FoldingRange =
        match element.TryGetProperty("foldingRange") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FoldingRangeClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/selectionRange` request.
    /// 
    /// @since 3.15.0
    member _.SelectionRange =
        match element.TryGetProperty("selectionRange") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SelectionRangeClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/publishDiagnostics` notification.
    member _.PublishDiagnostics =
        match element.TryGetProperty("publishDiagnostics") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(PublishDiagnosticsClientCapabilities(prop))

    /// Capabilities specific to the various call hierarchy requests.
    /// 
    /// @since 3.16.0
    member _.CallHierarchy =
        match element.TryGetProperty("callHierarchy") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(CallHierarchyClientCapabilities(prop))

    /// Capabilities specific to the various semantic token request.
    /// 
    /// @since 3.16.0
    member _.SemanticTokens =
        match element.TryGetProperty("semanticTokens") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(SemanticTokensClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/linkedEditingRange` request.
    /// 
    /// @since 3.16.0
    member _.LinkedEditingRange =
        match element.TryGetProperty("linkedEditingRange") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(LinkedEditingRangeClientCapabilities(prop))

    /// Client capabilities specific to the `textDocument/moniker` request.
    /// 
    /// @since 3.16.0
    member _.Moniker =
        match element.TryGetProperty("moniker") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(MonikerClientCapabilities(prop))

    /// Capabilities specific to the various type hierarchy requests.
    /// 
    /// @since 3.17.0
    member _.TypeHierarchy =
        match element.TryGetProperty("typeHierarchy") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(TypeHierarchyClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/inlineValue` request.
    /// 
    /// @since 3.17.0
    member _.InlineValue =
        match element.TryGetProperty("inlineValue") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(InlineValueClientCapabilities(prop))

    /// Capabilities specific to the `textDocument/inlayHint` request.
    /// 
    /// @since 3.17.0
    member _.InlayHint =
        match element.TryGetProperty("inlayHint") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(InlayHintClientCapabilities(prop))

    /// Capabilities specific to the diagnostic pull model.
    /// 
    /// @since 3.17.0
    member _.Diagnostic =
        match element.TryGetProperty("diagnostic") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(DiagnosticClientCapabilities(prop))

    /// Client capabilities specific to inline completions.
    /// 
    /// @since 3.18.0
    /// @proposed
    member _.InlineCompletion =
        match element.TryGetProperty("inlineCompletion") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(InlineCompletionClientCapabilities(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "synchronization" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (TextDocumentSyncClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "completion" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (CompletionClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "hover" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (HoverClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "signatureHelp" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (SignatureHelpClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "declaration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DeclarationClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "definition" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DefinitionClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "typeDefinition" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (TypeDefinitionClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "implementation" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ImplementationClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "references" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ReferenceClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "documentHighlight" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DocumentHighlightClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "documentSymbol" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DocumentSymbolClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "codeAction" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (CodeActionClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "codeLens" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (CodeLensClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "documentLink" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DocumentLinkClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "colorProvider" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DocumentColorClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "formatting" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DocumentFormattingClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "rangeFormatting" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DocumentRangeFormattingClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "onTypeFormatting" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DocumentOnTypeFormattingClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "rename" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (RenameClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "foldingRange" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (FoldingRangeClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "selectionRange" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (SelectionRangeClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "publishDiagnostics" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (PublishDiagnosticsClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "callHierarchy" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (CallHierarchyClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "semanticTokens" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (SemanticTokensClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "linkedEditingRange" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (LinkedEditingRangeClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "moniker" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (MonikerClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "typeHierarchy" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (TypeHierarchyClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "inlineValue" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (InlineValueClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "inlayHint" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (InlayHintClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "diagnostic" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (DiagnosticClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "inlineCompletion" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (InlineCompletionClientCapabilities.Parse(prop)))
            end
        then Ok(TextDocumentClientCapabilities(element))
        else Error()

/// Capabilities specific to the notebook document support.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookDocumentClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Capabilities specific to notebook document synchronization
    /// 
    /// @since 3.17.0
    member _.Synchronization =
        let prop = element.GetProperty("synchronization")
        NotebookDocumentSyncClientCapabilities(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "synchronization" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (NotebookDocumentSyncClientCapabilities.Parse(prop)))
            end
        then Ok(NotebookDocumentClientCapabilities(element))
        else Error()

[<Struct>]
type WindowClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// It indicates whether the client supports server initiated
    /// progress using the `window/workDoneProgress/create` request.
    /// 
    /// The capability also controls Whether client supports handling
    /// of progress notifications. If set servers are allowed to report a
    /// `workDoneProgress` property in the request specific server
    /// capabilities.
    /// 
    /// @since 3.15.0
    member _.WorkDoneProgress =
        match element.TryGetProperty("workDoneProgress") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Capabilities specific to the showMessage request.
    /// 
    /// @since 3.16.0
    member _.ShowMessage =
        match element.TryGetProperty("showMessage") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ShowMessageRequestClientCapabilities(prop))

    /// Capabilities specific to the showDocument request.
    /// 
    /// @since 3.16.0
    member _.ShowDocument =
        match element.TryGetProperty("showDocument") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(ShowDocumentClientCapabilities(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "workDoneProgress" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "showMessage" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ShowMessageRequestClientCapabilities.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "showDocument" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (ShowDocumentClientCapabilities.Parse(prop)))
            end
        then Ok(WindowClientCapabilities(element))
        else Error()

/// General client capabilities.
/// 
/// @since 3.16.0
[<Struct>]
type GeneralClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Client capability that signals how the client
    /// handles stale requests (e.g. a request
    /// for which the client will not process the response
    /// anymore since the information is outdated).
    /// 
    /// @since 3.17.0
    member _.StaleRequestSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("staleRequestSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Client capabilities specific to regular expressions.
    /// 
    /// @since 3.16.0
    member _.RegularExpressions =
        match element.TryGetProperty("regularExpressions") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(RegularExpressionsClientCapabilities(prop))

    /// Client capabilities specific to the client&apos;s markdown parser.
    /// 
    /// @since 3.16.0
    member _.Markdown =
        match element.TryGetProperty("markdown") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(MarkdownClientCapabilities(prop))

    /// The position encodings supported by the client. Client and server
    /// have to agree on the same position encoding to ensure that offsets
    /// (e.g. character position in a line) are interpreted the same on both
    /// sides.
    /// 
    /// To keep the protocol backwards compatible the following applies: if
    /// the value &apos;utf-16&apos; is missing from the array of position encodings
    /// servers can assume that the client supports UTF-16. UTF-16 is
    /// therefore a mandatory encoding.
    /// 
    /// If omitted it defaults to [&apos;utf-16&apos;].
    /// 
    /// Implementation considerations: since the conversion from one encoding
    /// into another requires the content of the file / line the conversion
    /// is best done where the file is read which is usually on the server
    /// side.
    /// 
    /// @since 3.17.0
    member _.PositionEncodings =
        // Requires specialization: "array"

        match element.TryGetProperty("positionEncodings") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(GeneralClientCapabilities(element))

/// A relative pattern is a helper to construct glob patterns that are matched
/// relatively to a base URI. The common value for a `baseUri` is a workspace
/// folder root, but it can be another absolute URI as well.
/// 
/// @since 3.17.0
[<Struct>]
type RelativePattern(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// A workspace folder or a base URI to which this pattern will be matched
    /// against relatively.
    member _.BaseUri =
        // Requires specialization: "or"

        let prop = element.GetProperty("baseUri")
        prop

    /// The actual glob pattern;
    member _.Pattern =
        let prop = element.GetProperty("pattern")
        (global.Amongonz.LspTypes.LspString(prop): Pattern)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(RelativePattern(element))

[<Struct>]
type WorkspaceEditClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The client supports versioned document changes in `WorkspaceEdit`s
    member _.DocumentChanges =
        match element.TryGetProperty("documentChanges") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The resource operations the client supports. Clients should at least
    /// support &apos;create&apos;, &apos;rename&apos; and &apos;delete&apos; files and folders.
    /// 
    /// @since 3.13.0
    member _.ResourceOperations =
        // Requires specialization: "array"

        match element.TryGetProperty("resourceOperations") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The failure handling strategy of a client if applying the workspace edit
    /// fails.
    /// 
    /// @since 3.13.0
    member _.FailureHandling =
        match element.TryGetProperty("failureHandling") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(FailureHandlingKind(prop))

    /// Whether the client normalizes line endings to the client specific
    /// setting.
    /// If set to `true` the client will normalize line ending characters
    /// in a workspace edit to the client-specified new line
    /// character.
    /// 
    /// @since 3.16.0
    member _.NormalizesLineEndings =
        match element.TryGetProperty("normalizesLineEndings") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the client in general supports change annotations on text edits,
    /// create file, rename file and delete file changes.
    /// 
    /// @since 3.16.0
    member _.ChangeAnnotationSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("changeAnnotationSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceEditClientCapabilities(element))

[<Struct>]
type DidChangeConfigurationClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Did change configuration notification supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DidChangeConfigurationClientCapabilities(element))
        else Error()

[<Struct>]
type DidChangeWatchedFilesClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Did change watched files notification supports dynamic registration. Please note
    /// that the current protocol doesn&apos;t support static configuration for file changes
    /// from the server side.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the client has support for {@link  RelativePattern relative pattern}
    /// or not.
    /// 
    /// @since 3.17.0
    member _.RelativePatternSupport =
        match element.TryGetProperty("relativePatternSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "relativePatternSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DidChangeWatchedFilesClientCapabilities(element))
        else Error()

/// Client capabilities for a {@link WorkspaceSymbolRequest}.
[<Struct>]
type WorkspaceSymbolClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Symbol request supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Specific capabilities for the `SymbolKind` in the `workspace/symbol` request.
    member _.SymbolKind =
        // Requires specialization: "literal"

        match element.TryGetProperty("symbolKind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The client supports tags on `SymbolInformation`.
    /// Clients supporting tags have to handle unknown tags gracefully.
    /// 
    /// @since 3.16.0
    member _.TagSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("tagSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The client support partial workspace symbols. The client will send the
    /// request `workspaceSymbol/resolve` to the server to resolve additional
    /// properties.
    /// 
    /// @since 3.17.0
    member _.ResolveSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("resolveSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(WorkspaceSymbolClientCapabilities(element))

/// The client capabilities of a {@link ExecuteCommandRequest}.
[<Struct>]
type ExecuteCommandClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Execute command supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ExecuteCommandClientCapabilities(element))
        else Error()

/// @since 3.16.0
[<Struct>]
type SemanticTokensWorkspaceClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the client implementation supports a refresh request sent from
    /// the server to the client.
    /// 
    /// Note that this event is global and will force the client to refresh all
    /// semantic tokens currently shown. It should be used with absolute care
    /// and is useful for situation where a server for example detects a project
    /// wide change that requires such a calculation.
    member _.RefreshSupport =
        match element.TryGetProperty("refreshSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "refreshSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(SemanticTokensWorkspaceClientCapabilities(element))
        else Error()

/// @since 3.16.0
[<Struct>]
type CodeLensWorkspaceClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the client implementation supports a refresh request sent from the
    /// server to the client.
    /// 
    /// Note that this event is global and will force the client to refresh all
    /// code lenses currently shown. It should be used with absolute care and is
    /// useful for situation where a server for example detect a project wide
    /// change that requires such a calculation.
    member _.RefreshSupport =
        match element.TryGetProperty("refreshSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "refreshSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(CodeLensWorkspaceClientCapabilities(element))
        else Error()

/// Capabilities relating to events from file operations by the user in the client.
/// 
/// These events do not come from the file system, they come from user operations
/// like renaming a file in the UI.
/// 
/// @since 3.16.0
[<Struct>]
type FileOperationClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the client supports dynamic registration for file requests/notifications.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client has support for sending didCreateFiles notifications.
    member _.DidCreate =
        match element.TryGetProperty("didCreate") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client has support for sending willCreateFiles requests.
    member _.WillCreate =
        match element.TryGetProperty("willCreate") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client has support for sending didRenameFiles notifications.
    member _.DidRename =
        match element.TryGetProperty("didRename") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client has support for sending willRenameFiles requests.
    member _.WillRename =
        match element.TryGetProperty("willRename") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client has support for sending didDeleteFiles notifications.
    member _.DidDelete =
        match element.TryGetProperty("didDelete") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client has support for sending willDeleteFiles requests.
    member _.WillDelete =
        match element.TryGetProperty("willDelete") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didCreate" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "willCreate" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didRename" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "willRename" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didDelete" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "willDelete" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(FileOperationClientCapabilities(element))
        else Error()

/// Client workspace capabilities specific to inline values.
/// 
/// @since 3.17.0
[<Struct>]
type InlineValueWorkspaceClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the client implementation supports a refresh request sent from the
    /// server to the client.
    /// 
    /// Note that this event is global and will force the client to refresh all
    /// inline values currently shown. It should be used with absolute care and is
    /// useful for situation where a server for example detects a project wide
    /// change that requires such a calculation.
    member _.RefreshSupport =
        match element.TryGetProperty("refreshSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "refreshSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InlineValueWorkspaceClientCapabilities(element))
        else Error()

/// Client workspace capabilities specific to inlay hints.
/// 
/// @since 3.17.0
[<Struct>]
type InlayHintWorkspaceClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the client implementation supports a refresh request sent from
    /// the server to the client.
    /// 
    /// Note that this event is global and will force the client to refresh all
    /// inlay hints currently shown. It should be used with absolute care and
    /// is useful for situation where a server for example detects a project wide
    /// change that requires such a calculation.
    member _.RefreshSupport =
        match element.TryGetProperty("refreshSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "refreshSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InlayHintWorkspaceClientCapabilities(element))
        else Error()

/// Workspace client capabilities specific to diagnostic pull requests.
/// 
/// @since 3.17.0
[<Struct>]
type DiagnosticWorkspaceClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the client implementation supports a refresh request sent from
    /// the server to the client.
    /// 
    /// Note that this event is global and will force the client to refresh all
    /// pulled diagnostics currently shown. It should be used with absolute care and
    /// is useful for situation where a server for example detects a project wide
    /// change that requires such a calculation.
    member _.RefreshSupport =
        match element.TryGetProperty("refreshSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "refreshSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DiagnosticWorkspaceClientCapabilities(element))
        else Error()

/// Client workspace capabilities specific to folding ranges
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type FoldingRangeWorkspaceClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the client implementation supports a refresh request sent from the
    /// server to the client.
    /// 
    /// Note that this event is global and will force the client to refresh all
    /// folding ranges currently shown. It should be used with absolute care and is
    /// useful for situation where a server for example detects a project wide
    /// change that requires such a calculation.
    /// 
    /// @since 3.18.0
    /// @proposed
    member _.RefreshSupport =
        match element.TryGetProperty("refreshSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "refreshSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(FoldingRangeWorkspaceClientCapabilities(element))
        else Error()

[<Struct>]
type TextDocumentSyncClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether text document synchronization supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports sending will save notifications.
    member _.WillSave =
        match element.TryGetProperty("willSave") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports sending a will save request and
    /// waits for a response providing text edits which will
    /// be applied to the document before it is saved.
    member _.WillSaveWaitUntil =
        match element.TryGetProperty("willSaveWaitUntil") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports did save notifications.
    member _.DidSave =
        match element.TryGetProperty("didSave") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "willSave" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "willSaveWaitUntil" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "didSave" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(TextDocumentSyncClientCapabilities(element))
        else Error()

/// Completion client capabilities
[<Struct>]
type CompletionClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether completion supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports the following `CompletionItem` specific
    /// capabilities.
    member _.CompletionItem =
        // Requires specialization: "literal"

        match element.TryGetProperty("completionItem") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    member _.CompletionItemKind =
        // Requires specialization: "literal"

        match element.TryGetProperty("completionItemKind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Defines how the client handles whitespace and indentation
    /// when accepting a completion item that uses multi line
    /// text in either `insertText` or `textEdit`.
    /// 
    /// @since 3.17.0
    member _.InsertTextMode =
        match element.TryGetProperty("insertTextMode") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<InsertTextMode>(prop.GetInt32()))

    /// The client supports to send additional context information for a
    /// `textDocument/completion` request.
    member _.ContextSupport =
        match element.TryGetProperty("contextSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports the following `CompletionList` specific
    /// capabilities.
    /// 
    /// @since 3.17.0
    member _.CompletionList =
        // Requires specialization: "literal"

        match element.TryGetProperty("completionList") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CompletionClientCapabilities(element))

[<Struct>]
type HoverClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether hover supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Client supports the following content formats for the content
    /// property. The order describes the preferred format of the client.
    member _.ContentFormat =
        // Requires specialization: "array"

        match element.TryGetProperty("contentFormat") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(HoverClientCapabilities(element))

/// Client Capabilities for a {@link SignatureHelpRequest}.
[<Struct>]
type SignatureHelpClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether signature help supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports the following `SignatureInformation`
    /// specific properties.
    member _.SignatureInformation =
        // Requires specialization: "literal"

        match element.TryGetProperty("signatureInformation") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The client supports to send additional context information for a
    /// `textDocument/signatureHelp` request. A client that opts into
    /// contextSupport will also support the `retriggerCharacters` on
    /// `SignatureHelpOptions`.
    /// 
    /// @since 3.15.0
    member _.ContextSupport =
        match element.TryGetProperty("contextSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SignatureHelpClientCapabilities(element))

/// @since 3.14.0
[<Struct>]
type DeclarationClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether declaration supports dynamic registration. If this is set to `true`
    /// the client supports the new `DeclarationRegistrationOptions` return value
    /// for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports additional metadata in the form of declaration links.
    member _.LinkSupport =
        match element.TryGetProperty("linkSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "linkSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DeclarationClientCapabilities(element))
        else Error()

/// Client Capabilities for a {@link DefinitionRequest}.
[<Struct>]
type DefinitionClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether definition supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports additional metadata in the form of definition links.
    /// 
    /// @since 3.14.0
    member _.LinkSupport =
        match element.TryGetProperty("linkSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "linkSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DefinitionClientCapabilities(element))
        else Error()

/// Since 3.6.0
[<Struct>]
type TypeDefinitionClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is set to `true`
    /// the client supports the new `TypeDefinitionRegistrationOptions` return value
    /// for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports additional metadata in the form of definition links.
    /// 
    /// Since 3.14.0
    member _.LinkSupport =
        match element.TryGetProperty("linkSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "linkSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(TypeDefinitionClientCapabilities(element))
        else Error()

/// @since 3.6.0
[<Struct>]
type ImplementationClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is set to `true`
    /// the client supports the new `ImplementationRegistrationOptions` return value
    /// for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports additional metadata in the form of definition links.
    /// 
    /// @since 3.14.0
    member _.LinkSupport =
        match element.TryGetProperty("linkSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "linkSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ImplementationClientCapabilities(element))
        else Error()

/// Client Capabilities for a {@link ReferencesRequest}.
[<Struct>]
type ReferenceClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether references supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ReferenceClientCapabilities(element))
        else Error()

/// Client Capabilities for a {@link DocumentHighlightRequest}.
[<Struct>]
type DocumentHighlightClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether document highlight supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentHighlightClientCapabilities(element))
        else Error()

/// Client Capabilities for a {@link DocumentSymbolRequest}.
[<Struct>]
type DocumentSymbolClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether document symbol supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Specific capabilities for the `SymbolKind` in the
    /// `textDocument/documentSymbol` request.
    member _.SymbolKind =
        // Requires specialization: "literal"

        match element.TryGetProperty("symbolKind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The client supports hierarchical document symbols.
    member _.HierarchicalDocumentSymbolSupport =
        match element.TryGetProperty("hierarchicalDocumentSymbolSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports tags on `SymbolInformation`. Tags are supported on
    /// `DocumentSymbol` if `hierarchicalDocumentSymbolSupport` is set to true.
    /// Clients supporting tags have to handle unknown tags gracefully.
    /// 
    /// @since 3.16.0
    member _.TagSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("tagSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// The client supports an additional label presented in the UI when
    /// registering a document symbol provider.
    /// 
    /// @since 3.16.0
    member _.LabelSupport =
        match element.TryGetProperty("labelSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(DocumentSymbolClientCapabilities(element))

/// The Client Capabilities of a {@link CodeActionRequest}.
[<Struct>]
type CodeActionClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether code action supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client support code action literals of type `CodeAction` as a valid
    /// response of the `textDocument/codeAction` request. If the property is not
    /// set the request can only return `Command` literals.
    /// 
    /// @since 3.8.0
    member _.CodeActionLiteralSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("codeActionLiteralSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Whether code action supports the `isPreferred` property.
    /// 
    /// @since 3.15.0
    member _.IsPreferredSupport =
        match element.TryGetProperty("isPreferredSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether code action supports the `disabled` property.
    /// 
    /// @since 3.16.0
    member _.DisabledSupport =
        match element.TryGetProperty("disabledSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether code action supports the `data` property which is
    /// preserved between a `textDocument/codeAction` and a
    /// `codeAction/resolve` request.
    /// 
    /// @since 3.16.0
    member _.DataSupport =
        match element.TryGetProperty("dataSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the client supports resolving additional code action
    /// properties via a separate `codeAction/resolve` request.
    /// 
    /// @since 3.16.0
    member _.ResolveSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("resolveSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Whether the client honors the change annotations in
    /// text edits and resource operations returned via the
    /// `CodeAction#edit` property by for example presenting
    /// the workspace edit in the user interface and asking
    /// for confirmation.
    /// 
    /// @since 3.16.0
    member _.HonorsChangeAnnotations =
        match element.TryGetProperty("honorsChangeAnnotations") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(CodeActionClientCapabilities(element))

/// The client capabilities  of a {@link CodeLensRequest}.
[<Struct>]
type CodeLensClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether code lens supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(CodeLensClientCapabilities(element))
        else Error()

/// The client capabilities of a {@link DocumentLinkRequest}.
[<Struct>]
type DocumentLinkClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether document link supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the client supports the `tooltip` property on `DocumentLink`.
    /// 
    /// @since 3.15.0
    member _.TooltipSupport =
        match element.TryGetProperty("tooltipSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "tooltipSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentLinkClientCapabilities(element))
        else Error()

[<Struct>]
type DocumentColorClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is set to `true`
    /// the client supports the new `DocumentColorRegistrationOptions` return value
    /// for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentColorClientCapabilities(element))
        else Error()

/// Client capabilities of a {@link DocumentFormattingRequest}.
[<Struct>]
type DocumentFormattingClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether formatting supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentFormattingClientCapabilities(element))
        else Error()

/// Client capabilities of a {@link DocumentRangeFormattingRequest}.
[<Struct>]
type DocumentRangeFormattingClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether range formatting supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the client supports formatting multiple ranges at once.
    /// 
    /// @since 3.18.0
    /// @proposed
    member _.RangesSupport =
        match element.TryGetProperty("rangesSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "rangesSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentRangeFormattingClientCapabilities(element))
        else Error()

/// Client capabilities of a {@link DocumentOnTypeFormattingRequest}.
[<Struct>]
type DocumentOnTypeFormattingClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether on type formatting supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DocumentOnTypeFormattingClientCapabilities(element))
        else Error()

[<Struct>]
type RenameClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether rename supports dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Client supports testing for validity of rename operations
    /// before execution.
    /// 
    /// @since 3.12.0
    member _.PrepareSupport =
        match element.TryGetProperty("prepareSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Client supports the default behavior result.
    /// 
    /// The value indicates the default behavior used by the
    /// client.
    /// 
    /// @since 3.16.0
    member _.PrepareSupportDefaultBehavior =
        match element.TryGetProperty("prepareSupportDefaultBehavior") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(enum<PrepareSupportDefaultBehavior>(prop.GetInt32()))

    /// Whether the client honors the change annotations in
    /// text edits and resource operations returned via the
    /// rename request&apos;s workspace edit by for example presenting
    /// the workspace edit in the user interface and asking
    /// for confirmation.
    /// 
    /// @since 3.16.0
    member _.HonorsChangeAnnotations =
        match element.TryGetProperty("honorsChangeAnnotations") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "prepareSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "prepareSupportDefaultBehavior" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> true)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "honorsChangeAnnotations" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(RenameClientCapabilities(element))
        else Error()

[<Struct>]
type FoldingRangeClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration for folding range
    /// providers. If this is set to `true` the client supports the new
    /// `FoldingRangeRegistrationOptions` return value for the corresponding
    /// server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The maximum number of folding ranges that the client prefers to receive
    /// per document. The value serves as a hint, servers are free to follow the
    /// limit.
    member _.RangeLimit =
        match element.TryGetProperty("rangeLimit") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetInt32())

    /// If set, the client signals that it only supports folding complete lines.
    /// If set, client will ignore specified `startCharacter` and `endCharacter`
    /// properties in a FoldingRange.
    member _.LineFoldingOnly =
        match element.TryGetProperty("lineFoldingOnly") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Specific options for the folding range kind.
    /// 
    /// @since 3.17.0
    member _.FoldingRangeKind =
        // Requires specialization: "literal"

        match element.TryGetProperty("foldingRangeKind") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Specific options for the folding range.
    /// 
    /// @since 3.17.0
    member _.FoldingRange =
        // Requires specialization: "literal"

        match element.TryGetProperty("foldingRange") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(FoldingRangeClientCapabilities(element))

[<Struct>]
type SelectionRangeClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration for selection range providers. If this is set to `true`
    /// the client supports the new `SelectionRangeRegistrationOptions` return value for the corresponding server
    /// capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(SelectionRangeClientCapabilities(element))
        else Error()

/// The publish diagnostic client capabilities.
[<Struct>]
type PublishDiagnosticsClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether the clients accepts diagnostics with related information.
    member _.RelatedInformation =
        match element.TryGetProperty("relatedInformation") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Client supports the tag property to provide meta data about a diagnostic.
    /// Clients supporting tags have to handle unknown tags gracefully.
    /// 
    /// @since 3.15.0
    member _.TagSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("tagSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    /// Whether the client interprets the version property of the
    /// `textDocument/publishDiagnostics` notification&apos;s parameter.
    /// 
    /// @since 3.15.0
    member _.VersionSupport =
        match element.TryGetProperty("versionSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Client supports a codeDescription property
    /// 
    /// @since 3.16.0
    member _.CodeDescriptionSupport =
        match element.TryGetProperty("codeDescriptionSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether code action supports the `data` property which is
    /// preserved between a `textDocument/publishDiagnostics` and
    /// `textDocument/codeAction` request.
    /// 
    /// @since 3.16.0
    member _.DataSupport =
        match element.TryGetProperty("dataSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(PublishDiagnosticsClientCapabilities(element))

/// @since 3.16.0
[<Struct>]
type CallHierarchyClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is set to `true`
    /// the client supports the new `(TextDocumentRegistrationOptions &amp; StaticRegistrationOptions)`
    /// return value for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(CallHierarchyClientCapabilities(element))
        else Error()

/// @since 3.16.0
[<Struct>]
type SemanticTokensClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is set to `true`
    /// the client supports the new `(TextDocumentRegistrationOptions &amp; StaticRegistrationOptions)`
    /// return value for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Which requests the client supports and might send to the server
    /// depending on the server&apos;s capability. Please note that clients might not
    /// show semantic tokens or degrade some of the user experience if a range
    /// or full request is advertised by the client but not provided by the
    /// server. If for example the client capability `requests.full` and
    /// `request.range` are both set to true but the server only provides a
    /// range provider the client might not render a minimap correctly or might
    /// even decide to not show any semantic tokens at all.
    member _.Requests =
        // Requires specialization: "literal"

        let prop = element.GetProperty("requests")
        prop

    /// The token types that the client supports.
    member _.TokenTypes =
        // Requires specialization: "array"

        let prop = element.GetProperty("tokenTypes")
        prop

    /// The token modifiers that the client supports.
    member _.TokenModifiers =
        // Requires specialization: "array"

        let prop = element.GetProperty("tokenModifiers")
        prop

    /// The token formats the clients supports.
    member _.Formats =
        // Requires specialization: "array"

        let prop = element.GetProperty("formats")
        prop

    /// Whether the client supports tokens that can overlap each other.
    member _.OverlappingTokenSupport =
        match element.TryGetProperty("overlappingTokenSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the client supports tokens that can span multiple lines.
    member _.MultilineTokenSupport =
        match element.TryGetProperty("multilineTokenSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the client allows the server to actively cancel a
    /// semantic token request, e.g. supports returning
    /// LSPErrorCodes.ServerCancelled. If a server does the client
    /// needs to retrigger the request.
    /// 
    /// @since 3.17.0
    member _.ServerCancelSupport =
        match element.TryGetProperty("serverCancelSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the client uses semantic tokens to augment existing
    /// syntax tokens. If set to `true` client side created syntax
    /// tokens and semantic tokens are both used for colorization. If
    /// set to `false` the client only uses the returned semantic tokens
    /// for colorization.
    /// 
    /// If the value is `undefined` then the client behavior is not
    /// specified.
    /// 
    /// @since 3.17.0
    member _.AugmentsSyntaxTokens =
        match element.TryGetProperty("augmentsSyntaxTokens") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(SemanticTokensClientCapabilities(element))

/// Client capabilities for the linked editing range request.
/// 
/// @since 3.16.0
[<Struct>]
type LinkedEditingRangeClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is set to `true`
    /// the client supports the new `(TextDocumentRegistrationOptions &amp; StaticRegistrationOptions)`
    /// return value for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(LinkedEditingRangeClientCapabilities(element))
        else Error()

/// Client capabilities specific to the moniker request.
/// 
/// @since 3.16.0
[<Struct>]
type MonikerClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether moniker supports dynamic registration. If this is set to `true`
    /// the client supports the new `MonikerRegistrationOptions` return value
    /// for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(MonikerClientCapabilities(element))
        else Error()

/// @since 3.17.0
[<Struct>]
type TypeHierarchyClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is set to `true`
    /// the client supports the new `(TextDocumentRegistrationOptions &amp; StaticRegistrationOptions)`
    /// return value for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(TypeHierarchyClientCapabilities(element))
        else Error()

/// Client capabilities specific to inline values.
/// 
/// @since 3.17.0
[<Struct>]
type InlineValueClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration for inline value providers.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InlineValueClientCapabilities(element))
        else Error()

/// Inlay hint client capabilities.
/// 
/// @since 3.17.0
[<Struct>]
type InlayHintClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether inlay hints support dynamic registration.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Indicates which properties a client can resolve lazily on an inlay
    /// hint.
    member _.ResolveSupport =
        // Requires specialization: "literal"

        match element.TryGetProperty("resolveSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(InlayHintClientCapabilities(element))

/// Client capabilities specific to diagnostic pull requests.
/// 
/// @since 3.17.0
[<Struct>]
type DiagnosticClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is set to `true`
    /// the client supports the new `(TextDocumentRegistrationOptions &amp; StaticRegistrationOptions)`
    /// return value for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// Whether the clients supports related documents for document diagnostic pulls.
    member _.RelatedDocumentSupport =
        match element.TryGetProperty("relatedDocumentSupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "relatedDocumentSupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(DiagnosticClientCapabilities(element))
        else Error()

/// Client capabilities specific to inline completions.
/// 
/// @since 3.18.0
/// @proposed
[<Struct>]
type InlineCompletionClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration for inline completion providers.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(InlineCompletionClientCapabilities(element))
        else Error()

/// Notebook specific client capabilities.
/// 
/// @since 3.17.0
[<Struct>]
type NotebookDocumentSyncClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Whether implementation supports dynamic registration. If this is
    /// set to `true` the client supports the new
    /// `(TextDocumentRegistrationOptions &amp; StaticRegistrationOptions)`
    /// return value for the corresponding server capability as well.
    member _.DynamicRegistration =
        match element.TryGetProperty("dynamicRegistration") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    /// The client supports sending execution summary data per cell.
    member _.ExecutionSummarySupport =
        match element.TryGetProperty("executionSummarySupport") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop.GetBoolean())

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "dynamicRegistration" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "executionSummarySupport" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(NotebookDocumentSyncClientCapabilities(element))
        else Error()

/// Show message request client capabilities
[<Struct>]
type ShowMessageRequestClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// Capabilities specific to the `MessageActionItem` type.
    member _.MessageActionItem =
        // Requires specialization: "literal"

        match element.TryGetProperty("messageActionItem") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(ShowMessageRequestClientCapabilities(element))

/// Client capabilities for the showDocument request.
/// 
/// @since 3.16.0
[<Struct>]
type ShowDocumentClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The client has support for the showDocument
    /// request.
    member _.Support =
        let prop = element.GetProperty("support")
        prop.GetBoolean()

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "support" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.Amongonz.LspTypes.Validation.isValidBool prop)
            end
        then Ok(ShowDocumentClientCapabilities(element))
        else Error()

/// Client capabilities specific to regular expressions.
/// 
/// @since 3.16.0
[<Struct>]
type RegularExpressionsClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The engine&apos;s name.
    member _.Engine =
        let prop = element.GetProperty("engine")
        global.Amongonz.LspTypes.LspString(prop)

    /// The engine&apos;s version.
    member _.Version =
        match element.TryGetProperty("version") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    static member Parse(element: global.System.Text.Json.JsonElement) =
        if
            true
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "engine" element
                |> global.FSharp.Core.ValueOption.exists (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
            && begin
                global.Amongonz.LspTypes.Validation.optionalProperty "version" element
                |> global.FSharp.Core.ValueOption.forall (fun prop -> global.FSharp.Core.Result.isOk (global.Amongonz.LspTypes.LspString.Parse(prop)))
            end
        then Ok(RegularExpressionsClientCapabilities(element))
        else Error()

/// Client capabilities specific to the used markdown parser.
/// 
/// @since 3.16.0
[<Struct>]
type MarkdownClientCapabilities(element: global.System.Text.Json.JsonElement) =
    member _.AsElement = element

    /// The name of the parser.
    member _.Parser =
        let prop = element.GetProperty("parser")
        global.Amongonz.LspTypes.LspString(prop)

    /// The version of the parser.
    member _.Version =
        match element.TryGetProperty("version") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(global.Amongonz.LspTypes.LspString(prop))

    /// A list of HTML tags that the client allows / supports in
    /// Markdown.
    /// 
    /// @since 3.17.0
    member _.AllowedTags =
        // Requires specialization: "array"

        match element.TryGetProperty("allowedTags") with
        | false, _ -> ValueNone
        | true, prop -> ValueSome(prop)

    static member Parse(element: global.System.Text.Json.JsonElement) =
        Ok(MarkdownClientCapabilities(element))

/// The definition of a symbol represented as one or many {@link Location locations}.
/// For most programming languages there is only one location at which a symbol is
/// defined.
/// 
/// Servers should prefer returning `DefinitionLink` over `Definition` if supported
/// by the client.
[<global.FSharp.Core.Struct>]
type Definition(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(Definition(element))

/// Information about where a symbol is defined.
/// 
/// Provides additional metadata over normal {@link Location location} definitions, including the range of
/// the defining symbol
type DefinitionLink = LocationLink

/// LSP arrays.
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type LSPArray(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "array".

    member _.AsElement = element

    static member Parse(element) = Ok(LSPArray(element))

/// The LSP any type.
/// Please note that strictly speaking a property with the value `undefined`
/// can&apos;t be converted into JSON preserving the property name. However for
/// convenience it is allowed and assumed that all these properties are
/// optional as well.
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type LSPAny(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(LSPAny(element))

/// The declaration of a symbol representation as one or many {@link Location locations}.
[<global.FSharp.Core.Struct>]
type Declaration(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(Declaration(element))

/// Information about where a symbol is declared.
/// 
/// Provides additional metadata over normal {@link Location location} declarations, including the range of
/// the declaring symbol.
/// 
/// Servers should prefer returning `DeclarationLink` over `Declaration` if supported
/// by the client.
type DeclarationLink = LocationLink

/// Inline value information can be provided by different means:
/// - directly as a text value (class InlineValueText).
/// - as a name to use for a variable lookup (class InlineValueVariableLookup)
/// - as an evaluatable expression (class InlineValueEvaluatableExpression)
/// The InlineValue types combines all inline value types into one type.
/// 
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type InlineValue(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(InlineValue(element))

/// The result of a document diagnostic pull request. A report can
/// either be a full report containing all diagnostics for the
/// requested document or an unchanged report indicating that nothing
/// has changed in terms of diagnostics in comparison to the last
/// pull request.
/// 
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type DocumentDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(DocumentDiagnosticReport(element))

[<global.FSharp.Core.Struct>]
type PrepareRenameResult(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(PrepareRenameResult(element))

/// A document selector is the combination of one or many document filters.
/// 
/// @sample `let sel:DocumentSelector = [{ language: &apos;typescript&apos; }, { language: &apos;json&apos;, pattern: &apos;**∕tsconfig.json&apos; }]`;
/// 
/// The use of a string as a document filter is deprecated @since 3.16.0.
[<global.FSharp.Core.Struct>]
type DocumentSelector(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "array".

    member _.AsElement = element

    static member Parse(element) = Ok(DocumentSelector(element))

[<global.FSharp.Core.Struct>]
type ProgressToken(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(ProgressToken(element))

/// An identifier to refer to a change annotation stored with a workspace edit.
type ChangeAnnotationIdentifier = global.Amongonz.LspTypes.LspString

/// A workspace diagnostic document report.
/// 
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type WorkspaceDocumentDiagnosticReport(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(WorkspaceDocumentDiagnosticReport(element))

/// An event describing a change to a text document. If only a text is provided
/// it is considered to be the full content of the document.
[<global.FSharp.Core.Struct>]
type TextDocumentContentChangeEvent(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(TextDocumentContentChangeEvent(element))

/// MarkedString can be used to render human readable text. It is either a markdown string
/// or a code-block that provides a language and a code snippet. The language identifier
/// is semantically equal to the optional language identifier in fenced code blocks in GitHub
/// issues. See https://help.github.com/articles/creating-and-highlighting-code-blocks/#syntax-highlighting
/// 
/// The pair of a language and a value is an equivalent to markdown:
/// ```${language}
/// ${value}
/// ```
/// 
/// Note that markdown strings will be sanitized - that means html will be escaped.
/// @deprecated use MarkupContent instead.
[<global.FSharp.Core.Struct>]
type MarkedString(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(MarkedString(element))

/// A document filter describes a top level text document or
/// a notebook cell document.
/// 
/// @since 3.17.0 - proposed support for NotebookCellTextDocumentFilter.
[<global.FSharp.Core.Struct>]
type DocumentFilter(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(DocumentFilter(element))

/// LSP object definition.
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type LSPObject(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "map".

    member _.AsElement = element

    static member Parse(element) = Ok(LSPObject(element))

/// The glob pattern. Either a string pattern or a relative pattern.
/// 
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type GlobPattern(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(GlobPattern(element))

/// A document filter denotes a document by different properties like
/// the {@link TextDocument.languageId language}, the {@link Uri.scheme scheme} of
/// its resource, or a glob-pattern that is applied to the {@link TextDocument.fileName path}.
/// 
/// Glob patterns can have the following syntax:
/// - `*` to match one or more characters in a path segment
/// - `?` to match on one character in a path segment
/// - `**` to match any number of path segments, including none
/// - `{}` to group sub patterns into an OR expression. (e.g. `**​/*.{ts,js}` matches all TypeScript and JavaScript files)
/// - `[]` to declare a range of characters to match in a path segment (e.g., `example.[0-9]` to match on `example.0`, `example.1`, …)
/// - `[!...]` to negate a range of characters to match in a path segment (e.g., `example.[!0-9]` to match on `example.a`, `example.b`, but not `example.0`)
/// 
/// @sample A language filter that applies to typescript files on disk: `{ language: &apos;typescript&apos;, scheme: &apos;file&apos; }`
/// @sample A language filter that applies to all package.json paths: `{ language: &apos;json&apos;, pattern: &apos;**package.json&apos; }`
/// 
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type TextDocumentFilter(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(TextDocumentFilter(element))

/// A notebook document filter denotes a notebook document by
/// different properties. The properties will be match
/// against the notebook&apos;s URI (same as with documents)
/// 
/// @since 3.17.0
[<global.FSharp.Core.Struct>]
type NotebookDocumentFilter(element: global.System.Text.Json.JsonElement) =
    // Requires specialization: "or".

    member _.AsElement = element

    static member Parse(element) = Ok(NotebookDocumentFilter(element))

/// The glob pattern to watch relative to the base path. Glob patterns can have the following syntax:
/// - `*` to match one or more characters in a path segment
/// - `?` to match on one character in a path segment
/// - `**` to match any number of path segments, including none
/// - `{}` to group conditions (e.g. `**​/*.{ts,js}` matches all TypeScript and JavaScript files)
/// - `[]` to declare a range of characters to match in a path segment (e.g., `example.[0-9]` to match on `example.0`, `example.1`, …)
/// - `[!...]` to negate a range of characters to match in a path segment (e.g., `example.[!0-9]` to match on `example.a`, `example.b`, but not `example.0`)
/// 
/// @since 3.17.0
type Pattern = global.Amongonz.LspTypes.LspString
