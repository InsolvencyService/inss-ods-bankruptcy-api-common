using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    /// <summary>
    /// Validates conditionally-mandatory "OtherText" property for multi-value (radio list) Other option
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MultiValueOtherTextValidator : ValidationAttribute
    {
        public string OtherTextProperty { get; private set; }

        public MultiValueOtherTextValidator(string otherTextProperty)
        {
            OtherTextProperty = otherTextProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((string) value != "Other")
            {
                return ValidationResult.Success;
            }

            var p = validationContext.ObjectType.GetProperty(OtherTextProperty);
            var otherValue =  p.GetValue(validationContext.ObjectInstance, null) as string;

            if (!String.IsNullOrEmpty(otherValue))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage);

        }


    }
}
