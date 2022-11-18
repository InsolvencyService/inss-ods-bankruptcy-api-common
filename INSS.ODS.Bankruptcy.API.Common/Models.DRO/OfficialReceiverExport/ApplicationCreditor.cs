namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

public class ApplicationCreditor
{
    public decimal? Amount { get; set; }
    public string AccountReference { get; set; }
    public bool? SecuredCreditor { get; set; }
    public string ItemSecured { get; set; }
    public decimal? SecuredValue { get; set; }
    public int ISCISCreditorId { get; set; }
    public string OrganisationType { get; set; }
    public string CreditorName { get; set; }
    public Address Address { get; set; }
    public bool? ExcludedDebt { get; set; }
    public bool? EarningsOrder { get; set; }
    public string EarningsOrderCourtName { get; set; }
    public string EarningsOrderCourtReference { get; set; }
    public Address EarningsOrderCourtAddress { get; set; }
}
