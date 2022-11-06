using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using DotNetJsonGraph.Model;

namespace DotNetJsonGraph.Core
{
    public class Generate
    {
        public List<Item> Items {get;set;}
        public List<Node> Nodes {get;set;}
        public Generate()
        {
            this.Items = new List<Item>();
            this.Nodes = new List<Node>();

            this.GenerateItems();
            this.GenerateNodes();
        }

        public void GenerateItems()
        {
            for(int i = 0; i < 50; i++){
                 this.Items.Add(new Item(i)); 
            }
        }

        public void GenerateNodes()
        {
            for(int index = 0; index < this.Items.Count; index++)
            {
                Item item = this.Items[index];
                Node node = new Node(){Index = index, Name = $"{item.Id}"};
                foreach(var orphan in item.Orphans){
                    node.Edges.Add(new Edge(){Source = node.Index, Target = orphan});
                }

                this.Nodes.Add(node);
            }
        }

        public List<Item> GetItems => this.Items;
        public List<Node> GetNodes => this.Nodes;
    }
}