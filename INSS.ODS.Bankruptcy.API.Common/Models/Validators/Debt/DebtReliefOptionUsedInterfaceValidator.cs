using System;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt
{
    public class DebtReliefOptionUsedInterfaceValidator : CompositeValidator<IDebtReliefOptionUsed>
    {
        public DebtReliefOptionUsedInterfaceValidator()
        {
            RuleFor(x => x.DebtReliefOptionType)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(
                    () => DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_Error_Empty);

            RuleFor(x => x.DebtReliefOptionStartDate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => DebtReliefOptionDetailsResources.Debt_DebtReliefOptionDetails_DebtReliefOptionStartDate_Error_Empty)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                .WithLocalizedMessage(() => DebtReliefOptionDetailsResources.Debt_DebtReliefOptionDetails_DebtReliefOptionStartDate_Error_MinimumDate)
                .LessThanOrEqualTo(DateTime.Today)
                .WithLocalizedMessage(() => DebtReliefOptionDetailsResources.Debt_DebtReliefOptionDetails_DebtReliefOptionStartDate_Error_InTheFuture);

            RuleFor(x => x.DebtReliefOptionReferenceNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(
                    () => DebtReliefOptionDetailsResources.Debt_DebtReliefOptionDetails_DebtReliefOptionReferenceNumber_Error_Empty)
                .When(x => !string.IsNullOrEmpty(x.DebtReliefOptionType) &&
                (x.DebtReliefOptionType.ToLower() == DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_Bankruptcy_Label.ToLower()
                           || x.DebtReliefOptionType.ToLower() == DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_DebtReliefOrder_Label.ToLower()));






        }
    }
}
