using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Laptop:Item
    {
        public Laptop() { }
        public Laptop(string description, int price, string name, int Id, string imageLink, int purchases) :
            base(description,price, name, Id, imageLink, purchases)
        { }
    }
}
