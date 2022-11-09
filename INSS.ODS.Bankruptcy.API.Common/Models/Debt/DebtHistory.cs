using System.Collections.Generic;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Debt
{
    [DataContract]
    [Validator(typeof(DebtHistoryValidator))]
    public class DebtHistory : IDebtHistory, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? HasEnteredDebtIncurredDetails { get; set; }

        [DataMember]
        public bool? HasAnsweredDebtReliefOptionsUsedQuestion { get; set; }

        [DataMember]
        public bool? HasAnsweredDebtExtraPaymentsMadeQuestion { get; set; }
    }
}
