using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ClojureCompiler.Exceptions;
using ClojureCompiler.Generated;
using ClojureCompiler.Models;
using ClojureCompiler.Models.Symbols;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Implementation
{
    public class TypeResolvingVisitor : ClojureBaseVisitor<SymbolBase>
    {
        private SymbolTable symbolTable = null;

        public virtual Type Resolve(IParseTree code, SymbolTable table)
        {
            _ = code ?? throw new ArgumentNullException(nameof(code));
            _ = table ?? throw new ArgumentNullException(nameof(table));

            symbolTable = table;

            return Visit(code)?.GetType() ?? typeof(AnySymbol);
        }


        public override SymbolBase VisitString([NotNull] StringContext context) =>
            new StringSymbol(context.GetText());

        public override SymbolBase VisitCharacter([NotNull] CharacterContext context) =>
            new CharacterSymbol(context.GetText());

        public override SymbolBase VisitNumber([NotNull] NumberContext context) =>
            new NumberSymbol(context.GetText());

        public override SymbolBase VisitNil([NotNull] NilContext context) =>
            new NilSymbol(context.GetText());

        public override SymbolBase VisitSymbol([NotNull] SymbolContext context) =>
            new SymbolSymbol(context.GetText());

        public override SymbolBase VisitKeyword([NotNull] KeywordContext context) =>
            new KeywordSymbol(context.GetText());

        public override SymbolBase VisitBoolean([NotNull] BooleanContext context) =>
            new BooleanSymbol(context.GetText());

        public override SymbolBase VisitLiteral([NotNull] LiteralContext context) =>
            // According to the grammar, a literal must contain one child.
            context.children.Select(child => Visit(child)).First();

        public override SymbolBase VisitForm([NotNull] FormContext context) =>
            // According to the grammar, a form must contain one child.
            context.children.Select(child => Visit(child)).First();

        public override SymbolBase VisitVector([NotNull] VectorContext context) =>
            new VectorSymbol(context.GetText());

        public override SymbolBase VisitQuote([NotNull] QuoteContext context) =>
            Visit(context.form());

        public override SymbolBase VisitBacktick([NotNull] BacktickContext context) =>
            Visit(context.form());

        public override SymbolBase VisitReader_macro([NotNull] Reader_macroContext context) =>
            // According to the grammar, a reader_macro must contain one child.
            context.children.Select(child => Visit(child)).First();

        public override SymbolBase VisitList([NotNull] ListContext context)
        {
            if (context.forms().ChildCount == 0)
            {
                return new ListSymbol(context.GetText());
            }

            List<SymbolBase> symbols = new();

            for (int i = 0; i < context.forms().ChildCount; i++)
            {
                symbols.Add(Visit(context.forms().form(i)));
            }

            if (symbols[0] is not SymbolSymbol)
            {
                return new AnySymbol(context.GetText());
            }

            _ = (symbols[0] as SymbolSymbol) ?? throw new TypeCastException(
                $"{Regex.Replace(symbols[0].GetType().Name, "Symbol$", "")} cannot be cast to " +
                $"{Regex.Replace(typeof(FunctionSymbol).Name, "Symbol$", "")}.");

            if (symbolTable.Root.SymbolMap.ContainsKey(symbols[0].Name))
            {
                return (SymbolBase)Activator.CreateInstance(
                    ((FunctionSymbol)symbolTable.Root.SymbolMap[symbols[0].Name])
                        .Accept(symbols.Skip(1).Select(s => s.GetType()).ToList()),
                    context.GetText());
            }
            else
            {
                throw new SyntaxException(
                    $"Unable to resolve symbol: {symbols[0].Name} in this context.");
            }
        }
    }
}
