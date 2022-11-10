using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PropertyDebtDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PropertyId { get; set; }

        [DataMember]
        public string DebtType { get; set; }

        [DataMember]
        public string ReferenceNumber { get; set; }

        [DataMember]
        public DateTime DebtStartDate { get; set; }

        [DataMember]
        public decimal? AmountOwe { get; set; }

        [DataMember]
        public string IsJointDebt { get; set; }

        [DataMember]
        public int CreditorId { get; set; }
    }
}