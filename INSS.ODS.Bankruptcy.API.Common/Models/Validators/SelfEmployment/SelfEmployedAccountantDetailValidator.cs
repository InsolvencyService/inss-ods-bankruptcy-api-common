using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class SelfEmployedAccountantDetailValidator<TAddress> : AbstractValidator<IAccountantDetail<TAddress>> where TAddress : IAddress
    {
        public SelfEmployedAccountantDetailValidator()
        {
            RuleFor(x => x.AccountantName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => AccountantDetailResources.AccountantDetail_AccountantName_Required)
                .Length(3, 30)
                .WithLocalizedMessage(() => AccountantDetailResources.AccountantDetail_AccountantName_Length);

            RuleFor(x => x.DateStarted)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => AccountantDetailResources.SelfEmployment_AccountantDetail_DateStarted_Required)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                .WithLocalizedMessage(() => AccountantDetailResources.SelfEmployment_AccountantDetail_DateStopped_After_1900)
                .LessThan(DateTime.Today)
                .WithLocalizedMessage(() => AccountantDetailResources.SelfEmployment_AccountantDetail_DateStarted_NotInFuture);

            RuleFor(x => x.DateStopped)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                .WithLocalizedMessage(() => AccountantDetailResources.SelfEmployment_AccountantDetail_DateStopped_After_1900)
                .LessThan(DateTime.Today)
                .WithLocalizedMessage(() => AccountantDetailResources.SelfEmployment_AccountantDetail_DateStopped_NotInFuture)
                .GreaterThanOrEqualTo(x => x.DateStarted)
                .WithLocalizedMessage(() => AccountantDetailResources.SelfEmployment_AccountantDetail_DateStopped_Not_Before_StartDate)
                .When(x => x.DateStopped.HasValue);

        }
    }
}