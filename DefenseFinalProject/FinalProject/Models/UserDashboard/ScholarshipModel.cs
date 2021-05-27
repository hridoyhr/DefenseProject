using FinalProject.Web.Models.AdminDashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.UserDashboard
{
    public class ScholarshipModel
    {
        private int quantity;

        public ScholarshipModel(int quantity)
        {
            this.quantity = quantity;
            fundDetails = Build(quantity);
        }
        public List<ExpenseDetails> fundDetails { get; set; }

        public List<ExpenseDetails> Build(int count)
        {
            var objects = new List<ExpenseDetails>();
            for(int i = 0; i < count; i++)
            {
                objects.Add(new ExpenseDetails());
            }
            return objects;
        }
    }
}
