using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.DebtHistory
{
    public class PreferentialPaymentHistoryViewModel
    {
        public PreferredCreditorViewModel PreferredCreditor { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string AssetName { get; set; }
    }
}
