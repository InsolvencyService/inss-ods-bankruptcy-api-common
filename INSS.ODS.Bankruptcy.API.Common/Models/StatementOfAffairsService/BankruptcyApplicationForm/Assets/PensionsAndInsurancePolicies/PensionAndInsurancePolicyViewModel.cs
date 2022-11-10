using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.PensionsAndInsurancePolicies
{
    public class PensionAndInsurancePolicyViewModel
    {
        public PensionOrPolicyProviderDetailsViewModel PolicyProviderDetails { get; set; }

        public PensionOrPolicyDetailsViewModel PolicyDetails { get; set; }

        public PensionOrPolicyValueViewModel PensionOrPolicyValue { get; set; }

        public PensionOrPolicyPayoutDetailsViewModel PolicyPayoutDetails { get; set; }

        public List<PensionOrPolicyBeneficiaryDetailViewModel> PensionOrPolicyBeneficiaryDetails { get; set; }
    }
}