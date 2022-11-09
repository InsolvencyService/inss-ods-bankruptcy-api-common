using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class AttachmentOfEarningsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string HowOftenTaken { get; set; }

        [DataMember]
        public decimal? AmountTaken { get; set; }
    }
}