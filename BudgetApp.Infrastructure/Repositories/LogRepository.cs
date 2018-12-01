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
    public class LogRepository : ILogRepository
    {
        public void CreateLog(LogModel l)
        {
            using (var context = new DataEntities())
            {
                var newLog = new Log
                {
                    Email = l.Email,
                    LogTime = l.LogTime
                };
                context.Logs.Add(newLog);
                context.SaveChanges();
            }
        }

        public LogModel[] GetAllLog()
        {
            using (var context = new DataEntities())
            {
                var query = from l in context.Logs
                            select new LogModel
                            {
                                LogId =l.LogId,
                                Email = l.Email,
                                LogTime = l.LogTime
                            };

                var result = query.ToArray();
                return result;
            }
        }

        public LogModel GetLogByEmail(string email)
        {
            using (var context = new DataEntities())
            {
                var query = from l in context.Logs
                            where email == l.Email
                            select new LogModel
                            {
                                LogId = l.LogId,
                                Email = l.Email,
                                LogTime = l.LogTime
                            };

                var result = query as LogModel;
                return result;
            }
        }
    }
}
