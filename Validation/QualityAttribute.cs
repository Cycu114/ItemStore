using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ItemStoreProject.Validation
{
    public class QualityAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string quality = value.ToString();

            if (quality != "Excellent" && quality !="Good" && quality != "Poor" && quality != "Bad")
            {
                return new ValidationResult("Invalid quality. Valid values are Excellent, Good, Poor and Bad.");
            }
            return ValidationResult.Success;
        }
    }
}
