using BudgetApp.Domain.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Managers
{
    public class SpendingManager
    {
        private ISpendingRepository _spending;

        public SpendingManager(ISpendingRepository spending)
        {
            _spending = spending;
        }

        public void CreateSpending(SpendingModel s)
        {
            _spending.CreateSpending(s);
        }

        public List<SpendingModel> ViewAllSpending(int id)
        {
            return _spending.ViewTransactionsByUser(id);
        }
    }
}
