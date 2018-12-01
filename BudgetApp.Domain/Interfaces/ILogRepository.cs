using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Interfaces
{
    public interface ILogRepository
    {
        void CreateLog(LogModel l);

        LogModel[] GetAllLog();

        // would use this to get firstTime logger
        LogModel GetLogByEmail(string email);


           
    }
}
