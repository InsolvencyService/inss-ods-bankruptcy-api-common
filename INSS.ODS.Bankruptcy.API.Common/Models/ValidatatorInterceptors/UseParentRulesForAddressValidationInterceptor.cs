using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Results;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace INSS.ODS.Bankruptcy.API.Common.Models.ValidatationInterceptors
{
    public class UseParentRulesForAddressValidationInterceptor<TAddress> //: IValidatorInterceptor
        where TAddress : IAddress
    {
        public ValidationResult AfterMvcValidation(ControllerContext controllerContext, ValidationContext validationContext, ValidationResult result)
        {

            return result;
        }
        public ValidationContext BeforeMvcValidation(ControllerContext controllerContext, ValidationContext validationContext)
        {
            var instance = validationContext.InstanceToValidate;
            if (instance is TAddress)
            {

                // NOTE: The fluent validator automatically chooses validator on child properties when it is available.
                // So, it always applies AddressIntrefaceValidator for AddressVm even when we don't want it to apply those rules
                // The trick is to return a validation context with empty rule sets whenever validating Address 

                //return empty result set
                return validationContext.Clone(selector: new RulesetValidatorSelector("ApplyParentRules"));
            }

            return validationContext;

        }

    }
}
