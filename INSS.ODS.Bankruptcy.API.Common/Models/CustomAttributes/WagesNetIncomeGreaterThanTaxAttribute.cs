 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    public class WagesNetIncomeGreaterThanTaxAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                IWages wages = validationContext.ObjectInstance as IWages;

                if (wages != null)
                {
                    if (wages.NetIncome < wages.IncomeTax)
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