using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ExpenseValidator : AbstractValidator<IExpense>
    {
        public ExpenseValidator()
        {
            RuleFor(r => r.Type)
                .NotEmpty()
                .WithLocalizedMessage(
                    () => SavingsFinesOtherCostsResources.Expenses_SavingsFinesOtherCosts_Expense_Type_Error_Empty)
                .When(r => r.Value.HasValue);

            RuleFor(r => r.Value)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(
                    () => SavingsFinesOtherCostsResources.Expenses_SavingsFinesOtherCosts_Expense_Value_Error_Empty)
                .GreaterThanOrEqualTo(0)
                .WithLocalizedMessage(
                    () => SavingsFinesOtherCostsResources.Expenses_SavingsFinesOtherCosts_Expense_Value_Error_Negative)
                .SetValidator(new ScalePrecisionValidator(2, 99, () => SavingsFinesOtherCostsResources.Expenses_SavingsFinesOtherCosts_Expense_Value_Error_Scale))
                .When(r => !string.IsNullOrEmpty(r.Type));
        }
    }
}