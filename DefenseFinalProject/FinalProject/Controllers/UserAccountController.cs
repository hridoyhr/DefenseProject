using FinalProject.Models.UserAccount.Scholarship;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public UserAccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.FullName,
                    Email = model.EmailAddress,
                    PhoneNumber = model.MobilePhone,
                    PasswordHash = model.Password

                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("SignIn", "UserAccount");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
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
        [HttpGet]
        public IActionResult UserPasswordChange()
        {
            return View();
        }
    }
}
