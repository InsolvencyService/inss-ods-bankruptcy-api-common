using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class ManagingAgentAddressDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string AgentName { get; set; }

        [DataMember]
        public Address AgentAddress { get; set; }
    }
}