using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;
using INSS.ODS.API.Common.Utilities.Types;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Debt
{
    [DataContract]
    [Validator(typeof(DebtIncurredDetailInterfaceValidator))]
    public class DebtIncurredDetail : IDebtIncurredDetail, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [NotMapped]
        public bool DebtIncurredReasonValidationHook { get; set; }
        
        [NotMapped]
        public bool PersonalDebtIncurredReasonValidationHook { get; set; }

        [NotMapped]
        public bool BusinessDebtIncurredReasonValidationHook { get; set; }

        [NotMapped]
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


        [NotMapped]
        public CheckboxList ReasonsForPersonalDebt { get; set; }

        [NotMapped]
        public CheckboxList ReasonsForBusinessDebt { get; set; }

        [NotMapped]
        public string ReasonsForDebtOther { get; set; }

        public DebtIncurredDetail()
        {
            ReasonsForPersonalDebt = new CheckboxList();
            ReasonsForBusinessDebt = new CheckboxList();
        }


    }
}
