using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminUI.Areas.AdminModule.Models;
using AdminUI.Areas.AdminModule.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminUI.Areas.AdminModule.Controllers
{
    [Area("AdminModule")]
    public class AdminDemoController : Controller
    {

        private readonly IAdminRepository adminRepository = null;

        public AdminDemoController(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        [BindProperty]
        public AdminModel Admin { get; set; }

        public IActionResult Index()
        {
            var data = TempData["Data"] as String;
            return View();
        }

        [HttpPost]
        public IActionResult OnSubmit()
        {
            var flag = adminRepository?.AddUser(Admin);
            return View("Index",Admin);
        }
    }
}
