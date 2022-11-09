using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class BankAccountSortCodeValidator : AbstractValidator<IAccountBase>
    {
        public BankAccountSortCodeValidator()
        {
            RuleFor(x => x.SortCode)
                .Matches(RegularExpressions.SortCode)
                .WithLocalizedMessage(() => AddAccountResources.BankAccount_AddAccount_SortCode_Error_InvalidCharacter)
                .Length(6)
                .WithLocalizedMessage(() => AddAccountResources.BankAccount_AddAccount_SortCode_Error_WrongLength)
                .When(x => ! string.IsNullOrEmpty(x.SortCode));
        }
    }
}