using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Antlr4.Runtime;
using ClojureCompiler.Exceptions;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Models.Symbols
{
    public class FunctionSymbol : AnySymbol
    {
        /// <summary>
        /// Represents a function signature.
        /// </summary>
        /// <param name="Args">Parameter list.</param>
        /// <param name="Variadic">
        /// The last argument of the parameter list is a sequence with a variable number of elements.
        /// </param>
        /// <param name="Result">The type of the function result.</param>
        public record Signature(IList<Type> Args, bool Variadic, Type Result);

        public List<Signature> Signatures { get; }

        public int SignatureCount => Signatures.Count;

        public bool HasOverloads => Signatures.Count > 1;

        public FunctionSymbol(
            SymbolContext context,
            Scope scope,
            Dictionary<string, ParserRuleContext> meta = null)
            : base(context, scope, meta)
        {
            Signatures = new();
        }

        public FunctionSymbol(string name) : base(name)
        {
            Signatures = new();
        }

        public FunctionSymbol(string name, Scope scope) : base(name, scope)
        {
            Signatures = new();
        }

        public Type Accept(List<Type> args)
        {
            _ = args ?? throw new ArgumentNullException(nameof(args));

            var matchingSignatures = Signatures
                .OrderBy(s => s.Variadic)
                // TODO: Сигнатуры с результатом AnySymbol должны быть помещены в конец.
                .ThenBy(s => s.Args.Count)
                .Where(s => (s.Args.Count == args.Count)
                            || (s.Variadic && (s.Args.Count - 1 <= args.Count)))
                .Select(s =>
                {
                    if (s.Args.Count == args.Count)
                    {
                        return s;
                    }

                    Type variadicType = s.Args.Last();
                    List<Type> newArgs = s.Args
                        .Take(s.Args.Count - 1)
                        .Concat(Enumerable.Repeat(variadicType, args.Count - s.Args.Count + 1))
                        .ToList();

                    return s with { Args = newArgs };
                });

            if (matchingSignatures.Count() == 0)
            {
                throw new ArityException($"Wrong number of args {args.Count} passed to: {Name}.");
            }

            foreach (Signature s in matchingSignatures)
            {
                if (args.Select((arg, i) => arg.IsAssignableTo(s.Args[i])).All(e => e))
                {
                    return s.Result;
                }
            }

            string argsString = string.Join(
                " ", args.Select(arg => Regex.Replace(arg.Name, "Symbol$", "")));

            throw new TypeCastException(
                $"The function {Name} has no overload for arguments {argsString}.");
        }
    }
}