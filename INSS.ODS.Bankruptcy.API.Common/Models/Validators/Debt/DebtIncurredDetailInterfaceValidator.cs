using System;
using System.Security.Cryptography.X509Certificates;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt
{
    public class DebtIncurredDetailInterfaceValidator : AbstractValidator<IDebtIncurredDetail>
    {
        public DebtIncurredDetailInterfaceValidator()
        {

            RuleFor(x => x.ReasonsForPersonalDebt)
               .Must(x => false)
               .When(x => !String.IsNullOrWhiteSpace(x.PersonalOtherText))
               .Unless(x => x.PersonalOther)
               .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_Reason_Error_OtherText);

            RuleFor(x => x.ReasonsForBusinessDebt)
              .Must(x => false)
              .When(x => !String.IsNullOrWhiteSpace(x.BusinessOtherText))
              .Unless(x => x.BusinessOther)
              .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_Reason_Error_OtherText);

            RuleFor(x => x.StartDate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_StartDate_Error_Empty)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_StartDate_Error_MinimumDate)
                .LessThanOrEqualTo(DateTime.Today)
                .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_StartDate_Error_InTheFuture);



            RuleFor(x => x.DebtIncurredReasonValidationHook)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(HaveAtLeastOneReasonSelected)
                .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_ReasonForDebt_Error_AtLeastOneReasonNeedsToBeSelected);

            RuleFor(x => x.PersonalDebtIncurredReasonValidationHook)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(HavePersonalOtherReasonSpecified)
                .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalOtherText_Error_RequiredWhenOtherReasonSelected)
                .Must(HavePersonalOtherReasonValidLength)
                .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalOtherText_Error_Length)
                .When(x => x.PersonalOther);

            RuleFor(x => x.BusinessDebtIncurredReasonValidationHook)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(HaveBusinessOtherReasonSpecified)
                .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessOtherText_Error_RequiredWhenOtherReasonSelected)
                .Must(HaveBusinessOtherReasonValidLength)
                .WithLocalizedMessage(() => DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessOtherText_Error_Length)
                .When(x => x.BusinessOther);

            RuleFor(x => x.GamblingAmount)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(
                    () =>
                        DebtIncurredDetailResources
                            .Debt_DebtIncurredDetail_Amount_Error_RequiredWhenGamblingReasonSelected)
            .When(x => x.PersonalGambling);

            RuleFor(x => x.GamblingAmount)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .GreaterThan(0)
                .WithLocalizedMessage(
                    () => DebtIncurredDetailResources.Debt_DebtIncurredDetail_Amount_Error_InvalidValue)
                .When(x => x.GamblingAmount.HasValue);
        }

        private bool HavePersonalOtherReasonSpecified(IDebtIncurredDetail instance, bool personalDebtIncurredReasonValidationHook)
        {
            return !string.IsNullOrWhiteSpace(instance.PersonalOtherText);
        }

        private bool HavePersonalOtherReasonValidLength(IDebtIncurredDetail instance, bool personalDebtIncurredReasonValidationHook)
        {
            return (instance.PersonalOtherText.Length >= 1) && (instance.PersonalOtherText.Length <= 50);
        }

        private bool HaveBusinessOtherReasonSpecified(IDebtIncurredDetail instance, bool businessDebtIncurredReasonValidationHook)
        {
            return !string.IsNullOrWhiteSpace(instance.BusinessOtherText);
        }

        private bool HaveBusinessOtherReasonValidLength(IDebtIncurredDetail instance, bool businessDebtIncurredReasonValidationHook)
        {
            return (instance.BusinessOtherText.Length >= 1) && (instance.BusinessOtherText.Length <= 50);
        }

        private bool HaveAtLeastOneReasonSelected(IDebtIncurredDetail instance, bool debtIncurredReasonValidationHook)
        {
            if (instance.ShowPersonalAndBusinessDebtIncurredReasons)
            {
                return (instance.PersonalRelationshipBreakdown
                        || instance.PersonalSpendingMoreThanEarning
                        || instance.PersonalIllnessOrAccident
                        || instance.PersonalRedundancyOrLostJob
                        || instance.PersonalReducedEmployment
                        || instance.PersonalReductionInIncome
                        || instance.PersonalReductionInHouseholdIncome
                        || instance.PersonalIncreasedInterestRates
                        || instance.PersonalGambling
                        || instance.PersonalVictimOfFraud
                        || instance.PersonalDrugsAndOrAlchohol
                        || instance.PersonalOther
                        || instance.BusinessLossOfCustomerOrMarket
                        || instance.BusinessCustomersFailedToPay
                        || instance.BusinessLossOfFinancialBacking
                        || instance.BusinessFailedToDealWithTaxes
                        || instance.BusinessTooHighOverheads
                        || instance.BusinessVictimOfBusinessFraud
                        || instance.BusinessOther);
            }
            else
            {
                return (instance.PersonalRelationshipBreakdown
                        || instance.PersonalSpendingMoreThanEarning
                        || instance.PersonalIllnessOrAccident
                        || instance.PersonalRedundancyOrLostJob
                        || instance.PersonalReducedEmployment
                        || instance.PersonalReductionInIncome
                        || instance.PersonalReductionInHouseholdIncome
                        || instance.PersonalIncreasedInterestRates
                        || instance.PersonalGambling
                        || instance.PersonalVictimOfFraud
                        || instance.PersonalDrugsAndOrAlchohol
                        || instance.PersonalOther);
            }

        }
    }
}
