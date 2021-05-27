using FinalProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Web.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AdminDashboardController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult AdminHome()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> StudentInfo()
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
