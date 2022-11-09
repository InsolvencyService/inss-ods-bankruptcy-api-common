using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class SelfEmployedEmployeeMoneyOwedValidator : AbstractValidator<ISelfEmployedEmployeeMoneyOwed>
    {
        public SelfEmployedEmployeeMoneyOwedValidator()
        {
            RuleFor(x => x.Reason )
             .NotEmpty().WithLocalizedMessage(
                   () => MoneyOwedResources.MoneyOwed_Reason_Required)
             .Length(1, 100).WithLocalizedMessage(
                   () => MoneyOwedResources.MoneyOwed_Reason_Length);

            RuleFor(x => x.Amount)
               .Must(x => x > 0)
               .WithLocalizedMessage(() => MoneyOwedResources.MoneyOwed_Amount_Required);

            RuleFor(x => x.Amount).SetValidator(new CurrencyValidator());


        }
    }
}