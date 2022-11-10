using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.BankAccountsAndSavings
{
    public class BankDetailsViewModel
    {
        public string SortCode { get; set; }

        public string BankName { get; set; }

        public AddressViewModel Address { get; set; }
    }
}