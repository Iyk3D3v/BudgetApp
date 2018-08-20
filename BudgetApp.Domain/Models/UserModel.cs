using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Models
{
    public class UserModel : Model
    {
        public int UserId { get; set; }

        public string email { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string password{ get; set; }
    }
}
