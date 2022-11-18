using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using INSS.ODS.Bankruptcy.API.Common.Resources.Employment;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PartnershipBusinessNameValidator : AbstractValidator<IPartnershipBusinessName>
    {
        public PartnershipBusinessNameValidator()
        {
            RuleFor(x => x.BusinessName)
                .NotEmpty().WithMessage(SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_BusinessName_Required)
                .Length(1, 100).WithMessage(SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_BusinessName_Length);
        }
    }
}

