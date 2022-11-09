using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PolicyValueExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool CurrentlyReceivingPayment { get; set; }

        [DataMember]
        public decimal? CurrentWorth { get; set; }
    }
}