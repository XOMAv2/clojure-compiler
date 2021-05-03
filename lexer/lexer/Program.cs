using System;
using System.Collections.Generic;
using Antlr4.Runtime;

namespace lexer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input expression: ");
                string input = Console.ReadLine();
                AntlrInputStream inputStream = new AntlrInputStream(input);
                ClojureLexer lexer = new ClojureLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                IList<IToken> tokens = new List<IToken>();
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