using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PropertyJointOwnerDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PropertyId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string OtherRelationship { get; set; }

        [DataMember]
        public string Relationship { get; set; }

        [DataMember]
        public double JointOwnerShare { get; set; }
    }
}