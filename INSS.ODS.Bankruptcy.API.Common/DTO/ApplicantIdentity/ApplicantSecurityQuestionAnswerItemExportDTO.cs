using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ApplicantSecurityQuestionAnswerItemExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SecurityQuestion { get; set; }

        [DataMember]
        public string SecurityAnswer { get; set; }
    }
}