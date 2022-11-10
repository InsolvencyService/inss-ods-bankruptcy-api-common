using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PartnershipBusinessNameExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string BusinessName { get; set; }
    }
}