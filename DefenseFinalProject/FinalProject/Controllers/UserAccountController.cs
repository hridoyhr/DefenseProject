using FinalProject.Models.UserAccount.Scholarship;
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
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignInResult model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction(nameof(SignIn));
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        //Student Fund Account
        [HttpGet]
        public IActionResult ScholarshipAccount()
        {
            return View();
        }

        //Payment Option
        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }
        //User Mobile Number Change
        [HttpGet]
        public IActionResult UserChangeMobile()
        {
            return View();
        }
        //User Password Changes
        //[HttpGet]
        //public IActionResult UserPasswordChange()
        //{
        //    return View();
        //}
    }
}
