using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.SavingsFinesOtherCosts
{
    public class SavingsFinesOtherCostsViewModel
    {
        public decimal? Savings { get; set; }
        public string Savings_Frequency { get; set; }
        public List<FineViewModel> CourtFines { get; set; }
        public List<ExpenseViewModel> Expenses { get; set; }
        public decimal? Total { get; set; }
    }
}
