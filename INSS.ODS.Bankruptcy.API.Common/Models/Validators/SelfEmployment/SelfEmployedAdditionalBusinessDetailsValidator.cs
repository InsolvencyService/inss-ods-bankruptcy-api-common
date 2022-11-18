using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;
using INSS.ODS.API.Common.Utilities.Constants;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SelfEmployedAdditionalBusinessDetailValidator : AbstractValidator<ISelfEmployedAdditionalBusinessDetail>
    {

        public SelfEmployedAdditionalBusinessDetailValidator()
        {

            RuleFor(x => x.VATNumber)
                .Length(1, 15).WithMessage(SelfEmployedAdditionalBusinessDetailsResources.SelfEmployedAdditonalBusinessDetails_VATNumber_Length)
                                           .Matches(RegularExpressions.VAT).WithMessage(SelfEmployedAdditionalBusinessDetailsResources.SelfEmployedAdditonalBusinessDetails_VATNumber_Invalid)
                .When(x => !string.IsNullOrEmpty(x.VATNumber));

            RuleFor(x => x.UTR)
               .NotEmpty().WithMessage(SelfEmployedAdditionalBusinessDetailsResources.SelfEmployedAdditonalBusinessDetails_UTR_Required);

            RuleFor(x => x.RecordsLocation)
                  .NotNull().WithMessage(SelfEmployedAdditionalBusinessDetailsResources.SelfEmployedAdditonalBusinessDetails_RecordsLocation_Required);

        }

    }
}

