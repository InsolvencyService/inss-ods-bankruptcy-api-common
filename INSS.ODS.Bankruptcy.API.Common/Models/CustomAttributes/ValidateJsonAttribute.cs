using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    public class ValidateJsonAttribute : ValidationAttribute
    {
        private bool AllowNullOrEmpty { get; set; }
        public ValidateJsonAttribute(bool allowNullOrEmpty = true)
        {
            AllowNullOrEmpty = allowNullOrEmpty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool valid = false;
            String stringValue = value as String;
       
            if (!String.IsNullOrWhiteSpace(stringValue))
            {
                try
                {
                    //By default there is no schema.. so set it to null
                    //Just need to valudate that the string can be converted to a valid JSON object..
                    var jsonObject = JObject.Parse(stringValue);
                    valid = (jsonObject != null);
                }
                catch(Exception)
                {
                    valid = false;
                }
            }
            else
            {
                //The object is valid only if NULL is allowed.
                valid = AllowNullOrEmpty;
            }

            return valid ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
