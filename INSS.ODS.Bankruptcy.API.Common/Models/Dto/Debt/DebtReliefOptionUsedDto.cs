using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Debt
{
    [DataContract]
    public class DebtReliefOptionUsedDto
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
