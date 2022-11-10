using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SelfEmploymentIncomeValidator : AbstractValidator<ISelfEmploymentIncome>
    {
        public SelfEmploymentIncomeValidator()
        {

            RuleFor(x => x.AccountingPeriodStart)
                          .Cascade(CascadeMode.StopOnFirstFailure)
                          .NotEmpty()
                          .WithLocalizedMessage(() => SelfEmploymentIncomeResources.SelfEmploymentIncome_Accounting_Period_Start_Required)
                          .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                          .WithLocalizedMessage(() => SelfEmploymentIncomeResources.SelfEmploymentIncome_Accounting_Period_Start_Must_Be_After_1900)
                          .LessThan(DateTime.Today)
                          .WithLocalizedMessage(() => SelfEmploymentIncomeResources.SelfEmploymentIncome_Accounting_Period_Start_Must_Be_In_The_Past)
                          .When(x=>x.Profit !=null);

            RuleFor(x => x.AccountingPeriodEnd)
                 .Cascade(CascadeMode.StopOnFirstFailure)
                          .NotEmpty()
                          .WithLocalizedMessage(() => SelfEmploymentIncomeResources.SelfEmploymentIncome_Accounting_Period_End_Required)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                .WithLocalizedMessage(() => SelfEmploymentIncomeResources.SelfEmploymentIncome_Accounting_Period_End_Must_Be_After_1900)
                .LessThan(DateTime.Today)
                .WithLocalizedMessage(() => SelfEmploymentIncomeResources.SelfEmploymentIncome_Accounting_Period_End_Must_Be_In_The_Past)
                .GreaterThanOrEqualTo(x => x.AccountingPeriodStart)
                .WithLocalizedMessage(() => SelfEmploymentIncomeResources.SelfEmploymentIncome_Accounting_Period_Stop_After_Start)
                .When(x=> x.Profit != null);

        }
    }
}
