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
            buf += "  ranksep=.25;\n";
            buf += "  edge [arrowsize=.5]\n";
            buf += "  node [shape=circle, fontname=\"ArialNarrow\",\n";
            buf += "        fontsize=12, fixedsize=true, height=.45];\n";

            for (int i = 0; i < nodes.Count; i++)
            {
                buf += $"  \"{nodes[i]}\";\n";    
            }

            buf += "\n";
            string newBuf = "";

            for (int i = 0; i < edges.Count; i++)
            {
                newBuf += $"  \"{edges[i].Key}\" -> \"{edges[i].Value}\";\n";
            }

            Console.WriteLine(newBuf);
            buf += newBuf + "}\n";

            return buf;
        } 
    }
}
