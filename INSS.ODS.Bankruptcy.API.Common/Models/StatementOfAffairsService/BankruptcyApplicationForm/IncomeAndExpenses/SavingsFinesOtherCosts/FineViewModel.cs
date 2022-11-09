using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.SavingsFinesOtherCosts
{
    public class FineViewModel
    {
        public decimal? Value { get; set; }
        public string Frequency { get; set; }
        public string Type { get; set; }
    }
}
