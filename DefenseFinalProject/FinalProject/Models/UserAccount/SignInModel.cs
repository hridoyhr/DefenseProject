using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.UserAccount.Scholarship
{
    public class SignInModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Compare("Password", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
