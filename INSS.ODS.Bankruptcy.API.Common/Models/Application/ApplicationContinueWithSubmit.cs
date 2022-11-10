using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{

    [DataContract]
    [Validator(typeof(ApplicationSubmissionQuestionsValidator))]
    public class ApplicationSubmissionQuestions : IApplicationSubmissionQuestions, ITableBase
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