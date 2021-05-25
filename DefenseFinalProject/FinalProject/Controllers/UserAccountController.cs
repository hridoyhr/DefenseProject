using FinalProject.Data;
using FinalProject.Data.Migrations;
using FinalProject.Models.UserAccount.Account;
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
        private readonly ApplicationDbContext _context;

        public UserAccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SignUp(int id = 0)
        {
            if (id == 0)
                return View(new SignUpModel());
            else
                return View(_context.StudentInfo.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpModel student)
        {
            if(ModelState.IsValid)
            {
                if (student.Id == 0)
                    _context.Add(student);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SignIn));
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult SignIn()
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
        [ValidateAntiForgeryToken]
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
