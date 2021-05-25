using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class UserAccountController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ScholarshipAccount()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserChangeMobile()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserPasswordChange()
        {
            return View();
        }
    }
}
