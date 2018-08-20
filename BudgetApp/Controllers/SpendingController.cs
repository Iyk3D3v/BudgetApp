using BudgetApp.Domain.Interfaces;
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
    public class SpendingController : ApiController
    {
        private SpendingManager sp;
        //private SpendingRepository spending;

        public SpendingController()
        {
            var spending = new SpendingRepository();
            sp = new SpendingManager(spending);
        }

        //api for creating spending transaction
        //for dev pruposes  ill return s for now
        [HttpPost]
        public SpendingModel Create(SpendingModel s)
        {
            sp.CreateSpending(s);
            return s;
        }

        [HttpGet]
        //should be ID instead
        public List<SpendingModel> View(int id)
        {
          return sp.ViewAllSpending(id);
        }
        //once spending is created, in js, function that calls api forn creatind and viewinf speding is called
        //how to pass ID variable to the conntroller
    }
}
