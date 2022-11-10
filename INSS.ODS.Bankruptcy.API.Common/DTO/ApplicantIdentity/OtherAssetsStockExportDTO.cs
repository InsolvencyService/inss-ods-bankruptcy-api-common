using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class OtherAssetsStockExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}