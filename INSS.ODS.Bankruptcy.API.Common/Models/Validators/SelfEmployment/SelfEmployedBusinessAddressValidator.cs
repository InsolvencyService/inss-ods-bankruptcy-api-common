using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SelfEmployedBusinessAddressValidator : AbstractValidator<ISelfEmployedBusinessAddress>
    {

        public SelfEmployedBusinessAddressValidator()
        {

            //RuleFor(x => x.TradingStartedDate)
            //       .NotNull().Must(DateValidation.BeAValidDate).WithMessage(
            //         () => SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_DateStarted_Required)
            //       .Must(DateValidation.BeAfter1900Date)
            //       .WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_TradingAtAddressStartDate_After_1900)
            //       .Must(DateValidation.BeInThePast)
            //       .WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_TradingAtAddressStartDate_In_The_Past);


            RuleFor(x => x.TradingStartedDate)
              .NotEmpty().WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_DateStarted_Required)
              .LessThanOrEqualTo(DateTime.Today)
              .WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_TradingAtAddressStartDate_In_The_Past);

            RuleFor(x => x.TradingStartedDate)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                 .WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_TradingAtAddressStartDate_After_1900)
                .When(x => x.TradingStartedDate != DateTime.MinValue);


            RuleFor(m => m.TradingStoppedDate)
           .GreaterThan(m => m.TradingStartedDate)
                           .WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_DateStopped_Before_DateStarted_Error)
                      .Must(DateValidation.BeAfter1900NullableDate)
                 .WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_TradingAtAddressStoppedDate_After_1900)
                 .Must(DateValidation.BeInThePastNullableDate)
                 .WithMessage(SelfEmployedBusinessAddressResources.SelfEmployedBusinessAddress_TradingAtAddressStoppedDate_In_The_Past)
           .When(m => m.TradingStoppedDate.HasValue);
        }


    }
}

