using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Infrastructure.Data
{
   public class Budget
    {
        [Key]
        public int BudgetId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public decimal salary { get; set; }

        public decimal expenditure { get; set; }
        //total money spent, whic is an accumulation of money spent from spendind table

        public decimal saving { get; set; }

         //to get the month for which the budget was made, to be taken from system times, also calculates 30 days from then
         //and budget expires or so
        public string DateCreated { get; set; }

        public virtual User User { get; set; }
    }

}
