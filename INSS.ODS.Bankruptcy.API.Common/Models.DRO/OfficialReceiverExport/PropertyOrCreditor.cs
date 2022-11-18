namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

public class PropertyOrCreditor
{
    public List<PropertyTransaction> PropertyTransactions { get; set; }
    public string PropertyTransactionComment { get; set; }
    public List<PreferredCreditor> PreferredCreditors { get; set; }
    public string PreferredCreditorComment { get; set; }

}
