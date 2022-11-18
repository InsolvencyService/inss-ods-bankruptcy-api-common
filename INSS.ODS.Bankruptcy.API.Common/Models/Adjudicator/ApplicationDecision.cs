namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator;

public class ApplicationDecision
{
    public DateTime DecisionDate { get; set; }
    public string Status { get; set; }
    public string BKTReference { get; set; }
    public string ADJReference { get; set; }
    public decimal AdminFee { get; set; }
    public decimal AdjFee { get; set; }
    public string PaymentType { get; set; }
}
