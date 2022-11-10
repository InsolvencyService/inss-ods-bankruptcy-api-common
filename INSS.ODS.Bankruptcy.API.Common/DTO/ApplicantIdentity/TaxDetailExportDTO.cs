using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class TaxDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UTR { get; set; }
    }
}