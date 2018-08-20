using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Infrastructure.Data
{
    public class Spending
    {
        [Key]
        public int SpendingId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }

        public virtual User User { get; set; }
    }
}
