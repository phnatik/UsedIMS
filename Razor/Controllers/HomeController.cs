using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Collection()
        {
            Product[] products =
            {
                new Product { Name = "Bananas", Price = 1.46M },
                new Product { Name = "Apples", Price = 1.00M },
                new Product { Name = "Oranges", Price = 1.20M },
                new Product { Name = "Kiwis", Price = 1.76M },
            };
            return View(products);
        }

       
    }
}
