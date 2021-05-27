using FinalProject.Data;
using FinalProject.Web.Models.AdminDashboard;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Authorize]
    public class UserDashboardController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext applicationDbContext;

        public UserDashboardController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, ApplicationDbContext applicationDbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.applicationDbContext = applicationDbContext;
        }
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
        public IActionResult UserProfile()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UserProfileDetails()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var model = new StudentDetails()
            {
                Name = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FundDetails = new List<ExpenseDetails>()
                {
                    new ExpenseDetails{ Money = 23232, Category = "Education" },
                    new ExpenseDetails{ Money = 2333232, Category = "Food" },
                    new ExpenseDetails{ Money = 22, Category = "Health" },
                }
            };
            return View(model);
        }
    }
}
