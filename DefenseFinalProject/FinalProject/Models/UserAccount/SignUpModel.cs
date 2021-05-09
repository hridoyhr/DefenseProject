using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.UserAccount.Scholarship
{
    public class SignUpModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Full Name")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please Enter Mobile Phone")]
        [Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Compare("PasswordConfirmation", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Password Confirmation")]
        [Display(Name = "Password Confirmation")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
    }
}
