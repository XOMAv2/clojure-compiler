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
    class ClojureWalker : ClojureBaseListener
    {
        public CallGraph Graph { get; set; }

        public ClojureParser Parser { get; set; }

        private Stack<string> previousFunc = new();

        private int breckets = 0;

        private bool prevDefn = false;

        private string currentFunc = null;

        private string prevFunc = null;

        private string prevChild = null;

        private bool hadReserved = false;

        private List<string> reservedFunctions = new()
        {
            "'", "`", "quote", "syntax-quote"
        };

        public override void VisitTerminal(ITerminalNode node)
        {
            string temp = node.GetText();

            if (reservedFunctions.Contains(temp))
            {
                hadReserved = true;
                Graph.AddNode("quote");

                if (prevChild != null)
                {
                    Graph.AddEdge(prevChild, "quote");
                }
                else if (currentFunc != null)
                {
                    Graph.AddEdge(currentFunc, "quote");
                }
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
                Graph.AddNode(currentFunc);
                prevDefn = false;
            }
            else if (prevDefn && currentFunc != null)
            {
                Graph.AddNode(temp);
                Graph.AddEdge(currentFunc, temp);
                prevChild = temp;
                prevDefn = false;
            }
            else if (temp.Equals(")"))
            {
                breckets -= 1;

                if (previousFunc.Count > 0 && breckets == previousFunc.Count)
                {
                    currentFunc = previousFunc.Pop();
                }
                else if (previousFunc.Count == 0)
                {
                    currentFunc = null;
                }

                if (!hadReserved)
                {
                    prevChild = null;
                }

                hadReserved = false;
            }
        }
    }
}
