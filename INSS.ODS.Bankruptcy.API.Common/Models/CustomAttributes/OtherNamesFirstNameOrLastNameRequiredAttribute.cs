using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    public class OtherNamesFirstNameOrLastNameRequiredAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                IOtherName target = validationContext.ObjectInstance as IOtherName;
                if (target != null)
                {
                    if (String.IsNullOrWhiteSpace(target.FirstName) && String.IsNullOrWhiteSpace(target.LastName))
                    {
                        return new ValidationResult(ErrorMessage);
                    }
                }
                else
                {
                    return new ValidationResult("This attribute invalid on this object!");
                }
            }
            return ValidationResult.Success;
        }
    }
}
