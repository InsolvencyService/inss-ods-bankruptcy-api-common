namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public class PensionDetails
    {
        public string Policynumber { get; set; }

        public string PensionProviderName { get; set; }

        public bool? ApprovedPension { get; set; }

        public bool? CurrentEmployerPension { get; set; }
        
        public bool? PersonalPension { get; set; }

        public decimal? ValueOfPension { get; set; }

        public bool? ReceivePaymentFromPension { get; set; }


        public Address PensionAddress { get; set; }
    }
}
