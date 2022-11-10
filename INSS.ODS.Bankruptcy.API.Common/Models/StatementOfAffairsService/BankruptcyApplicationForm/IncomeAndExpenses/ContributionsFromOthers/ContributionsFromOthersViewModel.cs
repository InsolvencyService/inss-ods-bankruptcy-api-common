using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.ContributionsFromOthers
{
    public class ContributionsFromOthersViewModel
    {
        public RecurringPayment HouseholdPersonContribution { get; set; }
        public decimal? Total { get; set; }

    }
}
