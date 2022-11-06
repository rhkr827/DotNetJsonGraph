using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetJsonGraph.Model
{
    public class Node
    {
        public int Index {get;set;}
        public string? Name {get;set;}
        public List<Edge> Edges {get;set;}

        public Node()
        {
            this.Edges = new List<Edge>();
        }
    }

    public class Edge
    {
        public int Source {get;set;}
        public int Target {get;set;}
    }


}