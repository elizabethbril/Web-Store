using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Database;


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
                Laptop laptop = new Laptop("1", 2, "4");
                User user = new User("nestea08@yandex.ru","22222222","nestea08","0964101687");
                Order order = new Order(laptop, user);
                context.Laptops.Add(laptop);
                context.Users.Add(user);
                context.Orders.Add(order);
                context.SaveChanges();
                  
            }
        }
    }
}
