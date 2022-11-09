using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PreferredCreditorRelationshipExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string RelationshipToYou { get; set; }

        [DataMember]
        public string RelationshipToYouOther { get; set; }
    }
}