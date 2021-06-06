using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClojureCompiler.Extensions
{
    class CallGraph
    {
        List<string> nodes = new List<string>();
        List<KeyValuePair<String​, String>> edges = new List<KeyValuePair<String, String>>();

        public void Edge(String​ source, String target)
        {
            edges.Add(new KeyValuePair<string, string>(source, target));
        }

        public void Node(String node)
        {
            nodes.Add(node);
        }

        public String​ ToDot()
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
            for (int i = 0; i < edges.Count; i++)
            {        
                buf += "  ";
                buf += edges[i].Key;
                buf += " -> ";
                buf += edges[i].Value;
                buf += ";\n";
            }
            buf += "}\n";
            return buf;
        } 
    }
}
