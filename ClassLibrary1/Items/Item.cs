using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Item 
    {
        protected string type;
        protected string description;
        protected int price;
        protected string name;
        protected int Id;

        public void setDescription(string value)
        {
            description = value;
        }
    }
}
