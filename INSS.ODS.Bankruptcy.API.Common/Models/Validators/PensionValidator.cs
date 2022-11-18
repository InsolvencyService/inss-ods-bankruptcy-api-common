using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PensionValidator : AbstractValidator<IPension>
    {
        public PensionValidator()
        {
            RuleFor(x => x.State)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithMessage(PensionResources.Pension_Positive_State_Label);


            RuleFor(x => x.PensionCredit)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithMessage(PensionResources.Pension_Positive_PensionCredit_Label);

        }
    }
}
