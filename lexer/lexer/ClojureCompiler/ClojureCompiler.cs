using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using lexer.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace lexer.ClojureCompiler
{
    class ClojureCompiler
    {
        private ClojureLexer lexer { get; set; }
        private ClojureParser parser { get; set;  }
        private ClojureWalker walker { get; set;  }
        
        public void process(string input)
        {
            AntlrInputStream inputStream = new AntlrInputStream(input);
            lexer = new ClojureLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            parser = new ClojureParser(commonTokenStream);
            walker = new ClojureWalker();
            ParseTreeWalker parseTreeWalker = new ParseTreeWalker();
            parseTreeWalker.Walk(walker, parser.file());
        }
    }
}
