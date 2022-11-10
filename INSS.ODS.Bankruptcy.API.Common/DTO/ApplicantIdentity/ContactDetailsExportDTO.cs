using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ContactDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string Telephone { get; set; }
    }
}