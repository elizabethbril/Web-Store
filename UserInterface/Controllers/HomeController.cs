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
                    break;
                case 2:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.SmartPhone)).Select(i => i).ToList();
                    break;
                case 3:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.Tablet)).Select(i => i).ToList();
                    break;
                case 4:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.PhotoTechique)).Select(i => i).ToList();
                    break;
                case 5:
                    currentItems = shopLogic.items.Where(i => i.GetType() == typeof(Logic.Accessories)).Select(i => i).ToList();
                    break;
                default:
                    return HttpNotFound();
            }
            Session["items"] = currentItems;
            return View(currentItems);


        }
        [HttpPost]
        public ActionResult Products(int price1, int price2)
        {
            currentItems = (List<Item>)Session["items"];
            return View(currentItems.Where(i=>i.Price>=price1&&i.Price<=price2).ToList());
        }
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            User user = shopLogic.FindUser(email, password);
            if (user != null)
            {
                
                Session["user"] = user;
                return View("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Signup(string email,string password,string shortname,string phoneNumber)
        {
            shopLogic.Registration(email, password, shortname, phoneNumber);
            return Login(email,password);
        }
        public ActionResult Signup()
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
        public ActionResult Exit()
        {
            Session["user"] = null;
            return View("Index");
        }
        [HttpPost]
        public ActionResult Search(string text)
        {
            List<Item> items = shopLogic.findItems(text);
            Session["items"] = items;
            return View("Products", items );
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            User user = (User)Session["user"];
            if (user != null)
            {
                shopLogic.doOrder(shopLogic.findItem(id), user);
                return View();
            }
            else
            {
                return HttpNotFound();
            }
        }
        
    }
}