using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_MainUI.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OnAction()
        {
            TempData["Data"] = "Hello from Main UI";
            TempData.Keep();

            return RedirectToAction("Index", "AdminDemo", new { Area = "AdminModule" });
        }
    }
}