using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsedIMS.Models;

namespace UsedIMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AnotherAction()
        {
            return View();
        }

        public IActionResult AnotherView()
        {
            return View("SomeView");
        }
    }
}
