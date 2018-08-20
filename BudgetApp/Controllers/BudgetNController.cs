using BudgetApp.Domain.Managers;
using BudgetApp.Domain.Models;
using BudgetApp.Infrastructure.Repositories;
using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudgetApp.Controllers
{
    public class BudgetNController : Controller
    {
        private BudgetManager bm;


        public BudgetNController()
        {
            var repo = new BudgetRepository();
            bm = new BudgetManager(repo);
        }
      
        [HttpGet]
        public ActionResult CreateBudget()
        {
            return View();
        }

        [HttpPost,Authorize]
        public ActionResult CreateBudget(BudgetViewModel b)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var budget = new BudgetModel
                    {

                        salary = b.salary,
                        saving = b.saving,
                        expenditure = 0.00m,
                        UserId = b.userId,
                        DateCreated = DateTime.Now.ToString()
                    };
                    bm.createBudget(budget);

                }
                catch(Exception e)
                {
                    ModelState.AddModelError("Could not create",e.Message);
                }
                return RedirectToAction("Dashboard", "User");
            }
            return View(b);
        }

    }
}