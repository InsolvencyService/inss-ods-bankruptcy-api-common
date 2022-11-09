using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class OwnVehicleExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Price { get; set; }

        [DataMember]
        public bool UsageAsWorkCommute { get; set; }

        [DataMember]
        public bool UsageAsToSchool { get; set; }

        [DataMember]
        public bool UsageAsRelativeCare { get; set; }

        [DataMember]
        public bool UsageAsSocialising { get; set; }

        [DataMember]
        public bool UsageOther { get; set; }

        [DataMember]
        public string UsageOtherText { get; set; }
    }
}