using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using Logic;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        private ShopLogic shopLogic;
        public HomeController()
        {
            shopLogic = new ShopLogic();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Administrator()
        {
            return View();
        }

        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
