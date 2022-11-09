using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PolicyValueValidator : AbstractValidator<IPolicyValue>
    {
        public PolicyValueValidator()
        {
            RuleFor(x => x.CurrentlyReceivingPaymentOptions)
            .NotEmpty()
            .WithLocalizedMessage(() => PolicyValueResources.PensionAndInsurance_PolicyValue_CurrentlyReceivingPayment_Error_Empty);

            RuleFor(x => x.CurrentWorth)
            .InclusiveBetween(0, decimal.MaxValue).WithLocalizedMessage(() => PolicyValueResources.PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_NegativeValue)
            .SetValidator(new ScalePrecisionValidator(2, 99, () => PolicyValueResources.PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_Format));

            RuleFor(x => x.CurrentWorth)
                .Must(x => x.HasValue)
                .WithLocalizedMessage(
                    () => PolicyValueResources.PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_Mandatory)
                .When(x => !x.CurrentlyReceivingPayment);



        }
    }
}
