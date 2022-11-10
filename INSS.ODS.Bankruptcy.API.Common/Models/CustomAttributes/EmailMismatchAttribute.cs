using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    class EmailMismatchAttribute : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                IApplicantDetails applicantDetails = validationContext.ObjectInstance as IApplicantDetails;
                if(applicantDetails != null)
                {
                    if(applicantDetails.Email != applicantDetails.ConfirmEmail)
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
