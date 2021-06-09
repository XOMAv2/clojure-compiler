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
  (let [a (+ 5.0 3)
        b (- 5 nil)
        c (> 1 2 3)
        _ (fn [x y] nil)
        _ (fn ggg
            ([a])
            ([a b]))]
    (loop [g a]
      (when `(not= g 0)
        (recur (dec g))))))

(defn argcount 
  ([] 0)
  ([x] 1)
  ([x y] 2)
  ([x y z]
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

                string input3 = @"
(let [a b]
  (let [a b])
  (let [a b]))";

                string input4 = @"
(defn kek [a b]
  (let [a (+ 1 2)
        b (fn ([c]))]
    (loop [x a
           y 5]
      (when (not= x y)
        '(dec 4)))))";

                string input5 = @"
(let [a 5
      b a
      c nil
      d true
      ggg ""kkk""
      ggg \k])";

                AntlrInputStream inputStream = new(input);
                ClojureLexer lexer = new(inputStream);
                CommonTokenStream tokenStream = new(lexer);
                ClojureParser parser = new(tokenStream);
                IParseTree root = parser.file();
                //Console.WriteLine(root.ToIndentedTree(parser));
                string resourcesPath = "../../../Resources/";
                File.WriteAllText($"{resourcesPath}ParseTree.dot", root.ToDotTree());

                CallGraphListener callGraphaListener = new();
                callGraphaListener.Parser = parser;
                callGraphaListener.Graph = new CallGraph();
                ParseTreeWalker parseTreeWalker = new();
                parseTreeWalker.Walk(callGraphaListener, root);
                File.WriteAllText($"{resourcesPath}CallGraph.dot", callGraphaListener.Graph.ToDot());

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
