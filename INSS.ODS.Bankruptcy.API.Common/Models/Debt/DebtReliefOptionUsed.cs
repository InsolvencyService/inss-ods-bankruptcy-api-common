using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Debt
{
    [DataContract]
    public class DebtReliefOptionUsed : IDebtReliefOptionUsed, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string DebtReliefOptionType { get; set; }

        [DataMember]
        public DateTime DebtReliefOptionStartDate { get; set; }

        [DataMember]
        public string DebtReliefOptionReferenceNumber { get; set; }
    }
}
