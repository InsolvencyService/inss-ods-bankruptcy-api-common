using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;

namespace Insolvency.Bankruptcy.App.Validators
{
    public class LandlordOrAgentDetailsValidator : AbstractValidator<ILandlordOrAgentDetails>
    {
        public LandlordOrAgentDetailsValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(LandlordDetailsResources.Personal_LandlordDetails_Name_Error_Empty)
                .NotEmpty()
                .WithMessage(LandlordDetailsResources.Personal_LandlordDetails_Name_Error_Empty);

            RuleFor(x => x.Address)
                .SetValidator(new AddressValidator());
        }
    }
}