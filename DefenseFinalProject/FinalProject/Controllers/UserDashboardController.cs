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
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ApplicationDbContext applicationDbContext;

        public UserDashboardController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager, ApplicationDbContext applicationDbContext)
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
            var scholarship = applicationDbContext.Scholarships.ToList();
            var model = new StudentDetails()
            {
                Name = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FundDetails = scholarship.Select(x =>
                new Web.Models.AdminDashboard.ExpenseDetails { Id = x.Id, Category = x.TypeOfScholarship, Money = x.Money }).ToList()
            };
            return View(model);
        }
    }
}
