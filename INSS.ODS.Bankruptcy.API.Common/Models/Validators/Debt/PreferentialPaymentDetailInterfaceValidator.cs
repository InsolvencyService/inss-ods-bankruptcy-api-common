using System;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Shared.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt
{
    public class PreferentialPaymentDetailInterfaceValidator : AbstractValidator<IPreferentialPaymentDetail>
    {
        public PreferentialPaymentDetailInterfaceValidator()
        {
            RuleFor(x => x.PaymentDate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .Must(DateValidationHelper.BeAValidDate)
                .WithLocalizedMessage(() => PreferentialPaymentDetailsResources.Debt_PreferentialPaymentDetails_PaymentDate_Error_Empty)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                .WithLocalizedMessage(() => PreferentialPaymentDetailsResources.Debt_PreferentialPaymentDetails_PaymentDate_Error_MinimumDate)
                .LessThanOrEqualTo(DateTime.Today)
                .WithLocalizedMessage(() => PreferentialPaymentDetailsResources.Debt_PreferentialPaymentDetails_PaymentDate_Error_InTheFuture);




            RuleFor(x => x.PaymentAmount)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => PreferentialPaymentDetailsResources.Debt_PreferentialPaymentDetails_PaymentAmount_Error_Empty)
                .NotNull()
                .WithLocalizedMessage(() => PreferentialPaymentDetailsResources.Debt_PreferentialPaymentDetails_PaymentAmount_Error_Empty)
                .GreaterThan(0)
                .WithLocalizedMessage(() => PreferentialPaymentDetailsResources.Debt_PreferentialPaymentDetails_PaymentAmount_Error_InvalidValue);

            RuleFor(x => x.AssetName)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .Must(relationshipToYou => ValidationLengthHelper.HaveLengthGreaterThan(relationshipToYou, 1))
              .WithLocalizedMessage(() => PreferentialPaymentDetailsResources.Debt_PreferentialPaymentDetails_AssetName_Error_TooShort)
              .Must(relationshipToYou => ValidationLengthHelper.HaveLengthLessThan(relationshipToYou, 61))
              .WithLocalizedMessage(() => PreferentialPaymentDetailsResources.Debt_PreferentialPaymentDetails_AssetName_Error_TooLong)
              .When(x => !string.IsNullOrWhiteSpace(x.AssetName));
        }
    }
}
