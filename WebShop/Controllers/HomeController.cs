using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Telephones()
        {
            return View();
        }

        public IActionResult Tablets()
        {
            return View();
        }

        public IActionResult PhotoTechnique()
        {
            return View();
        }

        public IActionResult Accessories()
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
