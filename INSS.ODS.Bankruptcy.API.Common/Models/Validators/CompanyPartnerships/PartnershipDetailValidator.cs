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

            RuleFor(x => x.BusinessName)
                .NotEmpty().WithLocalizedMessage(
                      () => PartnershipDetailResources.PartnershipDetail_BusinessName_Required)
                .Length(1, 100).WithLocalizedMessage(
                      () => PartnershipDetailResources.PartnershipDetail_BusinessName_Length)
                       .Matches(RegularExpressions.PartnershipName2)
                .WithLocalizedMessage(() => SummaryResources.Summary_PartnershipName_Invalid,
                    c =>
                    {
                        var regex = RegularExpressions.PartnershipName1;
                        var matchedResult = Regex.Match(c.BusinessName, regex);
                        return matchedResult;
                    });

            RuleFor(x => x.BusinessType)
               .NotEmpty().WithLocalizedMessage(
                     () => PartnershipDetailResources.PartnershipDetail_BusinessType_Required)
               .Length(2, 100).WithLocalizedMessage(
                     () => PartnershipDetailResources.PartnershipDetail_BusinessType_Length)
                                            .Matches(RegularExpressions.BusinessType2)
                       .WithLocalizedMessage(() => PartnershipDetailResources.PartnershipDetail_BusinessType_Invalid,
                    c =>
                    {
                        var regex = RegularExpressions.BusinessType1;
                        var matchedResult = Regex.Match(c.BusinessType, regex);
                        return matchedResult;
                    });


            RuleFor(x => x.TradingStartedDate)
              .NotEmpty().WithLocalizedMessage(() => PartnershipDetailResources.PartnershipDetail_Trading_Start_Date_Required)
              .LessThanOrEqualTo(DateTime.Today)
              .WithLocalizedMessage(() => PartnershipDetailResources.PartnershipDetail_Trading_Start_Date_Must_Be_In_The_Past);

            RuleFor(x => x.TradingStartedDate)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                 .WithLocalizedMessage(() => PartnershipDetailResources.PartnershipDetail_Trading_Start_Date_Must_Be_After_1900)
                .When(x => x.TradingStartedDate != DateTime.MinValue);



            RuleFor(m => m.TradingStoppedDate)
           .GreaterThan(m => m.TradingStartedDate)
                           .WithLocalizedMessage(
                      () => PartnershipDetailResources.PartnershipDetail_Trading_End_Date_After_Start_Date)
                          .Must(DateValidation.BeAfter1900NullableDate)
                 .WithLocalizedMessage(() => PartnershipDetailResources.PartnershipDetail_Trading_End_Date_Must_Be_After_1900)
                 .Must(DateValidation.BeInThePastNullableDate)
                 .WithLocalizedMessage(() => PartnershipDetailResources.PartnershipDetail_Trading_End_Date_Must_Be_In_The_Past)
           .When(m => m.TradingStoppedDate.HasValue);
        }


    }
}

