using INSS.ODS.API.Common.Utilities.Types;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt
{
    public interface IDebtIncurredDetail
    {
        DateTime StartDate { get; set; }

        bool DebtIncurredReasonValidationHook { get; set; }

        bool PersonalDebtIncurredReasonValidationHook { get; set; }

        bool BusinessDebtIncurredReasonValidationHook { get; set; }

        bool ShowPersonalAndBusinessDebtIncurredReasons { get; set; }

        bool PersonalRelationshipBreakdown { get; set; }

        bool PersonalSpendingMoreThanEarning { get; set; }

        bool PersonalIllnessOrAccident { get; set; }

        bool PersonalRedundancyOrLostJob { get; set; }

        bool PersonalReducedEmployment { get; set; }

        bool PersonalReductionInIncome { get; set; }

        bool PersonalReductionInHouseholdIncome { get; set; }

        bool PersonalIncreasedInterestRates { get; set; }

        bool PersonalGambling { get; set; }

        bool PersonalVictimOfFraud { get; set; }

        bool PersonalDrugsAndOrAlchohol { get; set; }

        bool PersonalOther { get; set; }

        string PersonalOtherText { get; set; }

        bool BusinessLossOfCustomerOrMarket { get; set; }

        bool BusinessCustomersFailedToPay { get; set; }

        bool BusinessLossOfFinancialBacking { get; set; }

        bool BusinessFailedToDealWithTaxes { get; set; }

        bool BusinessTooHighOverheads { get; set; }

        bool BusinessVictimOfBusinessFraud { get; set; }

        bool BusinessOther { get; set; }

        string BusinessOtherText { get; set; }

        decimal? GamblingAmount { get; set; }

        CheckboxList ReasonsForPersonalDebt { get; }

        CheckboxList ReasonsForBusinessDebt { get; }
    }
}
