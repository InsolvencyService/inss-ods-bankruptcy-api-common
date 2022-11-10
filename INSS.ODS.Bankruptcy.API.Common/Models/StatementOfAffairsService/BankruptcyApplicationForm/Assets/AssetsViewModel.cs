using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.OtherItems;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.PensionsAndInsurancePolicies;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.SoldTransferedOrGiftedAssets;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Vehicles;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets
{
    public class AssetsViewModel
    {
        public bool? DoesApplicantOwnOrHaveFinancialInterestsInProperties { get; set; }

        public List<PropertyViewModel> Properties { get; set; }

        public bool? HasApplicantOwnedOrRegularlyUsedVehicleInLast12Months { get; set; }

        public List<VehicleViewModel> Vehicles { get; set; }

        public bool? DoesApplicantHaveAnyPensionEndowmentOrLifeInsurancePolicies { get; set; }

        public List<PensionAndInsurancePolicyViewModel> PensionsAndInsurancePolicies { get; set; }

        public bool? DoesApplicantHaveAnyOtherItems { get; set; }

        public OtherItemsViewModel OtherItems { get; set; }

        public SoldTransferedOrGiftedAssetsViewModel SoldTransferedOrGiftedAssets { get; set; }
    }
}
