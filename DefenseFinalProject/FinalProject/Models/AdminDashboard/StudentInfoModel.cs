using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Web.Models.AdminDashboard
{
    public class StudentInfoModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Display(Name ="Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
