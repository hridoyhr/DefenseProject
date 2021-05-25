using FinalProject.Models.AdminAccount;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class AdminAccountController : Controller
    {
        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminLoginModel model)
        {
            return RedirectToAction("AdminHome", "AdminDashboard");

        }
    }
}
