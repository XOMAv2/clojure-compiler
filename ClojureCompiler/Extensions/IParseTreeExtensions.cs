using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace ClojureCompiler.Extensions
{
    public static class IParseTreeExtensions
    {
        /// <summary>
        /// Serialize parse tree to DOT format string.
        /// </summary>
        /// <param name="tree"> Instance of parse tree class implementing IParseTree interface. </param>
        public static string ToDotTree(this IParseTree tree)
        {
            StringBuilder buf = new();
            buf.AppendLine("digraph ParseTree {");
            ToDotRecursive(tree, buf);
            buf.AppendLine("}");

            return buf.ToString();
        }

        /// <summary>
        /// Serializing parse tree to DOT using recursive tree lookup.
        /// </summary>
        /// <param name="node"> Current parse tree node in lookup. </param>
        private static void ToDotRecursive(IParseTree node, StringBuilder buf)
        {
            string nodeName = node.GetType().Name.Replace("Context", string.Empty);
            string nodeHash = node.GetHashCode().ToString();

            for (int i = 0; i < node.ChildCount; i++)
            {
                string childName = node.GetChild(i).GetType().Name.Replace("Context", string.Empty);
                string childHash = node.GetChild(i).GetHashCode().ToString();
                string childText = node.GetChild(i).GetText();

                buf.AppendLine(
                    $"\"{nodeHash}\n{nodeName}\" -> \"{childHash}\n{childName}" +
                    $"{((node.GetChild(i).ChildCount == 0) ? "\nToken = \\\"" + Escape(childText) + "\\\"" : string.Empty)}\"\n");
                ToDotRecursive(node.GetChild(i), buf);
            }
        }

        /// <summary>
        /// Escape all special characters in input string.
        /// </summary>
        /// <param name="text"> Input string. </param>
        /// <returns> Formatted input string with escaped special characters. </returns>
        private static string Escape(string str)
        {
            char[] chars = new[] { '\\', '\"', '\'' };
            string result = "";

            foreach (char ch in str)
            {
                result += chars.Contains(ch) ? "\\" + ch : ch;
            }

            return result;
        }

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
