using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClojureCompiler.Models
{
    class CallGraph
    {
        private List<string> nodes = new();

        private List<KeyValuePair<string, string>> edges = new();

        public void AddEdge(string source, string target)
        {
            edges.Add(new KeyValuePair<string, string>(source, target));
        }

        public void AddNode(string node)
        {
            nodes.Add(node);
        }

        public string ToDot()
        {
            string buf = "digraph CallGraph {\n";

            for (int i = 0; i < nodes.Count; i++)
            {
                buf += $"\"{nodes[i]}\";\n";    
            }

            buf += "\n";
            string newBuf = "";

            for (int i = 0; i < edges.Count; i++)
            {
                newBuf += $"\"{edges[i].Key}\" -> \"{edges[i].Value}\";\n";
            }

            //Console.WriteLine(newBuf);
            buf += newBuf + "}\n";

            return buf;
        } 
    }
}
