using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClojureCompiler.Extensions
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

        private string ToDot()
        {
            string buf = "";
            buf += "digraph G {\n";
            buf += "  ranksep=.25;\n";
            buf += "  edge [arrowsize=.5]\n";
            buf += "  node [shape=circle, fontname=\"ArialNarrow\",\n";
            buf += "        fontsize=12, fixedsize=true, height=.45];\n";
            buf += "  ";
            for (int i = 0; i < nodes.Count; i++)
            {
                buf += nodes[i];       
                buf += "; ";
            }
            buf += "\n";
            string newBuf = "";
            for (int i = 0; i < edges.Count; i++)
            {
                newBuf += "  ";
                newBuf += edges[i].Key;
                newBuf += " -> ";
                newBuf += edges[i].Value;
                newBuf += ";\n";
            }
            Console.WriteLine(newBuf);
            buf += newBuf + "}\n";
            return buf;
        } 
    }
}
