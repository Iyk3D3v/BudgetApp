using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Infrastructure.Data
{
    public class Log
    {
        [Key]
        public int LogId { get; set; }

        public string Email { get; set; }

        public DateTime LogTime { get; set; }




    }
}
