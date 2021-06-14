using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class StringSymbol : AnySymbol
    {
        public StringSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public StringSymbol(string name) : base(name)
        { }

        public StringSymbol(string name, Scope scope) : base(name, scope)
        { }
    }
}
