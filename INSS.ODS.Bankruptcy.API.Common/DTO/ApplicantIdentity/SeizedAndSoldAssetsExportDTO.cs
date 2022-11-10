using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class SeizedAndSoldAssetsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public decimal? ItemValue { get; set; }

        [DataMember]
        public bool? ItemSold { get; set; }
    }
}