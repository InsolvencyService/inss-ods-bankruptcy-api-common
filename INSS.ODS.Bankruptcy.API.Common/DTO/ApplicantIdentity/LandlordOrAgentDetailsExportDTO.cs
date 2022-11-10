using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class LandlordOrAgentDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public AddressExportDTO Address { get; set; }
    }
}