namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class FeeInfo
{
    public string ApplicantEmail { get; set; }
    public string ApplicantFirstName { get; set; }
    public string ApplicantLastName { get; set; }
    public bool IncludeAddress { get; set; }
    public LegacyAddress ApplicantAddress { get; set; }
    public decimal FeeAmount { get; set; }
    public decimal AmountPaid { get; set; }
    public decimal AmountOutstanding
    {
        get { return FeeAmount - AmountPaid; }
    }
    public string DroReference { get; set; }
    public DateTime? LastPaymentUpdate { get; set; }
    public List<KeyValuePair<string, decimal>> PaymentsByType { get; set; }
}
