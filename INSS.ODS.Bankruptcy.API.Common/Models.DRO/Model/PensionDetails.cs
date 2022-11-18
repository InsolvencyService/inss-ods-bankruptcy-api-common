namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class PensionDetails
{
    public int Id { get; set; }

    public int? PensionId { get; set; }

    public string Policynumber { get; set; }

    public string PensionProviderName { get; set; }

    public bool? ApprovedPension { get; set; }

    public bool? CurrentEmployerPension { get; set; }

    public bool? PersonalPension { get; set; }

    public decimal? ValueOfPension { get; set; }

    public bool? ReceivePaymentFromPension { get; set; }


    public LegacyAddress PensionAddress { get; set; }
}
