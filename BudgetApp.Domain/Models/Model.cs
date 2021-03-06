﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Domain.Models
{
    public class Model : IValidatableObject
    {
        public void Validate()
        {
            Validator.ValidateObject(this, new ValidationContext(this, null, null));
        }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return new List<ValidationResult>();
        }
        
    }
}
