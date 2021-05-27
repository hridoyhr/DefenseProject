using FinalProject.Models.UserAccount.Scholarship;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Web.Models.AdminDashboard
{
    public class StudentInfoModel
    {
        public List<IdentityUser> UserInfo { get; set; }
    }

    public class StudentDetails
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<ExpenseDetails> FundDetails { get; set; }
    }
    public class ExpenseDetails
    {
        public string Category { get; set; }
        public double Money { get; set; }
        public int Id { get; set; }
    }
}
