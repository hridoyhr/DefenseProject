using FinalProject.Web.Models.AdminDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.UserAccount.Account
{
    public class UserMobileChangeModel 
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Current Phone Number")]
        public string OldMobilePhone { get; set; }

        [Required]
        [Display(Name = "New Phone Number")]
        public string NewMobilePhone { get; set; }
        public List<ExpenseDetails> expenseDetails { get; set; }
    }
}
