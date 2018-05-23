using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;

namespace UserInterface.Controllers
{
    public class HomeController : Controller
    {
        private ShopLogic shopLogic;
        List<Item> currentItems;
        public HomeController()
        {
            
            shopLogic = new ShopLogic();
            currentItems = shopLogic.items;

        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Products(int type)
        {
            switch (type)
            {
                case 1:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.Laptop)).Select(i => i).ToList();
                    return View(currentItems);
                case 2:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.SmartPhone)).Select(i => i).ToList();
                    return View(currentItems);
                case 3:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.Tablet)).Select(i => i).ToList();
                    return View(currentItems);
                case 4:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.PhotoTechique)).Select(i => i).ToList();
                    return View(currentItems);
                case 5:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.Accessories)).Select(i => i).ToList();
                    return View(currentItems);
                default:
                    return HttpNotFound();
            }
        
        }
        [HttpPost]
        public ActionResult Products(int price1,int price2)
        {
            
            return View(currentItems.Select(i=>i).ToList());
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Administrator()
        {
            return View();
        }

        public ActionResult Manager()
        {
            return View();
        }

        
    }
}