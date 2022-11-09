using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Debt
{
    [DataContract]
    public class DebtIncurredDetailDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool ShowPersonalAndBusinessDebtIncurredReasons { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public bool PersonalRelationshipBreakdown { get; set; }

        [DataMember]
        public bool PersonalSpendingMoreThanEarning { get; set; }

        [DataMember]
        public bool PersonalIllnessOrAccident { get; set; }

        [DataMember]
        public bool PersonalRedundancyOrLostJob { get; set; }

        [DataMember]
        public bool PersonalReducedEmployment { get; set; }

        [DataMember]
        public bool PersonalReductionInIncome { get; set; }

        [DataMember]
        public bool PersonalReductionInHouseholdIncome { get; set; }

        [DataMember]
        public bool PersonalIncreasedInterestRates { get; set; }

        [DataMember]
        public bool PersonalGambling { get; set; }

        [DataMember]
        public bool PersonalVictimOfFraud { get; set; }

        [DataMember]
        public bool PersonalDrugsAndOrAlchohol { get; set; }

        [DataMember]
        public bool PersonalOther { get; set; }

        [DataMember]
        public string PersonalOtherText { get; set; }

        [DataMember]
        public bool BusinessLossOfCustomerOrMarket { get; set; }

        [DataMember]
        public bool BusinessCustomersFailedToPay { get; set; }

        [DataMember]
        public bool BusinessLossOfFinancialBacking { get; set; }

        [DataMember]
        public bool BusinessFailedToDealWithTaxes { get; set; }

        [DataMember]
        public bool BusinessTooHighOverheads { get; set; }

        [DataMember]
        public bool BusinessVictimOfBusinessFraud { get; set; }

        [DataMember]
        public bool BusinessOther { get; set; }

        [DataMember]
        public string BusinessOtherText { get; set; }

        [DataMember]
        public decimal? GamblingAmount { get; set; }
    }
}
