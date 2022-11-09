using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class RecoveriesSummaryExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? HasSoldProperties { get; set; }

        [DataMember]
        public bool? HasSoldLifeInsurancePolicies { get; set; }

        [DataMember]
        public bool? HasSoldAssets { get; set; }
    }
}