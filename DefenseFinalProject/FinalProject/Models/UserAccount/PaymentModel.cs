using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.UserAccount.Account
{
    public class PaymentModel
    {
        public int CategoryId { get; set; }
        public string phoneNumber { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Details { get; set; }
        public string UserName { get; set; }
        public double money { get; set; }
        public string categoryName { get; set; }
    }
}
