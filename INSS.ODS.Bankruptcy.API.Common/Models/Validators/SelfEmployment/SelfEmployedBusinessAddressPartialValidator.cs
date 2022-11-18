using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using INSS.ODS.Bankruptcy.API.Common.Resources.Employment;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SelfEmployedBusinessAddressPartialValidator : AbstractValidator<ISelfEmployedBusinessAddressPartial>
    {
        public SelfEmployedBusinessAddressPartialValidator()
        {
            RuleFor(x => x.Address_1)
                .NotEmpty().WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_Address1_Required)
                .Length(1, 100).WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_Address1_Length);
        }
    }
}

