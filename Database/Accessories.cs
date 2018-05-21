using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Accessories: Item
    {
        public Accessories() { }
        public Accessories(string description, int price, string name) :
           base(description, price, name)
        { }
    }
}
