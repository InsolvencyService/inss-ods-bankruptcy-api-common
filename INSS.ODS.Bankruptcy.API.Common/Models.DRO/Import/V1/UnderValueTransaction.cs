using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class UnderValueTransaction
    {
        public string ItemDescription { get; set; }

        public DateTime? DateSoldOrGivenAway { get; set; }

        public decimal? HowMuchReceivedForAsset { get; set; }

        public string WhyDidYouSellOrGiveAway { get; set; }

        public string WhoDidYouSellOrGiveTo { get; set; }

        public decimal? WhatWasTheMarketValueOfTheAsset { get; set; }

        public string WhatHappenedToTheProceedsOfTheSale { get; set; }

        public string ProvideAnyFurtherDetails { get; set; }
    }
}
