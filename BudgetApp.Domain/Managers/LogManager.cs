using BudgetApp.Domain.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Managers
{
    public class LogManager
    {
        private ILogRepository _logRepo;

        public LogManager(ILogRepository logRepo)
        {
            _logRepo = logRepo;
        }

        public void CreateLog(LogModel l)
        {
            _logRepo.CreateLog(l);
        }
    }
}
