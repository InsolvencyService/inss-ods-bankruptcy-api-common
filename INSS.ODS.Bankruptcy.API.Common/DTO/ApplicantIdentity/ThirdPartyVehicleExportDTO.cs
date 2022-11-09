using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ThirdPartyVehicleExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string OwnerName { get; set; }

        [DataMember]
        public string RelationshipType { get; set; }

        [DataMember]
        public string RelationshipTypeOther { get; set; }
    }
}