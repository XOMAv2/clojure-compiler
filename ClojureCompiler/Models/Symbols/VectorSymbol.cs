using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class VectorSymbol : CollectionSymbol
    {
        public VectorSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public VectorSymbol(string name) : base(name)
        { }

        public VectorSymbol(string name, Scope scope) : base(name, scope)
        { }
    }
}
