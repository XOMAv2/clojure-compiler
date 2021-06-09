using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class AnySymbol : SymbolBase
    {
        public AnySymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public AnySymbol(string name) : base(name)
        { }

        public AnySymbol(string name, Scope scope) : base(name, scope)
        { }
    }
}
