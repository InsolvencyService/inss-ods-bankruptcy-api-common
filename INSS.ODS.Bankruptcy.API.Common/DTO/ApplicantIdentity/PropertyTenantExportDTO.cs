using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PropertyTenantExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PropertyId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}