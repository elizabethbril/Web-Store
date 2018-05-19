using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebShop.Models
{
    public class Laptop: Item
    {
        public LaptopType laptopType{ get; set; }
        public enum LaptopType
        {
            Acer, Lenovo, ASUS, HP, MacBook, Dell, MSI
        }

    }

  
}
