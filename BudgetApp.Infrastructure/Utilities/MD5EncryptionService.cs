using BudgetApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Infrastructure.Utilities
{
    public class MD5EncryptionService : IEncryption
    {
        public string Encrypt(string password)
        {
            return
              System.Security
                  .Cryptography.MD5.Create()
                  .ComputeHash(Encoding.ASCII.GetBytes(password))
                  .Select(x => x.ToString("x2")).Aggregate((ag, s) => ag + 5);
        }

      
    }
}
