using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class DependentsNotLivingWithYouExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int? Age { get; set; }

        [DataMember]
        public AddressExportDTO Address { get; set; }

        [DataMember]
        public string Relationship { get; set; }

        [DataMember]
        public string RelationshipOther { get; set; }
    }
}