using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace ClojureCompiler.Extensions
{
    public static class IParseTreeExtensions
    {
        public static string ToIndentedTree(this IParseTree tree, Parser parser)
        {
            StringBuilder buf = new();
            ToIndentedRecursive(tree, buf, 0, parser.RuleNames.ToList());

            return buf.ToString();
        }

        private static void ToIndentedRecursive(IParseTree node, StringBuilder buf, int offset, List<string> ruleNames)
        {
            for (int i = 0; i < offset; i++)
            {
                buf.Append("  ");
            }

            buf.Append(Trees.GetNodeText(node, ruleNames)).Append('\n');

            if (node is ParserRuleContext prc)
            {
                if (prc.children != null)
                {
                    foreach (IParseTree child in prc.children)
                    {
                        ToIndentedRecursive(child, buf, offset + 1, ruleNames);
                    }
                }
            }
        }
    }
}
