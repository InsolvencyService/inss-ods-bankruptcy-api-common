using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SavingsFinesOtherCostsValidator : AbstractValidator<ISavingsFinesOtherCosts>
    {
        public SavingsFinesOtherCostsValidator()
        {
            RuleFor(r => r.Savings)
                .GreaterThan(0);
        }
    }
}