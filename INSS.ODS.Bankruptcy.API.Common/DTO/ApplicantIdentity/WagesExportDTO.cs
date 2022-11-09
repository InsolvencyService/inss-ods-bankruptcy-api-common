using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class WagesExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? NetIncome { get; set; }

        [DataMember]
        public string NetIncome_Frequency { get; set; }

        [DataMember]
        public decimal? IncomeTax { get; set; }

        [DataMember]
        public string IncomeTax_Frequency { get; set; }

        [DataMember]
        public decimal? OverTime { get; set; }

        [DataMember]
        public string OverTime_Frequency { get; set; }

        [DataMember]
        public decimal? Bonus { get; set; }

        [DataMember]
        public string Bonus_Frequency { get; set; }

        [DataMember]
        public decimal? OtherPayments { get; set; }

        [DataMember]
        public string OtherPayments_Frequency { get; set; }
    }
}