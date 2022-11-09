using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties
{
    public class PropertyCreditorViewModel
    {
        public string CreditorName { get; set; }

        public AddressViewModel Address { get; set; }
    }
}