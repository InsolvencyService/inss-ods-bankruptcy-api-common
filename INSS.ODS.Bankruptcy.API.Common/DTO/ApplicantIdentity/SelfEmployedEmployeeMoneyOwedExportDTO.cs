using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class SelfEmployedEmployeeMoneyOwedExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string Reason { get; set; }
    }
}