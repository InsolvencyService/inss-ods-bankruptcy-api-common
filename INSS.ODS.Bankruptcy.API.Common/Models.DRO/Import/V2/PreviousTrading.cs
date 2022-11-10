﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public class PreviousTrading
    {
        public int? PreviousTradingID { get; set; }

        public Address BusinessAddress { get; set; }

        public string PreviousTradingName { get; set; }

        public bool? SoleTrader { get; set; }

        public DateTime? DateTradingCeased { get; set; }
    }
}
