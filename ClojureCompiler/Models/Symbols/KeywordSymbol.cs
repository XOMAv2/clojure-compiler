using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class KeywordSymbol : AnySymbol
    {
        public KeywordSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public KeywordSymbol(string name) : base(name)
        { }

        public KeywordSymbol(string name, Scope scope) : base(name, scope)
        { }
    }
}
