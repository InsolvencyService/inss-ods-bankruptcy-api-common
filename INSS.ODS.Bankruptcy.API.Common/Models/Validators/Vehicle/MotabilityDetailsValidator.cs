using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class MotabilityDetailsValidator : AbstractValidator<IMotabilityDetails>
    {
        public MotabilityDetailsValidator()
        {
            RuleFor(x => x.MotabilityCRN)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => MotabilityDetailsResources.Vehicle_MotabilityDetails_MotabilityCRN_Error_Required)
                .NotEmpty()
                .WithLocalizedMessage(() => MotabilityDetailsResources.Vehicle_MotabilityDetails_MotabilityCRN_Error_Required);
        }
    }
}