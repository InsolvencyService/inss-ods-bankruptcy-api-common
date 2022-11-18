using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class SelfEmployedFormerEmployeeDetailValidator : CompositeValidator<IFormerEmployeeDetail>
    {
        public SelfEmployedFormerEmployeeDetailValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());

            RuleFor(x => x.Reason)
                .NotEmpty().WithMessage(FormerEmployeeDetailResources.FormerEmployeeDetail_Reason_Required)
                .Length(3, 100).WithMessage(FormerEmployeeDetailResources.FormerEmployeeDetail_Reason_Length);

            RuleFor(x => x.Amount)
              .NotEmpty().WithMessage(FormerEmployeeDetailResources.FormerEmployeeDetail_Amount_Required)
              .Must(x => x > 0)
              .WithMessage(FormerEmployeeDetailResources.FormerEmployeeDetail_Amount_Invalid);


            RuleFor(x => x.Amount).SetValidator(new CurrencyValidator());

        }
    }
}