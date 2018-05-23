using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Database
{

    public class ShopContext : DbContext
    {
        static ShopContext(){
            DbInitializer dbInitializer = new DbInitializer();
            dbInitializer.InitializeDatabase(new ShopContext());
        }
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
