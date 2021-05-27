using FinalProject.Models.UserAccount.Scholarship;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Scholarship> Scholarships { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
    public class Scholarship
    {
        public int Id { get; set; }
        public string TypeOfScholarship { get; set; }
        public double Money { get; set; }
    }

    public class Payment
    {
        public int Id { get; set; }
        public string Details { get; set; }
    }
}
