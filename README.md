# Amongonz.LspTypes

F# projection of the [LSP 3.17 types][]. Types can be backed by
`JsonElement` instead of instanced objects, allowing validation and
traversal with few to no allocations. Design inspired by
[Corvus.JsonSchema][].

[LSP 3.17 types]: https://microsoft.github.io/language-server-protocol/specifications/lsp/3.17/specification/
[Corvus.JsonSchema]: https://github.com/corvus-dotnet/Corvus.JsonSchema

Types are auto-generated from the official LSP meta-model, including
documentation. Strings are projected to the helper type `LspString`,
which can save some allocations in certain use cases. Particularly
complex TypeScript types are currently projected to the helper type
`LspJsonBacking` until future versions improve the mapping.
