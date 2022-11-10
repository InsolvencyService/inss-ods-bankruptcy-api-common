using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class LegalProceedingsSummaryInfoExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? HasSeparated { get; set; }

        [DataMember]
        public bool? HasOngoingLegalClaims { get; set; }
    }
}