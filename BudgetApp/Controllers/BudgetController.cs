using BudgetApp.Domain.Managers;
using BudgetApp.Domain.Models;
using BudgetApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BudgetApp.Controllers
{
    public class BudgetController : ApiController
    {
        private BudgetManager bm;
        public BudgetController()
        {
            var repo = new BudgetRepository();
            bm = new BudgetManager(repo);
        }


        [HttpPost]
        public BudgetModel CreateBudget(BudgetModel b)
        {
            bm.createBudget(b);
            return b;
        }

        [HttpGet]
        public BudgetModel GetBudget(int id)
        {
           var b =  bm.GetBudget(id);
            return b;
        }
    }
}
