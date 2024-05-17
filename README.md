# Amongonz.LspTypes

**Read-only** (for now) F# projection of the [LSP 3.17 types][] backed
by `JsonElement`: validation and traversal incur few to no allocations.
Inspired by [Corvus.JsonSchema][].

[LSP 3.17 types]: https://microsoft.github.io/language-server-protocol/specifications/lsp/3.17/specification/
[Corvus.JsonSchema]: https://github.com/corvus-dotnet/Corvus.JsonSchema

Most types are auto-generated from the official LSP meta-model,
including documentation. Particularly complex TypeScript types are
currently projected to `JsonElement`.

Future versions should enrich this mapping and support building new
values for serialization, rather than being limited to read-only access.
