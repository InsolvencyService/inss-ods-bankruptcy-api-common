namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class EssentialTool
{
    public int Id { get; set; }

    public string Description { get; set; }

    public string Condition { get; set; }
    
    public decimal? Value { get; set; }

    public DateTime? DatePurchased { get; set; }
}