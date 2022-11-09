using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class SelfEmploymentIncomeExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Profit { get; set; }

        [DataMember]
        public string Profit_Frequency { get; set; }

        [DataMember]
        public DateTime? AccountingPeriodStart { get; set; }

        [DataMember]
        public DateTime? AccountingPeriodEnd { get; set; }
    }
}