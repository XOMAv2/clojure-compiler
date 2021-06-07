using System;
using System.Collections.Generic;
using ClojureCompiler.Models.Symbols;

namespace ClojureCompiler.Models
{
    public class Scope
    {
        /// <summary> Unique scope identifier. </summary>
        public Guid Guid { get; }

        /// <summary> Parent scope for current scope. </summary>
        public Scope Parent { get; }

        /// <summary> Symbol map for current scope. </summary>
        public Dictionary<string, SymbolBase> SymbolMap { get; }

        public Scope(Scope parentScope = null)
        {
            Guid = Guid.NewGuid();
            Parent = parentScope;
            SymbolMap = new();
        }

        /// <summary>
        /// Defining a new symbol from its instance for the current scope.
        /// </summary>
        /// <param name="symbol"> Symbol instance to define. </param>
        public void Define(SymbolBase symbol)
        {
            _ = symbol ?? throw new ArgumentNullException(nameof(symbol));

            if (symbol.Scope != this)
            {
                throw new ArgumentException("Scope mismatch.", nameof(symbol));
            }

            SymbolMap.Add(symbol.Name, symbol);
        }

        /// <summary>
        /// Defining a new symbol from its instance for the current scope.
        /// If symbol is already defined, it will be overridden.
        /// </summary>
        /// <param name="symbol"> Symbol instance to (re)define. </param>
        public void Redefine(SymbolBase symbol)
        {
            _ = symbol ?? throw new ArgumentNullException(nameof(symbol));

            if (symbol.Scope != this)
            {
                throw new ArgumentException("Scope mismatch.", nameof(symbol));
            }

            SymbolMap.Remove(symbol.Name);
            SymbolMap.Add(symbol.Name, symbol);
        }

        /// <summary>
        /// Looking for symbol by name in current and all enclousing scopes.
        /// </summary>
        /// <param name="name"> Symbol name. </param>
        /// <returns> Symbol with corresponding name in the nearest enclosing scope. </returns>
        public SymbolBase GetSymbol(string name)
        {
            return SymbolMap.ContainsKey(name)
                ? SymbolMap[name]
                : Parent?.GetSymbol(name);
        }
    }
}
