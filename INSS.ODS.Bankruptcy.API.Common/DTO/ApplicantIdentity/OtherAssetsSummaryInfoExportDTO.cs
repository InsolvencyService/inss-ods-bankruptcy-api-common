using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class OtherAssetsSummaryInfoExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool Cash { get; set; }

        [DataMember]
        public bool Possessions { get; set; }

        [DataMember]
        public bool Compensations { get; set; }

        [DataMember]
        public bool Wills { get; set; }

        [DataMember]
        public bool Stocks { get; set; }

        [DataMember]
        public bool SelfEmployedAssets { get; set; }

        [DataMember]
        public bool MoneyOwed { get; set; }

        [DataMember]
        public bool Items { get; set; }
    }
}