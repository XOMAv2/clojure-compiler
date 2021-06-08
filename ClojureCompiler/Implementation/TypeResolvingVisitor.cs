using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ClojureCompiler.Generated;
using ClojureCompiler.Models.Symbols;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Implementation
{
    public class TypeResolvingVisitor : ClojureBaseVisitor<Type>
    {
        public virtual Type Resolve(IParseTree code) =>
            Visit(code) ?? typeof(AnySymbol);


        public override Type VisitString([NotNull] StringContext context) =>
            typeof(StringSymbol);

        public override Type VisitCharacter([NotNull] CharacterContext context) =>
            typeof(CharacterSymbol);

        public override Type VisitNumber([NotNull] NumberContext context) =>
            typeof(NumberSymbol);

        public override Type VisitNil([NotNull] NilContext context) =>
            typeof(NilSymbol);

        public override Type VisitSymbol([NotNull] SymbolContext context) =>
            typeof(SymbolSymbol);

        public override Type VisitKeyword([NotNull] KeywordContext context) =>
            typeof(KeywordSymbol);

        public override Type VisitBoolean([NotNull] BooleanContext context) =>
            typeof(BooleanSymbol);

        public override Type VisitLiteral([NotNull] LiteralContext context) =>
            // According to the grammar, a literal must contain one child.
            context.children.Select(child => Visit(child)).First();

        public override Type VisitForm([NotNull] FormContext context) =>
            // According to the grammar, a form must contain one child.
            context.children.Select(child => Visit(child)).First();

        public override Type VisitList([NotNull] ListContext context)
        {
            List<Type> results = new();

            for (int i = 0; i < context.forms().ChildCount; i++)
            {
                results.Add(Visit(context.forms().form(i)));
            }

            return typeof(AnySymbol);
        }
    }
}
