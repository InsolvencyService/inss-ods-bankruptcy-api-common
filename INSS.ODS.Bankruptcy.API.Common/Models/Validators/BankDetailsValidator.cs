using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using System.Text.RegularExpressions;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class BankDetailsValidator : AbstractValidator<IBankDetails>
    {
        readonly Regex regExAlphanumericAndSpaces = new Regex("^[A-Za-z0-9 ]*[A-Za-z0-9][A-Za-z0-9 ]*$");

        public BankDetailsValidator()
        {
            RuleFor(r => r.BankName)
            .NotEmpty()
            .WithMessage(BankDetailsResources.BankAccount_BankDetails_BankName_Error_Mandatory);

            RuleFor(r => r.AddressLine1)
                .NotEmpty()
                .WithMessage(BankDetailsResources.BankAccount_BankDetails_AddressLine1_Error_Mandatory);

            RuleFor(r => r.PostCode)
             .NotEmpty()
             .WithMessage(BankDetailsResources.BankAccount_BankDetails_PostCode_Error_Mandatory)
             .Length(1, 11)
             .WithMessage(BankDetailsResources.BankAccount_BankDetails_PostCode_Error_MaxLength)
             .Matches(regExAlphanumericAndSpaces)
             .WithMessage(BankDetailsResources.BankAccount_BankDetails_PostCode_Error_SpecialCharacters);

            RuleFor(r => r.Country)
             .NotEmpty()
             .WithMessage(BankDetailsResources.BankAccount_BankDetails_Country_Error_Mandatory);
        }
    }
}