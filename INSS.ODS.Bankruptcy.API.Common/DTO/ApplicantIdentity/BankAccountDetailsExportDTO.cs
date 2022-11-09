using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class BankAccountDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public decimal? CurrentBalance { get; set; }

        [DataMember]
        public DateTime DateOpened { get; set; }

        [DataMember]
        public bool? JointAccount { get; set; }

        [DataMember]
        public BankDetailsExportDTO BankDetails { get; set; }

        [DataMember]
        public bool? IsMainAccount { get; set; }
    }
}