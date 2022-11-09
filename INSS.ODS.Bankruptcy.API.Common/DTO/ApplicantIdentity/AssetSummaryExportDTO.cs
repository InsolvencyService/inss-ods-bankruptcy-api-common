using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class AssetSummaryExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? HasProperty { get; set; }

        [DataMember]
        public bool? HasVehicle { get; set; }

        [DataMember]
        public bool? HasInsurance { get; set; }

        [DataMember]
        public bool? HasOtherAssets { get; set; }
    }
}