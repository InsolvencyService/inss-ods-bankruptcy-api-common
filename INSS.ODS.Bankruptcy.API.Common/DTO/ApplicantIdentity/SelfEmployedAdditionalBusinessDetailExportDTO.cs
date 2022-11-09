using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class SelfEmployedAdditionalBusinessDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string VATNumber { get; set; }

        [DataMember]
        public string UTR { get; set; }

        [DataMember]
        public string RecordsLocation { get; set; }
    }
}