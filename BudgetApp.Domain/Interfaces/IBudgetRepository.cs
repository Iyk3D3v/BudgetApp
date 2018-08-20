using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Interfaces
{
    public interface IBudgetRepository
    {
        void CreateBudget(BudgetModel b);

        List<BudgetModel> ViewAllBudgetByUser(string email);//for admmin

        List<BudgetModel> ViewAllBudgets();

        BudgetModel GetBudgetForUser(int id);

        
    }
}
