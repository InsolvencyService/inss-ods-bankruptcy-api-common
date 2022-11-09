using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PersonalDetailsAdditionalExportDTO 
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NationalInsuranceNumber { get; set; }

        [DataMember]
        public string RelationshipStatus { get; set; }

        [DataMember]
        public string Gender { get; set; }
    }
}