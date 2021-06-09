using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class FunctionSymbol : AnySymbol
    {
        public FunctionSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        public FunctionSymbol(string name) : base(name)
        { }

        public FunctionSymbol(string name, Scope scope) : base(name, scope)
        { }
    }
}
