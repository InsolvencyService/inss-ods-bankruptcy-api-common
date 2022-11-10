using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Debt
{
    [DataContract]
    public class PreferentialPaymentSummaryDto
    {
        [DataMember]
        public int PreferentialPaymentId { get; set; }

        [DataMember]
        public bool IsManualCreditorEntry { get; set; }

        [DataMember]
        public string CreditorName { get; set; }

        [DataMember]
        public DateTime? PaymentDate { get; set; }

        [DataMember]
        public decimal PaymentAmount { get; set; }
    }
}