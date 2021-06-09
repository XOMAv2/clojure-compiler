using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class SymbolSymbol : AnySymbol
    {
        public SymbolSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public SymbolSymbol(string name) : base(name)
        { }
    }
}
