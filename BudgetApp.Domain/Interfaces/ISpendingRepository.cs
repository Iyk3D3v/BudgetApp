using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Interfaces
{
    public interface ISpendingRepository
    {
        void CreateSpending(SpendingModel s);

        //to view spending based on user
        List<SpendingModel> ViewTransactionsByUser(int id);
        
         
    }
}
