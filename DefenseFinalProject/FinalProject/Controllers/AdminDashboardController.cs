using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Web.Controllers
{
    public class AdminDashboardController : Controller
    {
        [HttpGet]
        public IActionResult AdminHome()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StudentInfo()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StudentAccount()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Transaction()
        {
            return View();
        }
    }
}
