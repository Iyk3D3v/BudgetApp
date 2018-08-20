using BudgetApp.Domain.Interfaces;
using BudgetApp.Domain.Interfaces.Services;
using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Managers
{
    public class UserManager
    {
        // to add user, authenticate user and the cruds

        private IUserRpository _userRepo;
        private IEncryption _encrypt;
       // private IBudgetRepository _budget;
       // BudgetManager bm;
       // private ISpendingRepository _spendingRepo;
        //add encryption services

        public UserManager(IUserRpository userRepo, IEncryption encrypt)
        {
            _userRepo = userRepo;
            _encrypt = encrypt;
            //when user is created , wants to add new budget to
           // bm = new BudgetManager(_budget);
           // _spendingRepo = spendingRepo;
        }

        public void CreateUser(UserModel u,string password)
        {
           
            //chk if user exists:call maethod that 
            var user  = _userRepo.ValidateUser(u.email);

            if(user == null)
            {
                //add user
               user = _userRepo.CreateUser(u);
            }
            else
            {
                throw new Exception($"Email {u.email} already exists");
            }
            //hash password
            var passwordHash = _encrypt.Encrypt(password);

            //store password and update table
            _userRepo.StorePasswordHash(user.UserId, passwordHash);
           
        }

        public UserModel Login(string email, string password)
        {
            //first hash password
            var passwordHash = _encrypt.Encrypt(password);

            //validate email and password
            var user  =_userRepo.Authenticate(email, passwordHash);

            return user;
        }
    }
}
