using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class ListSymbol : CollectionSymbol
    {
        public ListSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public ListSymbol(string name) : base(name)
        { }

        public ListSymbol(string name, Scope scope) : base(name, scope)
        { }
    }
}
