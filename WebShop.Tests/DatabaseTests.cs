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
                
               
                  
            }
        }
        [TestMethod]
        public void UnitOfWorkTest()
        {
            ShopLogic shopLogic = new ShopLogic();
            Console.WriteLine(shopLogic.users.Count);

        }
        [TestMethod]
        public void OperationContainerTest()
        {
           
        }
    }
}
