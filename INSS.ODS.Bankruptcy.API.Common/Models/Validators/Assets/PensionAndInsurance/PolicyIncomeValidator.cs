using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PolicyIncomeValidator : AbstractValidator<IPolicyIncome>
    {
        public PolicyIncomeValidator()
        {
            RuleFor(x => x.IncomeAmount)
            .Must(x => x.HasValue)
            .WithLocalizedMessage(() => PolicyIncomeResources.PensionAndInsurance_PolicyIncome_IncomeAmount_Error_Empty)
            .InclusiveBetween(0, decimal.MaxValue).WithLocalizedMessage(() => PolicyIncomeResources.PensionAndInsurance_PolicyIncome_IncomeAmount_Error_Negative)
            .SetValidator(new ScalePrecisionValidator(2, 99, () => PolicyIncomeResources.PensionAndInsurance_PolicyIncome_IncomeAmount_Error_Format));

            RuleFor(x => x.IncomeFrequency)
            .NotEmpty()
            .WithLocalizedMessage(() => PolicyIncomeResources.PensionAndInsurance_PolicyIncome_IncomeFrequency_Error_Empty);

        }
    }
}
