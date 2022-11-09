using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class AmountYouOweExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public string DebtType { get; set; }

        [DataMember]
        public string DebtTypeOther { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }
    }
}