using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class UserDashboardController : Controller
    {
        [HttpGet]
        public IActionResult UserHome()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ScholarshipDetails()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StudentProfile()
        {
            return View();
        }




    }
}
