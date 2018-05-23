using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Item 
    {
        protected int Id;
        public string Description { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public int Purchases { get; set; }

        public Item(string description, int price, string name, int Id,string imageLink,int purchases)
        {
            Description = description;
            Price = price;
            Name = name;
            this.Id = Id;
            ImageLink = imageLink;
            Purchases = purchases;
        }

        public Item(Item item)
        {
            Description = item.Description;
            Price = item.Price;
            Name = item.Name;
            Id = item.getId();
            ImageLink = item.ImageLink;
            Purchases = item.Purchases;
        }

        public int getId() { return Id; }
    }
}
