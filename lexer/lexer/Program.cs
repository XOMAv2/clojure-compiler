using System;
using System.Text;
using Antlr4.Runtime;

namespace lexer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input expression.");
        
                // to type the EOF character and end the input: use CTRL+D, then press <enter>
                string input = Console.ReadLine();

                AntlrInputStream inputStream = new AntlrInputStream(input);
                ClojureLexer speakLexer = new ClojureLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(speakLexer);
                Console.WriteLine(commonTokenStream.GetNumberOfOnChannelTokens());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.ReadLine();
        }
    }
}