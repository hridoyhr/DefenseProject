using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Web.Models.AdminDashboard
{
    public class AdminHomeModel
    {
        

        [Display(Name ="Student Information")]
        public string StudentInfo { get; set; }

        [Display(Name ="Student Accounts")]
        public string StudentAccounts { get; set; }

        public string Transaction { get; set; }

    }
}
