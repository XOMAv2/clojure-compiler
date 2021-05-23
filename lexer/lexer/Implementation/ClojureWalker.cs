using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace lexer.Implementation
{
    class ClojureWalker : IClojureListener
    {
        ParseTreeProperty<XElement> xml = new ParseTreeProperty<XElement>();

        public XElement Root { get; private set; }
        XElement GetXml(IParseTree ctx)
        {
            return xml.Get(ctx);
        }

        XElement GetParentXml(IParseTree ctx)
        {
            var parent = ctx.Parent;

            XElement result = GetXml(parent);

            if (result == null)
                result = GetParentXml(parent);

            return result;
        }

        private void AddValue(IParseTree context, string value)
        {
            var element = GetXml(context);
            element.Value = value;
        }

        private void AddElement(IParseTree context, string name)
        {
            XElement element = new XElement(name);
            XElement ParentElement = GetParentXml(context);
            ParentElement.Add(element);
            SetXml(context.Parent, ParentElement);
            SetXml(context, element);
        }

        void SetXml(IParseTree ctx, XElement e)
        {
            if (xml.Get(ctx) != null)
            {
                xml.RemoveFrom(ctx);
                xml.Put(ctx, e);
            }
            else
            {
                xml.Put(ctx, e);
            }           
        }
        public void EnterAny_char([NotNull] ClojureParser.Any_charContext context)
        {

            AddElement(context, "any_char");
        }

        public void EnterBacktick([NotNull] ClojureParser.BacktickContext context)
        {
            AddElement(context, "backtick");
        }

        public void EnterBign([NotNull] ClojureParser.BignContext context)
        {
            AddElement(context, "bign");
        }

        public void EnterBin([NotNull] ClojureParser.BinContext context)
        {
            AddElement(context, "bin");
        }

        public void EnterCharacter([NotNull] ClojureParser.CharacterContext context)
        {
            AddElement(context, "character");
        }

        public void EnterDeref([NotNull] ClojureParser.DerefContext context)
        {
            AddElement(context, "deref");
        }

        public void EnterDiscard([NotNull] ClojureParser.DiscardContext context)
        {
            AddElement(context, "discard");
        }

        public void EnterDispatch([NotNull] ClojureParser.DispatchContext context)
        {
            AddElement(context, "dispatch");
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void EnterFile([NotNull] ClojureParser.FileContext context)
        {
            Root = new XElement("file");
            SetXml(context, Root);
        }

        public void EnterForm([NotNull] ClojureParser.FormContext context)
        {
            AddElement(context, "form");
        }

        public void EnterForms([NotNull] ClojureParser.FormsContext context)
        {
            AddElement(context, "forms");
        }

        public void EnterGensym([NotNull] ClojureParser.GensymContext context)
        {
            AddElement(context, "gensym");
        }

        public void EnterHex([NotNull] ClojureParser.HexContext context)
        {
            AddElement(context, "hex");
        }

        public void EnterHost_expr([NotNull] ClojureParser.Host_exprContext context)
        {
            AddElement(context, "host_expr");
        }

        public void EnterKeyword([NotNull] ClojureParser.KeywordContext context)
        {
            AddElement(context, "keyword");
        }

        public void EnterLambda([NotNull] ClojureParser.LambdaContext context)
        {
            AddElement(context, "lambda");
        }

        public void EnterList([NotNull] ClojureParser.ListContext context)
        {
            AddElement(context, "list");
        }

        public void EnterLiteral([NotNull] ClojureParser.LiteralContext context)
        {
            AddElement(context, "literal");
        }

        public void EnterMacro_keyword([NotNull] ClojureParser.Macro_keywordContext context)
        {
            AddElement(context, "macro_keyword");
        }

        public void EnterMap([NotNull] ClojureParser.MapContext context)
        {
            AddElement(context, "map");
        }

        public void EnterMeta_data([NotNull] ClojureParser.Meta_dataContext context)
        {
            AddElement(context, "meta_data");
        }

        public void EnterNamed_char([NotNull] ClojureParser.Named_charContext context)
        {
            AddElement(context, "named_char");
        }

        public void EnterNil([NotNull] ClojureParser.NilContext context)
        {
            AddElement(context, "nil");
        }

        public void EnterNs_symbol([NotNull] ClojureParser.Ns_symbolContext context)
        {
            AddElement(context, "ns_symbol");
        }

        public void EnterNumber([NotNull] ClojureParser.NumberContext context)
        {
            AddElement(context, "number");
        }

        public void EnterParam_name([NotNull] ClojureParser.Param_nameContext context)
        {
            AddElement(context, "param_name");
        }

        public void EnterQuote([NotNull] ClojureParser.QuoteContext context)
        {
            AddElement(context, "quote");
        }

        public void EnterReader_macro([NotNull] ClojureParser.Reader_macroContext context)
        {
            AddElement(context, "reader_macro");
        }

        public void EnterRegex([NotNull] ClojureParser.RegexContext context)
        {
            AddElement(context, "regex");
        }

        public void EnterSet([NotNull] ClojureParser.SetContext context)
        {
            AddElement(context, "set");
        }

        public void EnterSimple_keyword([NotNull] ClojureParser.Simple_keywordContext context)
        {
            AddElement(context, "simple_keyword");
        }

        public void EnterSimple_sym([NotNull] ClojureParser.Simple_symContext context)
        {
            AddElement(context, "simple_sym");
        }

        public void EnterString([NotNull] ClojureParser.StringContext context)
        {
            AddElement(context, "string");
        }

        public void EnterSymbol([NotNull] ClojureParser.SymbolContext context)
        {
            AddElement(context, "symbol");
        }

        public void EnterTag([NotNull] ClojureParser.TagContext context)
        {
            AddElement(context, "tag");
        }

        public void EnterUnquote([NotNull] ClojureParser.UnquoteContext context)
        {
            AddElement(context, "unquote");
        }

        public void EnterUnquote_splicing([NotNull] ClojureParser.Unquote_splicingContext context)
        {
            AddElement(context, "unquote_splicing");
        }

        public void EnterU_hex_quad([NotNull] ClojureParser.U_hex_quadContext context)
        {
            AddElement(context, "u_hex_quad");
        }

        public void EnterVar_quote([NotNull] ClojureParser.Var_quoteContext context)
        {
            AddElement(context, "var_quote");
        }

        public void EnterVector([NotNull] ClojureParser.VectorContext context)
        {
            AddElement(context, "vector");
        }

        public void ExitAny_char([NotNull] ClojureParser.Any_charContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitBacktick([NotNull] ClojureParser.BacktickContext context)
        {
            
        }

        public void ExitBign([NotNull] ClojureParser.BignContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitBin([NotNull] ClojureParser.BinContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitCharacter([NotNull] ClojureParser.CharacterContext context)
        {
            
        }

        public void ExitDeref([NotNull] ClojureParser.DerefContext context)
        {
            
        }

        public void ExitDiscard([NotNull] ClojureParser.DiscardContext context)
        {
            
        }

        public void ExitDispatch([NotNull] ClojureParser.DispatchContext context)
        {
            
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void ExitFile([NotNull] ClojureParser.FileContext context)
        {
            
        }

        public void ExitForm([NotNull] ClojureParser.FormContext context)
        {
            
        }

        public void ExitForms([NotNull] ClojureParser.FormsContext context)
        {
            
        }

        public void ExitGensym([NotNull] ClojureParser.GensymContext context)
        {
            
        }

        public void ExitHex([NotNull] ClojureParser.HexContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitHost_expr([NotNull] ClojureParser.Host_exprContext context)
        {
            
        }

        public void ExitKeyword([NotNull] ClojureParser.KeywordContext context)
        {
            
        }

        public void ExitLambda([NotNull] ClojureParser.LambdaContext context)
        {
            
        }

        public void ExitList([NotNull] ClojureParser.ListContext context)
        {
            
        }

        public void ExitLiteral([NotNull] ClojureParser.LiteralContext context)
        {
            
        }

        public void ExitMacro_keyword([NotNull] ClojureParser.Macro_keywordContext context)
        {
            
        }

        public void ExitMap([NotNull] ClojureParser.MapContext context)
        {
            
        }

        public void ExitMeta_data([NotNull] ClojureParser.Meta_dataContext context)
        {
            
        }

        public void ExitNamed_char([NotNull] ClojureParser.Named_charContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitNil([NotNull] ClojureParser.NilContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitNs_symbol([NotNull] ClojureParser.Ns_symbolContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitNumber([NotNull] ClojureParser.NumberContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitParam_name([NotNull] ClojureParser.Param_nameContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitQuote([NotNull] ClojureParser.QuoteContext context)
        {
            
        }

        public void ExitReader_macro([NotNull] ClojureParser.Reader_macroContext context)
        {
            
        }

        public void ExitRegex([NotNull] ClojureParser.RegexContext context)
        {
            
        }

        public void ExitSet([NotNull] ClojureParser.SetContext context)
        {
            
        }

        public void ExitSimple_keyword([NotNull] ClojureParser.Simple_keywordContext context)
        {
            
        }

        public void ExitSimple_sym([NotNull] ClojureParser.Simple_symContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitString([NotNull] ClojureParser.StringContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitSymbol([NotNull] ClojureParser.SymbolContext context)
        {
            
        }

        public void ExitTag([NotNull] ClojureParser.TagContext context)
        {
            
        }

        public void ExitUnquote([NotNull] ClojureParser.UnquoteContext context)
        {
            
        }

        public void ExitUnquote_splicing([NotNull] ClojureParser.Unquote_splicingContext context)
        {
            
        }

        public void ExitU_hex_quad([NotNull] ClojureParser.U_hex_quadContext context)
        {
            AddValue(context, context.Start.Text);
        }

        public void ExitVar_quote([NotNull] ClojureParser.Var_quoteContext context)
        {
            
        }

        public void ExitVector([NotNull] ClojureParser.VectorContext context)
        {
            
        }

        public void VisitErrorNode(IErrorNode node)
        {
            Console.WriteLine("Visiting ErrorNode");
        }

        public void VisitTerminal(ITerminalNode node)
        {
            Console.WriteLine("Visiting Terminal");
        }
    }
}
