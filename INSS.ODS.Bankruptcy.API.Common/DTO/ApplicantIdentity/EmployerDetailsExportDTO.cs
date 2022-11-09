using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class EmployerDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string EmployerName { get; set; }

        [DataMember]
        public AddressExportDTO EmployerAddress { get; set; }

        [DataMember]
        public DateTime? DateStarted { get; set; }

        [DataMember]
        public DateTime? DateStopped { get; set; }
    }
}