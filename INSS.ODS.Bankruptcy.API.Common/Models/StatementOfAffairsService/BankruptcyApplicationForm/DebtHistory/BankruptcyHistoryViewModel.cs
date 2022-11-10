using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.DebtHistory
{
    public class BankruptcyHistoryViewModel
    {
        public string OptionType { get; set; }
        public DateTime StartDate { get; set; }
        public string ReferenceNumber { get; set; }
    }
}