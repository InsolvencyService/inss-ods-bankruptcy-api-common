using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Debt
{
    [DataContract]
    public class DebtHistoryDto
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
