using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.BankAccountsAndSavings
{
    public class BankAccountViewModel
    {
        public BankDetailsViewModel BankDetails { get; set; }

        public AccountDetailsViewModel AccountDetails { get; set; }

        public List<JointOwnerViewModel> JointOwners { get; set; }
    }
}