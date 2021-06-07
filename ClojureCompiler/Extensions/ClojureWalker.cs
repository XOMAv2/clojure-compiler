using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ClojureCompiler.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClojureCompiler.Extensions
{
    class ClojureWalker : IClojureListener
    {
        public CallGraph graph { get; set; }

        public ClojureParser parser { get; set; }

        private Stack<String> previousFunc = new Stack<string>();

        private int breckets = 0;

        private bool prevDefn = false;

        private String currentFunc = null;

        private String prevFunc = null;

        private String prevChild = null;

        private bool hadReserved = false;

        private List<String> reservedFunctions = new List<string>() { 
            "'", "`", "quote", "syntax-quote"
        };
        public void EnterAny_char([NotNull] ClojureParser.Any_charContext context)
        {
            
        }

        public void EnterBacktick([NotNull] ClojureParser.BacktickContext context)
        {
            
        }

        public void EnterBign([NotNull] ClojureParser.BignContext context)
        {
            
        }

        public void EnterBin([NotNull] ClojureParser.BinContext context)
        {
            
        }

        public void EnterCharacter([NotNull] ClojureParser.CharacterContext context)
        {
            
        }

        public void EnterDeref([NotNull] ClojureParser.DerefContext context)
        {
            
        }

        public void EnterDiscard([NotNull] ClojureParser.DiscardContext context)
        {
            
        }

        public void EnterDispatch([NotNull] ClojureParser.DispatchContext context)
        {
            
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {           
        }

        public void EnterFile([NotNull] ClojureParser.FileContext context)
        {
            
        }

        public void EnterForm([NotNull] ClojureParser.FormContext context)
        {
            
        }

        public void EnterForms([NotNull] ClojureParser.FormsContext context)
        {
            
        }

        public void EnterGensym([NotNull] ClojureParser.GensymContext context)
        {
            
        }

        public void EnterHex([NotNull] ClojureParser.HexContext context)
        {
            
        }

        public void EnterHost_expr([NotNull] ClojureParser.Host_exprContext context)
        {
            
        }

        public void EnterKeyword([NotNull] ClojureParser.KeywordContext context)
        {
            
        }

        public void EnterLambda([NotNull] ClojureParser.LambdaContext context)
        {
            
        }

        public void EnterList([NotNull] ClojureParser.ListContext context)
        {
            
        }

        public void EnterLiteral([NotNull] ClojureParser.LiteralContext context)
        {
            
        }

        public void EnterMacro_keyword([NotNull] ClojureParser.Macro_keywordContext context)
        {
            
        }

        public void EnterMap([NotNull] ClojureParser.MapContext context)
        {
            
        }

        public void EnterMeta_data([NotNull] ClojureParser.Meta_dataContext context)
        {
            
        }

        public void EnterNamed_char([NotNull] ClojureParser.Named_charContext context)
        {
            
        }

        public void EnterNil([NotNull] ClojureParser.NilContext context)
        {
            
        }

        public void EnterNs_symbol([NotNull] ClojureParser.Ns_symbolContext context)
        {
            
        }

        public void EnterNumber([NotNull] ClojureParser.NumberContext context)
        {
            
        }

        public void EnterParam_name([NotNull] ClojureParser.Param_nameContext context)
        {
            
        }

        public void EnterQuote([NotNull] ClojureParser.QuoteContext context)
        {
            
        }

        public void EnterReader_macro([NotNull] ClojureParser.Reader_macroContext context)
        {
            
        }

        public void EnterRegex([NotNull] ClojureParser.RegexContext context)
        {
            
        }

        public void EnterSet([NotNull] ClojureParser.SetContext context)
        {
            
        }

        public void EnterSimple_keyword([NotNull] ClojureParser.Simple_keywordContext context)
        {
            
        }

        public void EnterSimple_sym([NotNull] ClojureParser.Simple_symContext context)
        {
            
        }

        public void EnterString([NotNull] ClojureParser.StringContext context)
        {
            
        }

        public void EnterSymbol([NotNull] ClojureParser.SymbolContext context)
        {
            
        }

        public void EnterTag([NotNull] ClojureParser.TagContext context)
        {
            
        }

        public void EnterUnquote([NotNull] ClojureParser.UnquoteContext context)
        {
            
        }

        public void EnterUnquote_splicing([NotNull] ClojureParser.Unquote_splicingContext context)
        {
            
        }

        public void EnterU_hex_quad([NotNull] ClojureParser.U_hex_quadContext context)
        {
            
        }

        public void EnterVar_quote([NotNull] ClojureParser.Var_quoteContext context)
        {
            
        }

        public void EnterVector([NotNull] ClojureParser.VectorContext context)
        {
            
        }

        public void ExitAny_char([NotNull] ClojureParser.Any_charContext context)
        {
            
        }

        public void ExitBacktick([NotNull] ClojureParser.BacktickContext context)
        {
            
        }

        public void ExitBign([NotNull] ClojureParser.BignContext context)
        {
            
        }

        public void ExitBin([NotNull] ClojureParser.BinContext context)
        {
            
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
            
        }

        public void ExitNil([NotNull] ClojureParser.NilContext context)
        {
            
        }

        public void ExitNs_symbol([NotNull] ClojureParser.Ns_symbolContext context)
        {
            
        }

        public void ExitNumber([NotNull] ClojureParser.NumberContext context)
        {
            
        }

        public void ExitParam_name([NotNull] ClojureParser.Param_nameContext context)
        {
            
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
            
        }

        public void ExitString([NotNull] ClojureParser.StringContext context)
        {
            
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
            
        }

        public void ExitVar_quote([NotNull] ClojureParser.Var_quoteContext context)
        {
            
        }

        public void ExitVector([NotNull] ClojureParser.VectorContext context)
        {
            
        }

        public void VisitErrorNode(IErrorNode node)
        {
            
        }

        public void VisitTerminal(ITerminalNode node)
        {
            String temp = node.GetText();
            if (reservedFunctions.Contains(temp))
            {
                hadReserved = true;
                graph.Node("quote");
                if (prevChild != null)
                    graph.Edge(prevChild, "quote");
                else if (currentFunc != null)
                    graph.Edge(currentFunc, "quote");
            }            
            else if (temp.Equals("(") && !hadReserved)
            {
                breckets += 1;
                if (prevChild != null)
                {
                    previousFunc.Push(currentFunc);
                    currentFunc = prevChild;
                }
                prevDefn = true;
            }
            else if (prevDefn && currentFunc == null)
            {
                currentFunc = temp;
                graph.Node(currentFunc);
                prevDefn = false;
            }
            else if (prevDefn && currentFunc != null)
            {
                graph.Node(temp);
                graph.Edge(currentFunc, temp);
                prevChild = temp;
                prevDefn = false;
            }
            else if (temp.Equals(")"))
            {
                breckets -= 1;
                if (previousFunc.Count > 0 && breckets == previousFunc.Count)
                    currentFunc = previousFunc.Pop();
                else if (previousFunc.Count == 0)
                    currentFunc = null;
                if (!hadReserved)
                    prevChild = null;
                hadReserved = false;
            }
        }
    }
}
