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
        public Generate()
        {
            this.Items = new List<Item>();

            for(int i = 0; i < 50; i++){
                 this.Items.Add(new Item(i)); 
            }
        }
    }
}