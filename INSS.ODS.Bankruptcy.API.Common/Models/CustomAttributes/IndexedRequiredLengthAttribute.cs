using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.Resources;
using System.Text.RegularExpressions;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    public class IndexedRequiredLengthAttribute : ValidationAttribute
    {
        public static Regex _regEx = new Regex(RegularExpressions.IndexRequiredLength);
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public String RequiredErrorMessageName { get; set; }
        public String MinLengthErrorMessageName { get; set; }
        public String MaxLengthErrorMessageName { get; set; }

        protected String GetErrorMessage(string messageName, string displayName="", int index = -1)
        {
            //default to error message
            string errorMsg = ErrorMessage;
            if (ErrorMessageResourceType != null && !String.IsNullOrEmpty(messageName))
            {
                try
                {
                    ResourceManager rm = new ResourceManager(ErrorMessageResourceType);
                    errorMsg = rm.GetString(messageName);
                }
                catch(Exception)
                {
                    //Resource not found! Return default error message!
                    return errorMsg;
                }

                int numParams = _regEx.Matches(errorMsg).Count;
                if(numParams == 1 && index != -1)
                {
                    return String.Format(errorMsg, index);
                }
                else if(numParams == 2 && index != -1)
                {
                    return String.Format(errorMsg, displayName, index);
                }
                else
                {
                    //default error message
                    return errorMsg;
                }
            }
            else
            {
                //return default error message if supplied
                return errorMsg;
            }
        }


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int itemIndex = -1;
            string displayName = validationContext.DisplayName;

            //Check if the object is indexed..
            IIndexedItem itemInstance = validationContext.ObjectInstance as IIndexedItem;
            if (itemInstance != null)
            {
                itemIndex = itemInstance.ItemIndex;
            }

            String answer = value as String;

            if (MinLength != 0 && String.IsNullOrEmpty(answer))
            {
                return new ValidationResult(GetErrorMessage(RequiredErrorMessageName, displayName, itemIndex));
            }
            else if (answer.Length < MinLength)
            {
                return new ValidationResult(GetErrorMessage(MinLengthErrorMessageName, displayName, itemIndex));
            }
            else if (answer.Length > MaxLength)
            {
                return new ValidationResult(GetErrorMessage(MaxLengthErrorMessageName, displayName, itemIndex));
            }
            else
            {
                return ValidationResult.Success;
            }
        }

    }
}
