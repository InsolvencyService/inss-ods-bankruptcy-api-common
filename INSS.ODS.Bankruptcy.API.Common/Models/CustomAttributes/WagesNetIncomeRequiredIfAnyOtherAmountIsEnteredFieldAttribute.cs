using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    public class WagesNetIncomeRequiredIfAnyOtherAmountIsEnteredFieldAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            IWages wages = validationContext.ObjectInstance as IWages;

            if (wages != null)
            {
                if (wages.NetIncome == 0 || string.IsNullOrEmpty(wages.NetIncome.ToString().Trim()))
                {
                    if (wages.IncomeTax > 0 || 
                        wages.OverTime > 0 || 
                        wages.Bonus > 0 || 
                        wages.OtherPayments > 0 
                        )
                    {
                        return new ValidationResult(ErrorMessage);
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}