using System;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.DebtHistory
{
    public class DebtHistoryViewModel
    {
        public List<BankruptcyHistoryViewModel> BankruptcyHistory { get; set; }
        public List<IndividualVoluntaryAgreementHistoryViewModel> IndividualVoluntaryAgreementHistory { get; set; }
        public List<PreferentialPaymentHistoryViewModel> PreferentialPayments { get; set; }
        public DateTime DateRealised { get; set; }
        public string Reasons { get; set; }
        public bool WasDueToGambling { get; set; }
        public decimal? GamblingAmount { get; set; }
    }
}
