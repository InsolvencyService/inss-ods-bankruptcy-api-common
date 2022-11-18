using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;


[DataContract]
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