using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class PreviousTrading
    {
        public String PreviousTradingName { get; set; }
        
        public DateTime? DateCeased { get; set; }

        public bool ShouldSerializeDateCeased()
        {
            return (DateCeased.HasValue);
        }
        
        public Address TradingAddress { get; set; }
        public Boolean? PreviousOnOwn { get; set; }
    }
}
