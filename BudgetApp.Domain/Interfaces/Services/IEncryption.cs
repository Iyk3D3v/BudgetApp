using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Interfaces.Services
{
    public interface IEncryption
    {
        string Encrypt(string password);
    }
}
