using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyPartnerships;
using System.Text.RegularExpressions;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PartnershipDetailValidator : AbstractValidator<IPartnershipDetail>
    {

        public PartnershipDetailValidator()
        {
            var regex = RegularExpressions.PartnershipName1;
            var regex2 = RegularExpressions.BusinessType1;

            RuleFor(x => x.BusinessName)
                .NotEmpty().WithMessage(PartnershipDetailResources.PartnershipDetail_BusinessName_Required)
                .Length(1, 100).WithMessage(PartnershipDetailResources.PartnershipDetail_BusinessName_Length)
                       .Matches(RegularExpressions.PartnershipName2)
                .WithMessage(x => $"{SummaryResources.Summary_PartnershipName_Invalid} {Regex.Match(x.BusinessName, regex)}");

            RuleFor(x => x.BusinessType)
               .NotEmpty().WithMessage(PartnershipDetailResources.PartnershipDetail_BusinessType_Required)
               .Length(2, 100).WithMessage(PartnershipDetailResources.PartnershipDetail_BusinessType_Length)
                                            .Matches(RegularExpressions.BusinessType2)
                       .WithMessage(x => $"{PartnershipDetailResources.PartnershipDetail_BusinessType_Invalid} {Regex.Match(x.BusinessType, regex2)}"); 

            RuleFor(x => x.TradingStartedDate)
              .NotEmpty().WithMessage(PartnershipDetailResources.PartnershipDetail_Trading_Start_Date_Required)
              .LessThanOrEqualTo(DateTime.Today)
              .WithMessage(PartnershipDetailResources.PartnershipDetail_Trading_Start_Date_Must_Be_In_The_Past);

            RuleFor(x => x.TradingStartedDate)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                 .WithMessage(PartnershipDetailResources.PartnershipDetail_Trading_Start_Date_Must_Be_After_1900)
                .When(x => x.TradingStartedDate != DateTime.MinValue);



            RuleFor(m => m.TradingStoppedDate)
           .GreaterThan(m => m.TradingStartedDate)
                           .WithMessage(PartnershipDetailResources.PartnershipDetail_Trading_End_Date_After_Start_Date)
                          .Must(DateValidation.BeAfter1900NullableDate)
                 .WithMessage(PartnershipDetailResources.PartnershipDetail_Trading_End_Date_Must_Be_After_1900)
                 .Must(DateValidation.BeInThePastNullableDate)
                 .WithMessage(PartnershipDetailResources.PartnershipDetail_Trading_End_Date_Must_Be_In_The_Past)
           .When(m => m.TradingStoppedDate.HasValue);
        }


    }
}

