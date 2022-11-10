using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PolicyProviderValidator : AbstractValidator<IPolicyProvider>
    {
        public PolicyProviderValidator()
        {
            RuleFor(r => r.ProviderName)
            .NotEmpty()
            .WithLocalizedMessage(() => SelectPolicyProviderResources.PensionAndInsurance_SelectPolicyProvider_SelectedProvider_Error_Empty);

    
            RuleFor(x => x.ProviderAddress)
                .SetValidator(new AddressValidator());

        }
    }
}
