using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class CollectionSymbol : AnySymbol
    {
        public CollectionSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public CollectionSymbol(string name) : base(name)
        { }

        public CollectionSymbol(string name, Scope scope) : base(name, scope)
        { }
    }
}
