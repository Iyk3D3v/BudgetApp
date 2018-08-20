using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Infrastructure.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string email { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string passwordHash { get; set; }

        public virtual ICollection<Budget> Budget { get; set; } = new HashSet<Budget>();

        public virtual ICollection<Spending> Spending { get; set; } = new HashSet<Spending>();
      }
}
