using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.PensionsAndInsurancePolicies
{
    public class PensionOrPolicyProviderDetailsViewModel
    {
        public string ProviderName { get; set; }

        public AddressViewModel Address { get; set; }
    }
}