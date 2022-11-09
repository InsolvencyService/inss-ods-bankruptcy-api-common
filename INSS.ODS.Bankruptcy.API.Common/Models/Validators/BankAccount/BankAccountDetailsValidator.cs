using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.BankAccount;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.BankAccount
{
    public class BankAccountDetailsValidator : AbstractValidator<IBankAccountDetails>
    {
        public BankAccountDetailsValidator()
        {
            RuleFor(r => r.AccountNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => AccountDetailsResources.BankAccount_AccountDetails_AccountNumber_Error_Empty);

            RuleFor(r => r.CurrentBalance)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => AccountDetailsResources.BankAccount_AccountDetails_CurrentBalance_Error_Empty);

            RuleFor(r => r.DateOpened)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => AccountDetailsResources.BankAccount_AccountDetails_DateOpened_Error_Empty)
                .Must(BeAfter1900Date)
                .WithLocalizedMessage(() => AccountDetailsResources.BankAccount_AccountDetails_DateOpened_Error_Date_After_1900)
                .Must(BeInThePast)
                .WithLocalizedMessage(() => AccountDetailsResources.BankAccount_AccountDetails_DateOpened_Error_Date_In_The_Past);

            RuleFor(r => r.JointAccount)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => AccountDetailsResources.BankAccount_AccountDetails_JointAccount_Error_Empty);
        }
        private bool BeAfter1900Date(DateTime date)
        {
            if (date <= new DateTime(1900, 1, 1))
                return false;
            return true;
        }

        private bool BeInThePast(DateTime date)
        {
            if (date > DateTime.Now)
                return false;
            return true;
        }
    }
}
