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
    public class BudgetRepository : IBudgetRepository
    {
        public void CreateBudget(BudgetModel b)
        {
            using (var context = new DataEntities())
            {
                var budget = new Budget
                {
                    UserId = b.UserId,
                    salary = b.salary,
                    saving = b.saving,
                    expenditure = b.expenditure,
                    DateCreated = DateTime.Now.ToString()
                };
                context.Budgets.Add(budget);
                context.SaveChanges();
            }
        }

        public BudgetModel GetBudgetForUser(int id)
        {
            //throw new NotImplementedException();
            using (var context = new DataEntities())
            {
                var query1 = context.Budgets.Select(b => b.UserId == id);
                var query = from b in context.Budgets
                            where b.UserId == id
                            select b;
                            //select new BudgetModel
                            //{
                            //    salary = b.salary,
                            //    saving = b.saving,
                            //    expenditure = b.expenditure,
                            //    BudgetId = b.BudgetId
                            //};
                var result = query1 as BudgetModel;
                var result1 = query as BudgetModel;
                return result1;  
            }
        }


        public List<BudgetModel> ViewAllBudgetByUser(string email)
        {
            throw new NotImplementedException();
        }

        public List<BudgetModel> ViewAllBudgets()
        {
            throw new NotImplementedException();
        }
    }
}
