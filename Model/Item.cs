using System.Linq;
using System;
using System.Collections.Generic;

namespace DotNetJsonGraph.Model
{
    public class Item
    {
        public int Id {get;set;}
        public List<int> Orphans {get;set;}

        public Item(int Id)
        {
            this.Id = Id;
            this.Orphans = new List<int>();

            var random = new Random();
            var range = random.Next(2,20);         
            for(int i = 0; i < range; i++){
                
                for(;;){
                    var value = random.Next(0,50);

                    if(!(this.Orphans.Contains(value) || i == value)){
                        this.Orphans.Add(value);
                        break;
                    }
                }
            }

            this.Orphans = this.Orphans.OrderBy(x=>x).ToList();
        }
    }
}