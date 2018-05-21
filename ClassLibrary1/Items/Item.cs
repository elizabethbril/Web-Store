using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Item 
    {
<<<<<<< HEAD
        protected string type;
        protected string description;
        protected int price;
        protected string name;
        protected int Id;

        public void setDescription(string value)
        {
            description = value;
        }
=======
        protected int Id;
        public string Description { get; set; }
        public int Price { get; set; }
        public  string Name { get; set; }
        

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
            Id = item.getId();
        }

        public int getId() { return Id; }
>>>>>>> Dimolll
    }
}
