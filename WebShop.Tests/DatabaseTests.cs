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
            ShopLogic logic = new ShopLogic();
            Console.WriteLine(logic.items.Where(i => i.GetType() == typeof(Logic.Laptop)).Select(i => i).ToList().Count);

        }
        [TestMethod]
        public void OperationContainerTest()
        {
           
        }
    }
}
