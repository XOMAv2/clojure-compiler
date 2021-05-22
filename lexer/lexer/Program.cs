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
                string input = "{:a 1, :b 2}";//Console.ReadLine();
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
                    foreach(XElement elem in root.Elements())
                    {
                        Console.WriteLine(elem.ToString());
                    }
                }
                    //ClojureParser.CharacterContext context = parser.character();
                    //ClojureBaseVisitor<String> visitor = new ClojureBaseVisitor<string>();
                    //var fl = ClojureParser.FLOAT
                    //visitor.Visit(context);

                    /*IList<IToken> tokens = new List<IToken>();
                    while (commonTokenStream.LA(1) != -1)
                    {
                        tokens.Add(commonTokenStream.LT(1));
                        commonTokenStream.Consume();
                    }

                    int n = commonTokenStream.GetNumberOfOnChannelTokens() - 1;
                    Console.WriteLine("Number tokens: " + n);
                    int k = 1;
                    foreach (IToken tok in tokens)
                    {
                        Console.WriteLine(k + " token: " + tok.Text);
                        k++;
                    }*/
                }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.ReadLine();
        }
    }
}