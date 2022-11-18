using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class BeneficialInterestValidator : AbstractValidator<IBeneficialInterest>
    {
        public BeneficialInterestValidator()
        {
            RuleFor(x => x.Amount)
             .NotEmpty()
             .WithMessage(BeneficialInterestResources.Property_BeneficialInterest_Amount_Error_Mandatory)
             .InclusiveBetween(1, decimal.MaxValue)
             .WithMessage(BeneficialInterestResources.Property_BeneficialInterest_Amount_Error_PositiveOnly)
             .ScalePrecision(2, 99)
             .WithMessage(BeneficialInterestResources.Property_BeneficialInterest_Amount_Error_DecimalPlaces);
        }         
    }
}