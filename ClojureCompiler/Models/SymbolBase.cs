using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models
{
    /// <summary>
    /// Represents symbol in symbol table.
    /// </summary>
    public abstract class SymbolBase
    {
        /// <summary> Unique symbol identifier. </summary>
        public Guid Guid { get; }

        /// <summary> String symbol name. </summary>
        public string Name { get; }

        /// <summary> Parse rule context in parse tree. </summary>
        public SymbolContext Context { get; }

        /// <summary> Symbol scope in code. </summary>
        public Scope Scope { get; }

        public Dictionary<string, ParserRuleContext> Meta { get; }

        /// <summary>
        /// Construct new symbol from specified rule context in stated scope with metadata.
        /// </summary>
        /// <param name="context"> Parse rule context of symbol in parse tree. </param>
        /// <param name="scope"> Symbol scope according to parse tree lookup. </param>
        /// <param name="meta"> Metadata dictionary. </param>
        public SymbolBase(SymbolContext context,
                          Scope scope,
                          Dictionary<string, ParserRuleContext> meta = null)
        {
            _ = context ?? throw new ArgumentNullException(nameof(context));
            _ = scope ?? throw new ArgumentNullException(nameof(scope));

            Guid = Guid.NewGuid();
            Name = context.GetText();
            Context = context;
            Scope = scope;
            Meta = meta ?? new();
        }
    }
}
