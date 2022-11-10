namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.SoldTransferedOrGiftedAssets
{
    public class SoldTransferedOrGiftedAssetsViewModel
    {
        public bool? HasApplicantSoldTransferredOrGivenAwayPropertyInTheLast5Years { get; set; }

        public bool? HasApplicantSoldTransferredOrGivenAwayPensionsOrPoliciesInTheLast5Years { get; set; }

        public bool? HasApplicantSoldTransferredOrGivenAwayAssetsWorthMoreThan500InTheLast5Years { get; set; }
    }
}