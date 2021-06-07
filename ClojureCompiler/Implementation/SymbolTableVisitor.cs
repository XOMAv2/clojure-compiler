using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ClojureCompiler.Exceptions;
using ClojureCompiler.Generated;
using ClojureCompiler.Models;
using ClojureCompiler.Models.Symbols;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static ClojureCompiler.Generated.ClojureParser;

namespace ClojureCompiler.Implementation
{
    public class SymbolTableVisitor<T> : ClojureBaseVisitor<T>
    {
        /// <summary>
        /// Table of all symbol definitions.
        /// </summary>
        public SymbolTable SymbolTable { get; } = new();

        public override T VisitList([NotNull] ListContext context)
        {
            string firstEl = context
                .forms()
                ?.form(0)
                ?.literal()
                ?.symbol()
                ?.GetText();

            //_ = firstEl ?? throw new SyntaxException($"Can't call the {context.GetText()} funciton.");

            if (firstEl == "def")
            {
                SymbolBase sym = DefDeclaration(context, SymbolTable.Root);
                SymbolTable.Root.Redefine(sym);
                return base.VisitList(context);

            }
            //else if (firstEl == "fn")
            //{
            //    int scopeCount = FnDeclaration(context, SymbolTable);
            //    var result = base.VisitList(context);
            //    for (int i = 0; i < scopeCount; i++)
            //    {
            //        SymbolTable.PopScope();
            //    }
            //    return result;
            //}
            else if (firstEl == "defn")
            {
                int scopeCount = DefnDeclaration(context, SymbolTable);
                var result = base.VisitList(context);
                for (int i = 0; i < scopeCount; i++)
                {
                    SymbolTable.PopScope();
                }
                return result;
            }
            else if (firstEl == "let")
            {
                int scopeCount = LetDeclaration(context, SymbolTable);
                var result = base.VisitList(context);
                for (int i = 0; i < scopeCount; i++)
                {
                    SymbolTable.PopScope();
                }
                return result;
            }
            else if (firstEl == "loop")
            {
                int scopeCount = LoopDeclaration(context, SymbolTable);
                var result = base.VisitList(context);
                for (int i = 0; i < scopeCount; i++)
                {
                    SymbolTable.PopScope();
                }
                return result;
            }
            else
            {
                return base.VisitList(context);
            }
        }

        /// <returns>
        /// not null <see cref="SymbolBase" />.
        /// </returns>
        private static SymbolBase DefDeclaration([NotNull] ListContext context, Scope rootScope)
        {
            _ = rootScope ?? throw new ArgumentNullException(nameof(rootScope));

            if (rootScope.Parent != null)
            {
                throw new ArgumentException(
                    "The scope for the def declartion must be the root one.",
                    nameof(rootScope));
            }

            if (context.forms().ChildCount == 1)
            {
                throw new SyntaxException("Too few arguments to def.");
            }

            if (context.forms().ChildCount > 4)
            {
                throw new SyntaxException("Too many arguments to def.");
            }

            SymbolContext arg1 = context.forms()?.form(1)?.literal()?.symbol();

            _ = arg1 ?? throw new SyntaxException("First argument to def must be a symbol.");

            FormContext arg2 = context.forms()?.form(2);
            StringContext docString = arg2?.literal()?.@string();
            FormContext arg3 = context.forms()?.form(3);

            SymbolBase sym = (arg2, docString, arg3) switch
            {
                // Any symbol declaration.
                (null, null, null) => new AnySymbol(arg1, rootScope),

                // TODO: Type resolving.

                // Typed symbol declaration without docString.
                ({ }, null, null) => new AnySymbol(arg1, rootScope),

                // Typed symbol declaration with docString.
                ({ }, { }, { }) => new AnySymbol(
                    arg1,
                    rootScope,
                    new Dictionary<string, ParserRuleContext>() { { ":doc", docString } }),

                _ => throw new SyntaxException("Too many arguments to def"),
            };

            return sym;
        }

        ///// <returns> The number of open scopes. </returns>
        //private static int FnDeclaration([NotNull] ListContext context, SymbolTable symbolTable)
        //{
        //    _ = symbolTable ?? throw new ArgumentNullException(nameof(symbolTable));

        //    if (context.forms().ChildCount == 1 || context.forms().ChildCount == 2)
        //    {
        //        throw new SyntaxException("Too few arguments to fn.");
        //    }

        //    FormContext arg1 = context.forms()?.form(1);
        //    SymbolContext arg1Sym = arg1?.literal()?.symbol();
        //    VectorContext arg1Vec = arg1?.vector();
        //    VectorContext arg2Vec = context.forms()?.form(2)?.vector();

        //    SymbolBase sym = (arg1Sym, arg1Vec, arg2Vec) switch
        //    {
        //        ({ }, null, { }) => new FunctionSymbol(arg1Sym, scope),
        //        (null, { }, _) => null,
        //        _ => throw new SyntaxException("The params argument must be a vector."),
        //    };

        //    return sym;
        //}

        // TODO: add FnSignature into FunctionSymbol class.

        private record FnSignature (SymbolContext Symbol,
                                    StringContext Doc,
                                    int SignatureCount,
                                    bool HasOverloads);

        private static FnSignature CheckFunctionSignature([NotNull] ListContext context)
        {
            string ctor = context.forms()?.form(0)?.literal()?.symbol()?.GetText();
            FormContext arg1 = context.forms()?.form(1);
            FormContext arg2 = context.forms()?.form(2);
            FormContext arg3 = context.forms()?.form(3);

            FnSignature signature = (ctor, arg1, arg2, arg3) switch
            {
                (not ("defn" or "fn"), _, _, _) =>
                    throw new ArgumentException(null, nameof(context)),

                ("defn" , null or { }, null, null) =>
                    throw new SyntaxException("Too few arguments to defn."),

                ("fn", null, null, null) =>
                    throw new SyntaxException("Too few arguments to fn."),

                ("defn", _, _, _) when arg1?.literal()?.symbol() is null =>
                    throw new SyntaxException("First argument to defn must be a symbol."),

                // (defn kek "doc" ([])+) or (fn kek "doc" ([])+)
                _ when arg1?.literal()?.symbol() is { } sym && arg2?.literal()?.@string() is { } doc && arg3?.list() is { } =>
                    new FnSignature(sym, doc, 0, true),

                // (defn kek "doc" []) or (fn kek "doc" [])
                _ when arg1?.literal()?.symbol() is { } sym && arg2?.literal()?.@string() is { } doc && arg3?.vector() is { } =>
                    new FnSignature(sym, doc, 1, false),

                // (defn kek ([])+) or (fn kek ([])+)
                _ when arg1?.literal()?.symbol() is { } sym && arg2?.list() is { } =>
                    new FnSignature(sym, null, 0, true),

                // (defn kek []) or (fn kek [])
                _ when arg1?.literal()?.symbol() is { } sym && arg2?.vector() is { } =>
                    new FnSignature(sym, null, 1, false),

                // (fn "doc" ([])+)
                ("fn", _, _, _) when arg1?.literal()?.@string() is { } doc && arg2?.list() is { } =>
                    new FnSignature(null, doc, 0, true),

                // (fn "doc" [])
                ("fn", _, _, _) when arg1?.literal()?.@string() is { } doc && arg2?.vector() is { } =>
                    new FnSignature(null, doc, 1, false),

                // (fn ([])+)
                ("fn", _, _, _) when arg1?.list() is { } =>
                    new FnSignature(null, null, 0, true),

                // (fn [])
                ("fn", _, _, _) when arg1?.vector() is { } =>
                    new FnSignature(null, null, 1, false),

                _ => throw new SyntaxException("Incorrect function declaration."),
            };

            if (signature.HasOverloads)
            {
                int index = (signature.Symbol, signature.Doc) switch
                {
                    (null, null) => 1,
                    ({ }, null) => 2,
                    (null, { }) => 2,
                    ({ }, { }) => 3,
                };

                for (int i = index; i < context.forms().ChildCount; i++)
                {
                    VectorContext args = context.forms()?.form(i)?.list()?.forms()?.form(0)?.vector()
                        ?? throw new SyntaxException("Each overload must be a " +
                        "list with the first argument \"params\" being a vector");

                    for (int j = 0; j < args.forms().ChildCount; j++)
                    {
                        _ = args.forms()?.form(j)?.literal()?.symbol()
                            ?? throw new SyntaxException("Function arguments must be symbols.");
                    }

                    signature = signature with { SignatureCount = signature.SignatureCount + 1 };
                }
            }

            return signature;
        }

        /// <returns> The number of open scopes. </returns>
        private static int DefnDeclaration([NotNull] ListContext context, SymbolTable symbolTable)
        {
            _ = symbolTable ?? throw new ArgumentNullException(nameof(symbolTable));

            _ = symbolTable.Root ?? throw new ArgumentException(
                "The symbol table doesn't have a root scope.", nameof(symbolTable));

            FnSignature signature = CheckFunctionSignature(context);
            FunctionSymbol fnSym = signature.Doc == null
                ? new(signature.Symbol, symbolTable.Root)
                : new(signature.Symbol,
                      symbolTable.Root,
                      new Dictionary<string, ParserRuleContext>() { { ":doc", signature.Doc } });
            symbolTable.Root.Redefine(fnSym);

            if (signature.HasOverloads)
            {
                return 0;
            }
            else
            {
                int index = (signature.Symbol, signature.Doc) switch
                {
                    (null, null) => 1,
                    ({ }, null) => 2,
                    (null, { }) => 2,
                    ({ }, { }) => 3,
                };
                Scope argsScope = symbolTable.PushScope();
                VectorContext args = context.forms().form(index).vector();

                for (int i = 0; i < args.forms().ChildCount; i++)
                {
                    AnySymbol sym = new(args.forms().form(i).literal().symbol(), argsScope);
                    argsScope.Define(sym);
                }

                return 1;
            }
        }

        /// <returns> The number of open scopes. </returns>
        private static int LetDeclaration([NotNull] ListContext context, SymbolTable symbolTable)
        {
            _ = symbolTable ?? throw new ArgumentNullException(nameof(symbolTable));

            if (context.forms().ChildCount == 1 || context.forms().ChildCount == 2)
            {
                throw new SyntaxException("Too few arguments to let.");
            }

            VectorContext bindings = context.forms()?.form(1)?.vector();

            _ = bindings ?? throw new SyntaxException("A vector for let bindings is expected.");

            if (bindings.forms().ChildCount % 2 != 0)
            {
                throw new SyntaxException("An even number of forms in binding vector is expected.");
            }

            int scopeCount = bindings.forms().ChildCount / 2;

            for (int i = 0; i < scopeCount; i++)
            {
                SymbolContext left = bindings.forms().form(i * 2)?.literal()?.symbol();
                FormContext right = bindings.forms().form(i * 2 + 1);

                _ = left ?? throw new SyntaxException("Cannot bind to a non-symbol.");

                // TODO: Type resolving for right variable before creating a new scope.

                Scope scope = symbolTable.PushScope();
                scope.Define(new AnySymbol(left, scope));
            }

            return scopeCount;
        }

        private static int LoopDeclaration([NotNull] ListContext context, SymbolTable symbolTable)
        {
            _ = symbolTable ?? throw new ArgumentNullException(nameof(symbolTable));

            if (context.forms().ChildCount == 1 || context.forms().ChildCount == 2)
            {
                throw new SyntaxException("Too few arguments to loop.");
            }

            VectorContext bindings = context.forms()?.form(1)?.vector();

            _ = bindings ?? throw new SyntaxException("A vector for loop bindings is expected.");

            if (bindings.forms().ChildCount % 2 != 0)
            {
                throw new SyntaxException("An even number of forms in binding vector is expected.");
            }

            int scopeCount = bindings.forms().ChildCount / 2;

            for (int i = 0; i < scopeCount; i++)
            {
                SymbolContext left = bindings.forms().form(i * 2)?.literal()?.symbol();
                FormContext right = bindings.forms().form(i * 2 + 1);

                _ = left ?? throw new SyntaxException("Cannot bind to a non-symbol.");

                // TODO: Type resolving for right variable before creating a new scope.

                Scope scope = symbolTable.PushScope();
                scope.Define(new AnySymbol(left, scope));
            }

            return scopeCount;
        }
    }
}
