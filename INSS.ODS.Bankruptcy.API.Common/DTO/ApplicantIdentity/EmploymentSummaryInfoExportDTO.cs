using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class EmploymentSummaryInfoExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? HasBeenDirector { get; set; }

        [DataMember]
        public bool? HasBeenSelfEmployed { get; set; }

        [DataMember]
        public bool? HasBeenPartner { get; set; }

        [DataMember]
        public bool? HasBeenEmployed { get; set; }
    }
}