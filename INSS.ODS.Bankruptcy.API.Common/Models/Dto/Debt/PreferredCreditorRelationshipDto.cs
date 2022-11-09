using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Debt
{
    [DataContract]
    public class PreferredCreditorRelationshipDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PreferentialPaymentId { get; set; }

        [DataMember]
        public string RelationshipToYou { get; set; }

        [DataMember]
        public string RelationshipToYouOther { get; set; }

        [DataMember]
        public string CreditorName { get; set; }
    }
}