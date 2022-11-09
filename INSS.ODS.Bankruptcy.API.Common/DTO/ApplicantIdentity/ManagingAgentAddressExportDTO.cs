using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ManagingAgentAddressExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public AddressExportDTO AgentAddress { get; set; }

        [DataMember]
        public string AgentName { get; set; }
    }
}