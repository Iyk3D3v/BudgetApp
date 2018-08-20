using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Models
{
    public class SpendingModel : Model
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }

        public string Description { get; set; }

    }
}
