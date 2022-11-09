using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyPartnerships;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class CompanyPartnershipTradingAddressValidator : AbstractValidator<ICompanyPartnershipTradingAddress>
    {

        public CompanyPartnershipTradingAddressValidator()
        {

            RuleFor(x => x.TradingStartedDate)
              .NotEmpty().WithLocalizedMessage(() => CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_DateStarted_Required)
              .LessThanOrEqualTo(DateTime.Today)
              .WithLocalizedMessage(() => CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_TradingAtAddressStartDate_In_The_Past);

            RuleFor(x => x.TradingStartedDate)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                 .WithLocalizedMessage(() => CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_TradingAtAddressStoppedDate_After_1900)
                .When(x => x.TradingStartedDate != DateTime.MinValue);


            RuleFor(m => m.TradingStoppedDate)
           .GreaterThan(m => m.TradingStartedDate)
                           .WithLocalizedMessage(
                      () => CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_DateStopped_Before_DateStarted_Error)
                      .Must(DateValidation.BeAfter1900NullableDate)
                 .WithLocalizedMessage(() => CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_TradingAtAddressStoppedDate_After_1900)
                 .Must(DateValidation.BeInThePastNullableDate)
                 .WithLocalizedMessage(() => CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_TradingAtAddressStoppedDate_In_The_Past)
           .When(m => m.TradingStoppedDate.HasValue);

            RuleFor(x => x.TradingStartedDate)
                .GreaterThanOrEqualTo(m => m.PartnershipStartedDate)
                           .WithLocalizedMessage(
                      () => CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_TradingAtAddressStartedDate_AfterPartnershipTradingStartedDate)
                      .When(m => m.TradingStartedDate != DateTime.MinValue);

            RuleFor(x => x.TradingStoppedDate)
    .LessThanOrEqualTo(m => m.PartnershipStoppedDate)
               .WithLocalizedMessage(
          () => CompanyPartnershipTradingAddressResources.CompanyPartnershipTradingAddress_TradingAtAddressStoppedDate_AfterPartnershipTradingStoppedDate)
                                .When(m => m.TradingStoppedDate.HasValue && m.PartnershipStoppedDate.HasValue);

        }


    }
}

