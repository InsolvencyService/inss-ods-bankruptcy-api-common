using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes
{
    public class IndexedItemRequiredAttribute: RequiredAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult baseResult = base.IsValid(value, validationContext);
            if (baseResult != ValidationResult.Success)
            {
                //Check if this is an indexed item
                IIndexedItem itemInstance = validationContext.ObjectInstance as IIndexedItem;
                if (itemInstance != null)
                {
                    int itemIndex = itemInstance.ItemIndex;
                    return new ValidationResult(String.Format(ErrorMessageString, itemIndex.ToString()));
                }
            }
            return baseResult;
        }

    }
}
