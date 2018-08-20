using BudgetApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetApp.Domain.Models;
using BudgetApp.Infrastructure.Data;

namespace BudgetApp.Infrastructure.Repositories
{
    public class SpendingRepository : ISpendingRepository
    {
        public void CreateSpending(SpendingModel s)
        {
            using (var context = new DataEntities())
            {
                var spending = new Spending()
                {
                    UserId = s.UserId,
                    Amount = s.Amount,
                   // UserId = need to get logged in user
                    Description = s.Description
                  
                };
                context.Spendings.Add(spending);
                context.SaveChanges();


            }
        }


        public List<SpendingModel> ViewTransactionsByUser(int id)
        {
            using (var context = new DataEntities())
            {
                var query = from s in context.Spendings
                            where s.UserId == id
                            select new SpendingModel
                            {
                                Amount = s.Amount,
                                Description = s.Description
                            };

                var result = query.ToList();
                return result;
            }
        }
    }
}
