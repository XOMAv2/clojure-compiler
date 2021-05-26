using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using lexer.Implementation;

namespace lexer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.Write("Input expression: ");
                string input = "(defn kek [a b c] (let [a 5.0 b 5] (loop [g a] (when (not= g 0) (recur (dec g))))))";//(defn argcount ([] 0) ([x] 1) ([x y] 2) ([x y & more](+(argcount x y)(count more))))";//Console.ReadLine();
                AntlrInputStream inputStream = new AntlrInputStream(input);
                ClojureLexer lexer = new ClojureLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                ClojureParser parser = new ClojureParser(commonTokenStream);
                IParseTree tree = parser.file();
                ParseTreeWalker walker = new ParseTreeWalker();
                ClojureWalker clojureWalker = new ClojureWalker();
                walker.Walk(clojureWalker, tree);
                XElement root = clojureWalker.Root;
                using (StringWriter sw = new StringWriter())
                {
                    root.Save(sw);
                    Console.WriteLine(sw.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.ReadLine();
        }
    }
}