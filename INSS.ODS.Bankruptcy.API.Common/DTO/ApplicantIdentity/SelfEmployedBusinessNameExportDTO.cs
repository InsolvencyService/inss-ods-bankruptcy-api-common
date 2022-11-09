using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class SelfEmployedBusinessNameExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string BusinessName { get; set; }
    }
}