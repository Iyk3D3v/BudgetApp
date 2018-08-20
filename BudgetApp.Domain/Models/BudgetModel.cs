using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Models
{
    public class BudgetModel : Model
    {
        public int BudgetId { get; set; }
        public int UserId { get; set; }

        public decimal salary { get; set; }

        public decimal expenditure { get; set; }

        public decimal saving { get; set; }

        //to get the month for which the budget was made, to be taken from system times
        public string DateCreated { get; set; }

    }
}
