using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.PensionsAndInsurancePolicies
{
    public class PensionOrPolicyBeneficiaryDetailViewModel : PersonNameViewModel
    {
        public string RelationshipToApplicant { get; set; }

        public decimal? BeneficiaryShare { get; set; }
    }
}