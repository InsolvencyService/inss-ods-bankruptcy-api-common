namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public class Creditor
    {
        public string CreditorReference { get; set; }

        public string CreditorName { get; set; }

        public decimal? AmountOwed { get; set; }

        public bool? ExcludedDebt { get; set; }

        public bool? SecuredDebt { get; set; }

        public bool? AttachmentOfEarnings { get; set; }

        public Address CreditorAddress { get; set; }
        public string ItemDebtSecuredOn { get; set; }

        public decimal? ValueOfItemDebtSecuredOn { get; set; }

        public string CourtName { get; set; }

        public string CourtReference { get; set; }

        public Address CourtAddress { get; set; }
    }
}
