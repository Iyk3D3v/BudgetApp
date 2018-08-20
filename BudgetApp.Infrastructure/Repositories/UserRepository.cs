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
    public class UserRepository : IUserRpository    
    {
        public UserModel Authenticate(string email, string password)
        {
            using (var context = new DataEntities())
            {
                var query = from u in context.Users
                            where email == u.email
                            where password == u.passwordHash
                            select new UserModel
                            {
                               email = u.email,
                               firstName =u.firstName,
                               lastName =u.lastName,
                               
                            };
                var result = query.FirstOrDefault() as UserModel;
                return result;

            }
        }

        public UserModel CreateUser(UserModel u)
        {
            using (var context = new DataEntities())
            {
                var user = new User
                {
                    //fill in the data from model
                    firstName = u.firstName,
                    lastName = u.lastName,
                    email =u.email
                };
                context.Users.Add(user);
                context.SaveChanges();
                u.UserId = user.UserId;
                return u;
            }
        }

        public void StorePasswordHash(int Id, string passwordHash)
        {
            using (var context = new DataEntities())
            {
                var user = context.Users.Find(Id);
                user.passwordHash = passwordHash;
                context.SaveChanges();
            }
        }

        public UserModel ValidateUser(string email)
        {
            using (var context = new DataEntities())
            {
                var query = from u in context.Users
                            where u.email == email
                            select new UserModel
                            {
                                email = u.email,
                                firstName =u.firstName,
                                lastName =u.lastName
                                
                            };
                return query as UserModel;
            }
        }
    }
}
