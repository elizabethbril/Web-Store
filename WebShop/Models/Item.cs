using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Laptop> Laptops { get; set; }
        public virtual ICollection<Tablet> Tablets { get; set; }
        public virtual ICollection<SmartPhone> SmartPhones { get; set; }
        public virtual ICollection<Accessories> Accessories { get; set; }
        public virtual ICollection<PhotoTechique> PhotoTechiques { get; set; }
    }
}
