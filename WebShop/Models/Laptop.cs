using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Laptop : Item
    {
        public Laptop(string description, int price, string name, int Id) :
           base(description, price, name, Id)
        { }

      
    }
}
