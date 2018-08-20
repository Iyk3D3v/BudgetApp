using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetApp.Models
{
    public class UserViewModel : Model
    {
        [Required,EmailAddress]
        public string email { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required,DataType(DataType.Password)]
        public string password { get; set; }
        [Required, DataType(DataType.Password)]
        public string confirmPassword { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext context)
        {
            if(password != confirmPassword)
            {
                yield return new ValidationResult("Passwords do not match", new[] { nameof(password),nameof(confirmPassword)});
            }
            
           //s return new List<ValidationResult>();
        }



    }
}