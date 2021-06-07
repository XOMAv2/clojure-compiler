using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using ClojureCompiler.Generated;
using ClojureCompiler.Implementation;
using ClojureCompiler.Extensions;
using System;
using System.IO;
using System.Collections.Generic;
using ClojureCompiler.Exceptions;
using ClojureCompiler.Models;
using System.Linq;

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
  (let [a (+ 5.0 3) b (- 5 2) _ b]
    (loop [g a]
      (when `(not= g 0)
        (recur (dec g))))))

(defn argcount 
  ([] 0)
  ([x] 1)
  ([x y] 2)
  ([x y & more]
   (+ (argcount x y)
      (count more))))";

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
                //Console.WriteLine(root.ToIndentedTree(parser));
                string resourcesPath = "../../../Resources/";
                File.WriteAllText($"{resourcesPath}ParseTree.dot", root.ToDotTree());

                ClojureWalker walker = new ClojureWalker();
                walker.parser = parser;
                walker.graph = new CallGraph();
                ParseTreeWalker parseTreeWalker = new ParseTreeWalker();
                parseTreeWalker.Walk(walker, root);
                walker.graph.CreateGraphFile();

                SymbolTableVisitor<bool> symbolTableVisitor = new();
                symbolTableVisitor.Visit(root);
                File.WriteAllText($"{resourcesPath}SymbolTable.dot", symbolTableVisitor.SymbolTable.ToDot());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}
