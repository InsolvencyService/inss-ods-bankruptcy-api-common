using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public class PreferredCreditor
    {
        public string NameOfPreferredCreditor { get; set; }

        public string WhoDidYouSellItem { get; set; }

        public DateTime? DateOfPayment { get; set; }

        public decimal? HowMuchPaid { get; set; }

        public string WhyDidYouMakeThePayment { get; set; }

        public bool? SeekHelpBeforePayment { get; set; }
    }
}