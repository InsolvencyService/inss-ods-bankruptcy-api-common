using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ExpenseExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Value { get; set; }

        [DataMember]
        public string Frequency { get; set; }

        [DataMember]
        public string Type { get; set; }
    }
}