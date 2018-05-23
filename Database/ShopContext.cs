using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Database
{
   
    public class ShopContext:DbContext
    {
        public ShopContext() : base("OnlineShop")
        {

        }
       public DbSet<Item> Items { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Accessories> Accessories { get; set; }
        public DbSet<PhotoTechique> PhotoTechiques { get; set; }
        public DbSet<SmartPhone> SmartPhones { get; set; }
        public DbSet<Tablet> Tablets { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Order> Orders { get; set; }
       
    }
}
