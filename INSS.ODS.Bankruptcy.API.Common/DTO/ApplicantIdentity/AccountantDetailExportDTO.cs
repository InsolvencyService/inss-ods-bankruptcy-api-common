using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class AccountantDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string AccountantName { get; set; }

        [DataMember]
        public AddressExportDTO AccountantAddress { get; set; }

        [DataMember]
        public DateTime DateStarted { get; set; }

        [DataMember]
        public DateTime? DateStopped { get; set; }
    }
}