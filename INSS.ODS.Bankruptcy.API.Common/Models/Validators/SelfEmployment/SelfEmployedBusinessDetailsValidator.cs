using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;
using System;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SelfEmployedBusinessDetailValidator : AbstractValidator<ISelfEmployedBusinessDetail>
    {

        public SelfEmployedBusinessDetailValidator()
        {

            RuleFor(x => x.BusinessName)
                .NotEmpty().WithLocalizedMessage(
                      () => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_BusinessName_Required)
                .Length(1, 100).WithLocalizedMessage(
                      () => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_BusinessName_Length);

            RuleFor(x => x.BusinessType)
               .NotEmpty().WithLocalizedMessage(
                     () => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_BusinessType_Required)
               .Length(2, 100).WithLocalizedMessage(
                     () => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_BusinessType_Length);


            RuleFor(x => x.TradingStartedDate)
              .NotEmpty().WithLocalizedMessage(() => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_TradingStartedDateStarted_Required)
              .LessThanOrEqualTo(DateTime.Today)
              .WithLocalizedMessage(() => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_Date_In_The_Past);

            RuleFor(x => x.TradingStartedDate)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                 .WithLocalizedMessage(() => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_Date_After_1900)
                .When(x => x.TradingStartedDate != DateTime.MinValue);



            RuleFor(m => m.TradingStoppedDate)
           .GreaterThan(m => m.TradingStartedDate)
                           .WithLocalizedMessage(
                      () => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_TradingStartedDateStopped_Before_DateStarted_Error)
                          .Must(DateValidation.BeAfter1900NullableDate)
                 .WithLocalizedMessage(() => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_TradingStoppedDate_After_1900)
                 .Must(DateValidation.BeInThePastNullableDate)
                 .WithLocalizedMessage(() => SelfEmployedBusinessDetailsResources.SelfEmployedBusinessDetails_TradingStoppedDate_In_The_Past)
           .When(m => m.TradingStoppedDate.HasValue);
        }


    }
}

