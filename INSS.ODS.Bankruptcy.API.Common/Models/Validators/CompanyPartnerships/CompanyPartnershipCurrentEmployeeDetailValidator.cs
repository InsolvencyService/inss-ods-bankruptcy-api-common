using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyPartnerships;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyPartnerships
{
    public class CompanyPartnershipCurrentEmployeeDetailValidator : CompositeValidator<IPartnershipCurrentEmployeeDetail>
    {
        public CompanyPartnershipCurrentEmployeeDetailValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());

            RuleFor(x => x.MoneyOwed)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(CompanyPartnershipCurrentEmployeeDetailResources.CompanyPartnershipCurrentEmployeeDetail_MoneyOwed_Required)
                .When(x => !x.MoneyOwed.HasValue);

        }
    }
}