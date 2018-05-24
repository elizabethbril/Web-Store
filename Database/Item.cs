using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database
{
    public class Item 
    {
       // [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string imageLink { get; set; }
        public int Views { get; set; }
        public Item() { }
        public Item(string description, int price, string name,string imageLink, int Views)
        {
            Description = description;
            Price = price;
            Name = name;
            this.imageLink = imageLink;
            this.Views = Views;

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
