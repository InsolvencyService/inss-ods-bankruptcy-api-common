using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt
{
    public class PreferredCreditorInterfaceValidator : AbstractValidator<IPreferredCreditor>
    {
        public PreferredCreditorInterfaceValidator()
        {
            RuleFor(x => x.CreditorName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_Empty)
                .Must(limitedCompanyName => HaveLengthGreaterThan(limitedCompanyName, 2))
                .WithLocalizedMessage(() => DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_TooShort)
                .Must(limitedCompanyName => HaveLengthLessThan(limitedCompanyName, 51))
                .WithLocalizedMessage(() => DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_TooLong);

            RuleFor(x => x.CreditorAddress)
                .SetValidator(new AddressValidator());
        }

        private bool HaveLengthGreaterThan(string value, int length)
        {
            return value.Length > length;
        }

        private bool HaveLengthLessThan(string value, int length)
        {
            return value.Length < length;
        }
    }
}