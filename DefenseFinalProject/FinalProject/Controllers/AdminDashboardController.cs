using FinalProject.Data;
using FinalProject.Web.Models.AdminDashboard;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Web.Controllers
{
    [Authorize]
    public class AdminDashboardController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext applicationDbContext;

        public AdminDashboardController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, ApplicationDbContext applicationDbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public IActionResult AdminHome()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> StudentInfo()
        {
            var model = new StudentInfoModel();
            model.UserInfo = applicationDbContext.Users.Where(x => x.Email != "admin@gmail.com").ToList();
            return View(model);
        }

        public async Task<IActionResult> StudentDetails(string id)
        {
            var user = await userManager.FindByIdAsync(id);
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
            return PartialView(model);
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
