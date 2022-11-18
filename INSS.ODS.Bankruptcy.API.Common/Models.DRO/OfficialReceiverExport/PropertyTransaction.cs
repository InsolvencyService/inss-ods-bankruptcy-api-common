namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

public class PropertyTransaction
{
    public string WhatWasGivenAway { get; set; }
    public DateTime DateGivenAway { get; set; }
    public decimal ValueOfItem { get; set; }
    public decimal AmountReceived { get; set; }
    public string SellingReason { get; set; }
    public string SoldTo { get; set; }
}
