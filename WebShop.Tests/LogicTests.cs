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
            Logic.Logic logic = new Logic.Logic();
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
            Logic.Logic logic = new Logic.Logic();
            logic.items.Add(new Item("My new Laptop", 456, "ASUS 456", 12345));
            logic.ChangeItem(new Item("My old Laptop", 456, "ASUS 456", 12345));
            Assert.AreEqual(new Item("My old Laptop", 456, "ASUS 456", 12345).getId(), logic.items[0].getId());
        }

        [TestMethod]
        public void doOrder()
        {
            Item item = new Item("My new Laptop", 456, "ASUS 456", 12345);
            string login1 = "newuser";
            string password1 = "newpassword";
            string shortname1 = "name_surname";
            string phone1 = "380677291621";
            User newUser = new User(login1, password1, shortname1, phone1);

            Logic.Logic logic = new Logic.Logic();
            logic.doOrder(item, newUser, 456789);
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

            Logic.Logic logic = new Logic.Logic();
            logic.users.Add(newUser);
            logic.newManager(newUser);

            Assert.AreEqual(newUser.getLogin(), logic.users[0].getLogin());
        }
    }

}
