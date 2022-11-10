using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class OtherIncomeDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string AmountFrequency { get; set; }
    }
}