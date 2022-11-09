namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.PensionsAndInsurancePolicies
{
    public class PensionOrPolicyValueViewModel
    {
        public bool? IsApplicantCurrentlyReceivingPayments { get; set; }

        public decimal? Value { get; set; }
    }
}