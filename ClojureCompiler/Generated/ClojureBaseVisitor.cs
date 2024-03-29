//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Clojure.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ClojureCompiler.Generated
{
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;
    using IToken = Antlr4.Runtime.IToken;
    using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

    /// <summary>
    /// This class provides an empty implementation of <see cref="IClojureVisitor{Result}"/>,
    /// which can be extended to create a visitor which only needs to handle a subset
    /// of the available methods.
    /// </summary>
    /// <typeparam name="Result">The return type of the visit operation.</typeparam>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
    [System.Diagnostics.DebuggerNonUserCode]
    [System.CLSCompliant(false)]
    public partial class ClojureBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IClojureVisitor<Result>
    {
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.file"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitFile([NotNull] ClojureParser.FileContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.form"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitForm([NotNull] ClojureParser.FormContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.forms"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitForms([NotNull] ClojureParser.FormsContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.list"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitList([NotNull] ClojureParser.ListContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.vector"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitVector([NotNull] ClojureParser.VectorContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.map"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitMap([NotNull] ClojureParser.MapContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.set"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitSet([NotNull] ClojureParser.SetContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.reader_macro"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitReader_macro([NotNull] ClojureParser.Reader_macroContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.quote"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitQuote([NotNull] ClojureParser.QuoteContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.backtick"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitBacktick([NotNull] ClojureParser.BacktickContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.unquote"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitUnquote([NotNull] ClojureParser.UnquoteContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.unquote_splicing"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitUnquote_splicing([NotNull] ClojureParser.Unquote_splicingContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.tag"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitTag([NotNull] ClojureParser.TagContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.deref"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitDeref([NotNull] ClojureParser.DerefContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.gensym"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitGensym([NotNull] ClojureParser.GensymContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.lambda"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitLambda([NotNull] ClojureParser.LambdaContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.meta_data"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitMeta_data([NotNull] ClojureParser.Meta_dataContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.var_quote"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitVar_quote([NotNull] ClojureParser.Var_quoteContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.host_expr"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitHost_expr([NotNull] ClojureParser.Host_exprContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.discard"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitDiscard([NotNull] ClojureParser.DiscardContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.dispatch"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitDispatch([NotNull] ClojureParser.DispatchContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.regex"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitRegex([NotNull] ClojureParser.RegexContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.literal"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitLiteral([NotNull] ClojureParser.LiteralContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.boolean"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitBoolean([NotNull] ClojureParser.BooleanContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.string"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitString([NotNull] ClojureParser.StringContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.hex"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitHex([NotNull] ClojureParser.HexContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.bin"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitBin([NotNull] ClojureParser.BinContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.bign"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitBign([NotNull] ClojureParser.BignContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.number"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitNumber([NotNull] ClojureParser.NumberContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.character"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCharacter([NotNull] ClojureParser.CharacterContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.named_char"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitNamed_char([NotNull] ClojureParser.Named_charContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.any_char"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitAny_char([NotNull] ClojureParser.Any_charContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.u_hex_quad"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitU_hex_quad([NotNull] ClojureParser.U_hex_quadContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.nil"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitNil([NotNull] ClojureParser.NilContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.keyword"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitKeyword([NotNull] ClojureParser.KeywordContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.simple_keyword"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitSimple_keyword([NotNull] ClojureParser.Simple_keywordContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.macro_keyword"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitMacro_keyword([NotNull] ClojureParser.Macro_keywordContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.symbol"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitSymbol([NotNull] ClojureParser.SymbolContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.simple_sym"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitSimple_sym([NotNull] ClojureParser.Simple_symContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.ns_symbol"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitNs_symbol([NotNull] ClojureParser.Ns_symbolContext context) => VisitChildren(context);
        /// <summary>
        /// Visit a parse tree produced by <see cref="ClojureParser.param_name"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitParam_name([NotNull] ClojureParser.Param_nameContext context) => VisitChildren(context);
    }
} // namespace ClojureCompiler.Generated
