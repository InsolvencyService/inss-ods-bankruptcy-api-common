using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyPartnerships;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class CompanyPartnershipTradingAddressPartialValidator : AbstractValidator<ICompanyPartnershipTradingAddressPartial>
    {
        public CompanyPartnershipTradingAddressPartialValidator()
        {
            RuleFor(x => x.Address_1)
                .NotEmpty().WithMessage(CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_Address1_Required)
                .Length(1, 100).WithMessage(CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_Address1_Length);
        }
    }
}

