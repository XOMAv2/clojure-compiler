using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class NumberSymbol : AnySymbol
    {
        public NumberSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public NumberSymbol(string name) : base(name)
        { }

        public NumberSymbol(string name, Scope scope) : base(name, scope)
        { }
    }
}
