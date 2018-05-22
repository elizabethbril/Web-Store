using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Database;
using Logic;


namespace WebShop.Tests
{
    [TestClass]
    public class DatabaseTests
    {
        
        [TestMethod]
        public void AddItemTest()
        {
            using (ShopContext context=new ShopContext())
            {
                Database.Laptop laptop = new Database.Laptop("1", 2, "4");
                Database.User user = new Database.User("nestea08@yandex.ru","22222222","nestea08","0964101687");
                Database.Order order = new Database.Order(laptop, user);
                context.Laptops.Add(laptop);
                context.Users.Add(user);
                context.Orders.Add(order);
                context.SaveChanges();
                  
            }
        }
        [TestMethod]
        public void UnitOfWorkTest()
        {
            using (ShopContext context = new ShopContext())
            {
                AutoMapper.Initialize();
                UnitOfWork UoW = new UnitOfWork(context, new ContextRepository<Database.User>(context),
                    new ContextRepository<Database.Manager>(context), new ContextRepository<Database.Admin>(context),
                    new ContextRepository<Database.Laptop>(context), new ContextRepository<Database.Accessories>(context),
                    new ContextRepository<Database.PhotoTechique>(context), new ContextRepository<Database.SmartPhone>(context),
                    new ContextRepository<Database.Tablet>(context), new ContextRepository<Database.Order>(context));
                LaptopOperations laptop = new LaptopOperations(UoW);
                List<Logic.Laptop> laptops = laptop.GetLaptop();
                foreach (Logic.Laptop l in laptops)
                {
                    Console.WriteLine(l.getId() + " " + l.Name + " " + l.Description);
                }
            }

        }
    }
}
