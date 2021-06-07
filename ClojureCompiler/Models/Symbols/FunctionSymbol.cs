using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class FunctionSymbol : SymbolBase
    {
        public FunctionSymbol(SymbolContext context, Scope scope)
            : base(context, scope)
        { }

        public FunctionSymbol(SymbolContext context,
                              Scope scope,
                              Dictionary<string, ParserRuleContext> meta)
            : base(context, scope, meta)
        { }
    }
}
