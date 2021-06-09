using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class CharacterSymbol : AnySymbol
    {
        public CharacterSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        { }

        public CharacterSymbol(string name) : base(name)
        { }
    }
}
