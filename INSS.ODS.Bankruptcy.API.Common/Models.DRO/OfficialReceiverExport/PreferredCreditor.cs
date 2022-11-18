namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

public class PreferredCreditor
{
    public string CreditorName { get; set; }
    public string WhoDidYouSellItem { get; set; }
    public DateTime PaymentDate { get ;set; }
    public decimal? PaymentAmount { get; set; }
    public string WhyDidYouMakeThePayment { get; set; }
    public bool? SeekHelpBeforePayment { get; set; }
}
