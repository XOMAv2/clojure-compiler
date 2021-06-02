using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using ClojureCompiler.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClojureCompiler
{
    class Program
    {
        public static string PrintSyntaxTree(Parser parser, IParseTree root)
        {
            StringBuilder buf = new();
            Recursive(root, buf, 0, parser.RuleNames.ToList());

            return buf.ToString();
        }

        private static void Recursive(IParseTree aRoot, StringBuilder buf, int offset, List<string> ruleNames)
        {
            for (int i = 0; i < offset; i++)
            {
                buf.Append("  ");
            }

            buf.Append(Trees.GetNodeText(aRoot, ruleNames)).Append('\n');

            if (aRoot is ParserRuleContext)
            {
                ParserRuleContext prc = (ParserRuleContext)aRoot;

                if (prc.children != null)
                {
                    foreach (IParseTree child in prc.children)
                    {
                        Recursive(child, buf, offset + 1, ruleNames);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                string input = @"
(defn kek [a b c]
  (let [a 5.0 b 5]
    (loop [g a]
      (when (not= g 0)
        (recur (dec g))))))";

                string input2 = @"
(defn argcount 
  ([] 0)
  ([x] 1)
  ([x y] 2)
  ([x y & more]
   (+ (argcount x y)
      (count more))))";

                AntlrInputStream inputStream = new(input);
                ClojureLexer lexer = new(inputStream);
                CommonTokenStream tokenStream = new(lexer);
                ClojureParser parser = new(tokenStream);
                IParseTree root = parser.file();
                Console.WriteLine(PrintSyntaxTree(parser, root));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }

            Console.ReadLine();
        }
    }
}
