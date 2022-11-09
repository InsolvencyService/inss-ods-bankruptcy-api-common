using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PreferentialPaymentExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public PreferredCreditorExportDTO PreferredCreditor { get; set; }

        [DataMember]
        public PreferredCreditorRelationshipExportDTO PreferredCreditorRelationship { get; set; }

        [DataMember]
        public PreferentialPaymentDetailExportDTO PreferentialPaymentDetail { get; set; }
    }
}