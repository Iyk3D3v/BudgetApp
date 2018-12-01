using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Models
{
    public class LogModel:Model
    {
        public int LogId { get; set; }

        public string Email { get; set; }

        public DateTime LogTime { get; set; }
    }
}
