using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace INSS.ODS.Bankruptcy.API.Common.Models.ValidatationInterceptors;

public class UseParentRulesForAddressValidationInterceptor<TAddress> : IValidatorInterceptor
    where TAddress : IAddress
{
    public ValidationResult AfterAspNetValidation(ActionContext actionContext, IValidationContext validationContext, ValidationResult result)
    {
        return result;
    }

    public IValidationContext BeforeAspNetValidation(ActionContext actionContext, IValidationContext validationContext)
    {
        var instance = validationContext.InstanceToValidate;
        if (instance is TAddress)
        {
            // NOTE: The fluent validator automatically chooses validator on child properties when it is available.
            // So, it always applies AddressIntrefaceValidator for AddressVm even when we don't want it to apply those rules
            // The trick is to return a validation context with empty rule sets whenever validating Address 

            //return empty result set

            // TODO: Following code is commented out temporarily and should be uncommented once we know how .Clone() method works in latest version of FluentValidation
            // return validationContext.Clone(selector: new RulesetValidatorSelector("ApplyParentRules"));
            throw new NotImplementedException("Not Implemented");
        }

        return validationContext;
    }
}
