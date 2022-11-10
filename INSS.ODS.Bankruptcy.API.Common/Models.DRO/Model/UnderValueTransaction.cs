using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model
{
    public class UnderValueTransaction
    {
        public int? TransactionId { get; set; }

        public string ItemDescription { get; set; }

        public DateTime? DateSoldOrGivenAway { get; set; }

        public decimal? HowMuchReceivedForAsset { get; set; }

        public string WhyDidYouSellOrGiveAway { get; set; }

        public AssetSoldToList? WhoDidYouSellOrGiveTo { get; set; }

        public decimal? WhatWasTheMarketValueOfTheAsset { get; set; }

        public string WhatHappenedToTheProceedsOfTheSale { get; set; }

        public string ProvideAnyFurtherDetails { get; set; }
    }
}
