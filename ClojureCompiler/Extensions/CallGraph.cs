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

        public void CreateGraphFile()
        {
            String fileContent = ToDot();
            String filename = "callgraph.dot";
            File.WriteAllText(filename, fileContent);

        }


        private String​ ToDot()
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
