using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyPartnerships;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class CompanyPartnershipAddBusinessPartnerPartialValidator : AbstractValidator<ICompanyPartnershipAddBusinessPartnerPartial>
    {

        public CompanyPartnershipAddBusinessPartnerPartialValidator()
        {

            RuleFor(x => x.FirstName)
                .NotEmpty().WithLocalizedMessage(
                      () => PartnerSummaryResources.PartnerSummary_FirstName_Required )
                .Length(1, 70).WithLocalizedMessage(
                      () => PartnerSummaryResources.PartnerSummary_LastName_Length);

            RuleFor(x => x.LastName)
              .NotEmpty().WithLocalizedMessage(
                    () => PartnerSummaryResources.PartnerSummary_LastName_Required)
              .Length(1, 39).WithLocalizedMessage(
                    () => PartnerSummaryResources.PartnerSummary_LastName_Length);

        }

       
    }
}

