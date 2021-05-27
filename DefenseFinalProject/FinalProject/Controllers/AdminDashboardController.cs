using FinalProject.Data;
using FinalProject.Models.UserDashboard;
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
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ApplicationDbContext applicationDbContext;

        public AdminDashboardController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager, ApplicationDbContext applicationDbContext)
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
            var scholarship = applicationDbContext.Scholarships.ToList();
            var model = new StudentDetails()
            {
                Name = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FundDetails = scholarship.Select(x =>
new Web.Models.AdminDashboard.ExpenseDetails { Id = x.Id, Category = x.TypeOfScholarship, Money = x.Money }).ToList()
            };
            return PartialView(model);
        }


        [HttpGet]
        public async Task<IActionResult> StudentAccount()
        {
            var model = new StudentAccountModel();
            var user = await userManager.GetUserAsync(User);
            model.FullName = user.FullName;
            model.Email = user.Email;
            model.PhoneNumber = user.PhoneNumber;
            return View(model);
        }

        [HttpGet]
        public IActionResult Transaction()
        {
            return View();
        }

        public IActionResult BuildScholarship(int quantity)
        {
            var model = new ScholarshipModel(quantity);

            return PartialView(model.fundDetails);
        }

        public IActionResult Scholarship()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Scholarship(List<ExpenseDetails> model)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in model)
                {
                    applicationDbContext.Scholarships.Add(new Data.Scholarship 
                    {
                        TypeOfScholarship = item.Category,
                        Money = item.Money
                    });
                }
                applicationDbContext.SaveChanges();
            }
            return RedirectToAction(nameof(StudentInfo));
        }
    }
}
