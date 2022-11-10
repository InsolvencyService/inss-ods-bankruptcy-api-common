using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    class MinimumAgeAttribute : ValidationAttribute
    {
        protected int MinimumAge { get; set; }
        public MinimumAgeAttribute(int age)
        {
            MinimumAge = age;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                DateTime dob = (DateTime) value;
                if (dob.AddYears(MinimumAge) > DateTime.Today)
                {
                    return new ValidationResult(String.Format(ErrorMessageString, MinimumAge));
                }                
            }
            return ValidationResult.Success;
        }
    }
}
