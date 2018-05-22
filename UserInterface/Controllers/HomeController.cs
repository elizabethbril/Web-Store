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
        
        public HomeController()
        {
            
            shopLogic = new ShopLogic();
            
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
                    return View(shopLogic.items.Where(i => i.GetType() == typeof(Logic.Laptop)).Select(i => i).ToList());
                case 2:
                    return View(shopLogic.items.Where(i => i.GetType() == typeof(Logic.SmartPhone)).Select(i => i).ToList());
                case 3:
                    return View(shopLogic.items.Where(i => i.GetType() == typeof(Logic.Tablet)).Select(i => i).ToList());
                case 4:
                    return View(shopLogic.items.Where(i => i.GetType() == typeof(Logic.PhotoTechique)).Select(i => i).ToList());
                case 5:
                    return View(shopLogic.items.Where(i => i.GetType() == typeof(Logic.Accessories)).Select(i => i).ToList());
                default:
                    return HttpNotFound();
            }
        
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