using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.OtherIncomes
{
    public class OtherIncomeViewModel
    {
        public string Source { get; set; }
        public RecurringPayment OtherIncome { get; set; }
        public decimal? Total { get; set; }
    }
}
