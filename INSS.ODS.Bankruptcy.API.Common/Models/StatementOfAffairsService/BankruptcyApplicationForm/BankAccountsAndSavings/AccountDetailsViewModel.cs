using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.BankAccountsAndSavings
{
    public class AccountDetailsViewModel
    {
        public string AccountNumber { get; set; }

        public decimal? CurrentBalance { get; set; }

        public DateTime? DateOpened { get; set; }

        public bool? IsJointAccount { get; set; }

        public bool? IsMainAccount { get; set; }
    }
}