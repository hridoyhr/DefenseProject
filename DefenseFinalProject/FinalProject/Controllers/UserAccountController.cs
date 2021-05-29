using FinalProject.Data;
using FinalProject.Models.UserAccount.Account;
using FinalProject.Models.UserAccount.Scholarship;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Authorize]
    public class UserAccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ApplicationDbContext applicationDbContext;

        public UserAccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager, ApplicationDbContext applicationDbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.applicationDbContext = applicationDbContext;
        }
        //User Sign Up
        [AllowAnonymous]
        [HttpGet]
        public IActionResult SignUp()
        {
            if (signInManager.IsSignedIn(User))
            {
                return RedirectToAction("UserHome", "UserDashboard");
            }
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new AppUser
                {
                    UserName = model.EmailAddress,
                    Email = model.EmailAddress,
                    PhoneNumber = model.MobilePhone,
                    FullName = model.FullName
                };

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(SignIn));
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        //User Logout
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(SignIn));
        }

        [AllowAnonymous]
        //User Sign In Admin
        [HttpGet]
        public async Task<IActionResult> SignIn()
        {
            if (signInManager.IsSignedIn(User))
            {
                if(User.Identity.Name == "admin@gmail.com")
                    return RedirectToAction("AdminHome", "AdminDashboard");
                else
                    return RedirectToAction("UserHome", "UserDashboard");
            }
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.EmailAddress, model.Password, false, false);

                if (result.Succeeded)
                {
                    if(model.EmailAddress == "admin@gmail.com" && model.Password == "Admin@123")
                    {
                        return RedirectToAction("AdminHome", "AdminDashboard");
                    }
                    return RedirectToAction("UserHome", "UserDashboard");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }

        //Payment
        [HttpGet]
        public IActionResult Payment(int id)
        {
            var model = new PaymentModel();
            model.CategoryId = id;
            var scholarship = applicationDbContext.Scholarships.FirstOrDefault(x => x.Id == model.CategoryId);
            model.categoryName = scholarship != null ? scholarship.TypeOfScholarship : "";
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Payment(PaymentModel model)
        {
            if (ModelState.IsValid)
            {
                var details = JsonConvert.SerializeObject(model);
                applicationDbContext.Payments.Add(new Data.Payment() { Details = details });
                var scholarship = applicationDbContext.Scholarships.FirstOrDefault(x => x.Id == model.CategoryId);
                scholarship.Money -= model.money;
                applicationDbContext.SaveChanges();
            }
            return RedirectToAction(nameof(ScholarshipAccount));
        }

        //Scholarship Account
        [HttpGet]
        public async Task<IActionResult> ScholarshipAccount()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var scholarship = applicationDbContext.Scholarships.ToList();
            var model = new UserMobileChangeModel() { FullName = user.FullName,OldMobilePhone = user.PhoneNumber, expenseDetails = scholarship.Select(x => 
            new Web.Models.AdminDashboard.ExpenseDetails {Id = x.Id, Category = x.TypeOfScholarship, Money = x.Money }).ToList()};
            return View(model);
        }

        //User Change Mobile
        [HttpGet]
        public async Task<IActionResult> UserChangeMobile()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var model = new UserMobileChangeModel() { OldMobilePhone = user.PhoneNumber };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UserChangeMobile(UserMobileChangeModel model)
        {

            if (!ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);

                var result = await userManager.SetPhoneNumberAsync(user, model.NewMobilePhone);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View(model);
                }

                return RedirectToAction(nameof(ScholarshipAccount));
            }

            return View(model);
        }

        //User Change Password
        [HttpGet]
        public IActionResult UserPasswordChange()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserPasswordChange(UserPasswordChangeModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("UserProfile", "UserDashboard");
                }

                // ChangePasswordAsync changes the user password
                var result = await userManager.ChangePasswordAsync(user,
                    model.OldPassword, model.NewPassword);

                // The new password did not meet the complexity rules or
                // the current password is incorrect. Add these errors to
                // the ModelState and rerender ChangePassword view
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }

                // Upon successfully changing the password refresh sign-in cookie
                await signInManager.RefreshSignInAsync(user);
                return View("~/Views/UserDashboard/UserProfile.cshtml");
            }

            return View(model);
        }
    }
}
