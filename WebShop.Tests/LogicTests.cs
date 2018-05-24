using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace WebShop.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void Registration()
        {
            
            //arrange
            Logic.ShopLogic logic = new Logic.ShopLogic();
            string login1 = "newuser";
            string password1 = "newpassword";
            string shortname1 = "name_surname";
            string phone1 = "380677291621";
            User newUser = new User(login1, password1, shortname1, phone1);
            //act
            logic.Registration(login1, password1, shortname1, phone1);
            //assert
            Assert.AreEqual(newUser.getLogin(), logic.users[0].getLogin());
        }

        [TestMethod]
        public void ChangeItem()
        {
            Logic.ShopLogic logic = new Logic.ShopLogic();
            logic.items.Add(new Item("My new Laptop", 456, "ASUS 456", 12345,"",0));
            logic.ChangeItem(new Item("My old Laptop", 456, "ASUS 456", 12345, "", 0));
            Assert.AreEqual(new Item("My old Laptop", 456, "ASUS 456", 12345, "", 0).getId(), logic.items[0].getId());
        }

        [TestMethod]
        public void doOrder()
        {
            Item item = new Item("My new Laptop", 456, "ASUS 456", 12345, "", 0);
            string login1 = "newuser";
            string password1 = "newpassword";
            string shortname1 = "name_surname";
            string phone1 = "380677291621";
            User newUser = new User(login1, password1, shortname1, phone1);

            Logic.ShopLogic logic = new Logic.ShopLogic();
            logic.doOrder(item, newUser);
            Order order = new Order(456789, item, newUser);

            Assert.AreEqual(order.orderId, logic.orders[0].orderId);
        }

        [TestMethod]
        public void newManager()
        {
            string login1 = "newuser";
            string password1 = "newpassword";
            string shortname1 = "name_surname";
            string phone1 = "380677291621";
            User newUser = new User(login1, password1, shortname1, phone1);

            Logic.ShopLogic logic = new Logic.ShopLogic();
            logic.users.Add(newUser);
            logic.newManager(newUser.id);

            Assert.AreEqual(newUser.getLogin(), logic.users[0].getLogin());
        }
    }

}
