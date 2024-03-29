﻿namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class PreviousTrading
{
    public int? PreviousTradingID { get; set; }

    public LegacyAddress BusinessAddress { get; set; }

    public string PreviousTradingName { get; set; }

    public bool? SoleTrader { get; set; }

    public DateTime? DateTradingCeased { get; set; }
}
