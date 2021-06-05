using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using ClojureCompiler.Generated;
using ClojureCompiler.Extensions;
using System;
using System.IO;

namespace ClojureCompiler
{
    class Program
    {
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
                Console.WriteLine(root.ToIndentedTree(parser));
                File.WriteAllText("../../../Resources/ParseTree.dot", root.ToDotTree());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}
