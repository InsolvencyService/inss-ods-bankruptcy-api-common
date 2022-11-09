using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Debt
{
    [DataContract]
    public class PreferredCreditorDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PreferentialPaymentId { get; set; }

        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public string CreditorName { get; set; }

        [DataMember]
        public AddressDto CreditorAddress { get; set; }
    }
}