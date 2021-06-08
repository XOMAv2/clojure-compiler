using ClojureCompiler.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClojureCompiler.Models
{
    public class SymbolTable
    {
        /// <summary> Symbol table unique identifier. </summary>
        public Guid Guid { get; }

        /// <summary> Scope stack using in tree lookup. </summary>
        private Stack<Scope> _scopeStack;

        /// <summary>
        /// List of all scopes in program extracting during tree lookup.
        /// </summary>
        public List<Scope> Scopes { get; }

        /// <returns>
        /// Root scope or null.
        /// </returns>
        public Scope Root => Scopes.FirstOrDefault();

        public SymbolTable()
        {
            Guid = Guid.NewGuid();
            _scopeStack = new();
            Scopes = new();

            Scope root = new(null);
            _scopeStack.Push(root);
            Scopes.Add(root);
        }

        /// <summary>
        /// Create new scope and push it in scope stack and add it in list of all program scopes.
        /// </summary>
        /// <returns> Newly created scope. </returns>
        public Scope PushScope()
        {
            Scope enclosingScope = _scopeStack.Peek();
            Scope scope = new(enclosingScope);

            _scopeStack.Push(scope);
            Scopes.Add(scope);

            return scope;
        }

        /// <summary>
        /// Push existing scope to scope stack and add it in list of all program scopes.
        /// Top scope in stack will be used as enclosing for newly added scope. 
        /// </summary>
        /// <param name="scope"> Scope instance. </param>
        public void PushScope(Scope scope)
        {
            _ = scope ?? throw new ArgumentNullException(nameof(scope));

            if (scope.Parent != _scopeStack.Peek())
            {
                throw new ArgumentException("Scope mismatch.", nameof(scope));
            }

            _scopeStack.Push(scope);
            Scopes.Add(scope);
        }

        /// <summary>
        /// Extract top scope from stack.
        /// </summary>
        /// <returns> Popped <see cref="Scope" /> or <see langword="null" /> if stack is empty. </returns>
        public Scope PopScope() => _scopeStack.TryPop(out Scope sp) ? sp : null;

        /// <summary>
        /// Get current top element of scope stack.
        /// </summary>
        /// <returns> Top <see cref="Scope" /> in scope stack or <see langword="null" /> if stack is empty. </returns>
        public Scope CurrentScope => _scopeStack.TryPeek(out Scope sp) ? sp : null;

        /// <summary>
        /// Get scope from stack by its unique identifier.
        /// </summary>
        /// <param name="guid"> Scope identifier. </param>
        /// <returns>
        /// <see cref="Scope" /> instance with specified identifier or <see langword="null" /> if not found.
        /// </returns>
        public Scope GetScope(Guid guid)
        {
            return _scopeStack.SingleOrDefault(s => s.Guid == guid);
        }

        public string ToDot()
        {
            string buf = "digraph SymbolTable {\n";

            foreach (Scope scope in Scopes)
            {
                var symDefs = scope.SymbolMap.Keys.Select(symName =>
                {
                    string tmp = scope.SymbolMap[symName].GetType().Name;
                    return $"{Regex.Replace(tmp, "Symbol$", string.Empty)} {symName};";
                });
                buf += $"\"{scope.Guid}\" [label=\"{string.Join(" \n", symDefs)}\" shape=\"box\"]\n";
            }

            foreach (Scope scope in Scopes)
            {
                if (scope.Parent != null)
                {
                    buf += $"\"{scope.Parent?.Guid}\" -> \"{scope.Guid}\"\n";
                }
            }

            buf += "}\n";

            return buf;
        }
    }
}
