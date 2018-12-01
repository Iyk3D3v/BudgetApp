using BudgetApp.Domain.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Managers
{
    public class BudgetManager
    {
        private IBudgetRepository _budgetRepo;

        public BudgetManager(IBudgetRepository budgetRepo)
        {
            _budgetRepo = budgetRepo;
        }

        public void createBudget(BudgetModel b)
        {
            _budgetRepo.CreateBudget(b);
        }

        public BudgetModel  GetBudget(int id)
        {
           var budget = _budgetRepo.GetBudgetForUser(id);
            return budget;
        }
    }
}
