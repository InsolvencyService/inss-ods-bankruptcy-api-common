using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Shared.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt
{
    public class PreferredCreditorNameInterfaceValidator : AbstractValidator<IPreferredCreditorName>
    {
        public PreferredCreditorNameInterfaceValidator()
        {
            RuleFor(x => x.CreditorName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_Empty)
                .Must(limitedCompanyName => ValidationLengthHelper.HaveLengthGreaterThan(limitedCompanyName, 2))
                .WithLocalizedMessage(() => DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_TooShort)
                .Must(limitedCompanyName => ValidationLengthHelper.HaveLengthLessThan(limitedCompanyName, 51))
                .WithLocalizedMessage(() => DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_TooLong);
        }
    }
}