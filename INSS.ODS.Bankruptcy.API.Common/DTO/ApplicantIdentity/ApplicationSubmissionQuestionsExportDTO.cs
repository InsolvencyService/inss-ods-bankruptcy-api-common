using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ApplicationSubmissionQuestionsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? IncludedDebtsFromAnotherApplication { get; set; }

        [DataMember]
        public bool? SpokenToDebtAdvisor { get; set; }

        [DataMember]
        public bool? AppliedForPAVOrder { get; set; }
    }
}