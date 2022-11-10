using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class BankDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string BankName { get; set; }

        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string AddressLine3 { get; set; }

        [DataMember]
        public string TownCity { get; set; }

        [DataMember]
        public string County { get; set; }

        [DataMember]
        public string PostCode { get; set; }

        [DataMember]
        public bool IsManualEntry { get; set; }
    }
}