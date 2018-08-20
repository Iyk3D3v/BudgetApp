using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Infrastructure.Data
{
    public class DataEntities : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Budget> Budgets { get; set; }

        public DbSet<Spending> Spendings { get; set; }


    }
}
