using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PolicyIncomeExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PolicyMainId { get; set; }

        [DataMember]
        public decimal? IncomeAmount { get; set; }

        [DataMember]
        public string IncomeFrequency { get; set; }
    }
}