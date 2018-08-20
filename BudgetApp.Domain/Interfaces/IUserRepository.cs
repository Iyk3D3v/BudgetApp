using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Interfaces
{
    public interface IUserRpository
    {
        UserModel CreateUser(UserModel u);

        UserModel ValidateUser(string email);

        //for loggin in
        UserModel Authenticate(string email, string password);

        void StorePasswordHash(int Id, string passwordHash);

    }
}
