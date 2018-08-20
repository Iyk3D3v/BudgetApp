using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetApp.Models
{
    public class BudgetViewModel: Model
    { 
        [Required,DataType(DataType.Currency)]
        public decimal salary { get; set; }
        [Required]
        public decimal saving { get; set; }

        public int userId { get; set; }
    }
}