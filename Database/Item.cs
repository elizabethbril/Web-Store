using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public abstract class Item 
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }

        public Item() { }
        public Item(string description, int price, string name, int Id)
        {
            Description = description;
            Price = price;
            Name = name;
            this.Id = Id;
        }

        public Item(Item item)
        {
            Description = item.Description;
            Price = item.Price;
            Name = item.Name;
            Id = item.Id;
        }

    }
}
