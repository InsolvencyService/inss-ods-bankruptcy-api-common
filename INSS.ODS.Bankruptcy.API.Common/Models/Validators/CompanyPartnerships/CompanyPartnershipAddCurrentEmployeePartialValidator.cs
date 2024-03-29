using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyPartnerships;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class CompanyPartnershipAddCurrentEmployeePartialValidator : AbstractValidator<IPartnershipCurrentEmployeeDetail>
    {

        public CompanyPartnershipAddCurrentEmployeePartialValidator()
        {

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage(CompanyPartnershipCurrentEmployeeSummaryResources.CompanyPartnershipCurrentEmployeeSummary_FirstName_Required )
                .Length(1, 70).WithMessage(CompanyPartnershipCurrentEmployeeSummaryResources.CompanyPartnershipCurrentEmployeeSummary_FirstName_Length );

            RuleFor(x => x.LastName)
              .NotEmpty().WithMessage(CompanyPartnershipCurrentEmployeeSummaryResources.CompanyPartnershipCurrentEmployeeSummary_LastName_Required )
              .Length(1, 39).WithMessage(CompanyPartnershipCurrentEmployeeSummaryResources.CompanyPartnershipCurrentEmployeeSummary_LastName_Length);

        }

       
    }
}

