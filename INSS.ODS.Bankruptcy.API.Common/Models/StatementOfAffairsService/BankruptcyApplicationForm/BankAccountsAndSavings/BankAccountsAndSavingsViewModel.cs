using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.BankAccountsAndSavings
{
    public class BankAccountsAndSavingsViewModel
    {
        public bool? DoesApplicantHaveAnyBankAccounts { get; set; }

        public List<BankAccountViewModel> BankAccounts { get; set; }
    }
}
