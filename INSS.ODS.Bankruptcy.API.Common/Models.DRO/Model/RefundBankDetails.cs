namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class RefundBankDetails
{
    public int Id { get; set; }
    public int ApplicationID { get; set; }
    public string SortCode { get; set; }
    public string AccountNumber { get; set; }
    public string BankName { get; set; }
    public string AccountHolder { get; set; }
}
