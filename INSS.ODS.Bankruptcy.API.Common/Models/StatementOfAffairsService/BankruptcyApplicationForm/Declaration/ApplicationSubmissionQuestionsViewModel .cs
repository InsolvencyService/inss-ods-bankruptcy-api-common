using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Declaration
{
    public class ApplicationSubmissionQuestions
    {
        public bool? IncludedDebtsFromAnotherApplication { get; set; }
        public bool? SpokenToDebtAdvisor { get; set; }
        public bool? AppliedForPAVOrder { get; set; }
    }
}
