using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Debt
{
    [DataContract]
    public class PreferentialPaymentDetailDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PreferentialPaymentId { get; set; }


        [DataMember]
        public DateTime? PaymentDate { get; set; }

        [DataMember]
        public decimal? PaymentAmount { get; set; }

        [DataMember]
        public string AssetName { get; set; }
    }
}