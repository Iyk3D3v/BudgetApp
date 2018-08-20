using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetApp.Models
{
    public class LoginViewModel: Model
    {
        [Required,EmailAddress]
        public string email { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}