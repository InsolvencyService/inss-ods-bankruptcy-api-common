using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt
{
    public class DebtReliefOptionTypeInterfaceValidator : AbstractValidator<IDebtReliefOptionType>
    {
        public DebtReliefOptionTypeInterfaceValidator()
        {
            RuleFor(x => x.DebtReliefOptionType)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty()
            .WithLocalizedMessage(() => DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_Error_Empty);
        }
    }
}
