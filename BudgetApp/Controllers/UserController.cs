using BudgetApp.Domain.Managers;
using BudgetApp.Domain.Models;
using BudgetApp.Infrastructure.Repositories;
using BudgetApp.Infrastructure.Utilities;
using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace BudgetApp.Controllers
{
    public class UserController : Controller
    {
        private UserManager um;
        
        
        public UserController()
        {
            var userRepo = new UserRepository();
            var encryption = new MD5EncryptionService();
            um = new UserManager(userRepo, encryption);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel l, string returnUrl)
        {
            if(ModelState.IsValid)
            {
                
                   var user =  um.Login(l.email, l.password);
                    if(user != null)
                    {
                        if(true)
                        {
                            var auth = HttpContext.GetOwinContext().Authentication;
                            var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Email,user.email),
                                new Claim(ClaimTypes.Name,user.firstName),
                                new Claim(ClaimTypes.PrimarySid,user.UserId.ToString())
                            };

                        var identities = new ClaimsIdentity(claims,"Cookie");
                        auth.SignIn(identities);
                        if (Url.IsLocalUrl(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        return RedirectToAction("Dashboard", "User");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Invalid Details", "Invalid Email or Password");
                    return View(l);
                    }
                }

            return View(l);
        }

        [HttpPost]
        public ActionResult Create(UserViewModel u)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var user = new UserModel
                    {
                        email = u.email,
                        firstName = u.firstName,
                        lastName = u.lastName
                    };
                    um.CreateUser(user,u.password);
                    //um.StorePassword(user.UserId, u.password);
                   
                }
                catch(Exception e)
                {
                    ModelState.AddModelError("Could not create", e.Message);
                  
                }
                return RedirectToAction("Login", "User");
            }
            return View(u);
        }

        [Authorize]
        public ActionResult CreateBudget()
        {
            //have to find a way to make redirect to dash board
            return View();
        }

        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}