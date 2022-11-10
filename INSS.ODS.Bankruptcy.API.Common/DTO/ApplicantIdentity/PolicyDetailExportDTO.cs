using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PolicyDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CommencementDate { get; set; }

        [DataMember]
        public string PolicyReferenceNo { get; set; }

        [DataMember]
        public string PolicyType { get; set; }

        [DataMember]
        public string PolicyTypeOther { get; set; }
    }
}