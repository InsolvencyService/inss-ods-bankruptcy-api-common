namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

public class PensionDetail
{
    public string ProviderName { get; set; }
    public Address ProviderAddress { get; set; }
    public string PolicyNumber { get; set; }
    public bool? IsApprovedPension { get; set; }
    public bool? IsCurrentEmployerPension { get; set; }
    
}
