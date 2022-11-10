using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class EmploymentStatusExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Status { get; set; }
    }
}