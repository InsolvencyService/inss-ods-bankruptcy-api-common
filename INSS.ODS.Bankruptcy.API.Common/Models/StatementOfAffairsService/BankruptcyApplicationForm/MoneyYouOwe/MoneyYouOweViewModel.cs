using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.MoneyYouOwe.Creditor;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.MoneyYouOwe
{
    public class MoneyYouOweViewModel
    {
        public List<CreditorViewModel> UnsecuredCreditors { get; set; }
    }
}
