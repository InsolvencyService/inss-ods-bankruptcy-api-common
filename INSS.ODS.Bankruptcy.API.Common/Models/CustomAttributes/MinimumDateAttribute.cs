using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    class MinimumDateAttribute : ValidationAttribute
    {
        protected DateTime MinimumDate { get; set; }
        public MinimumDateAttribute(string minDateString)
        {
            CultureInfo info = CultureInfo.CreateSpecificCulture("en-GB");
            MinimumDate = DateTime.Parse(minDateString, info.DateTimeFormat);
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime dob = (DateTime)value;
                if (dob < MinimumDate)
                {
                    return new ValidationResult(String.Format(ErrorMessageString, MinimumDate.ToString("dd/MM/yyyy")));
                }
            }
            return ValidationResult.Success;
        }
    }
}
