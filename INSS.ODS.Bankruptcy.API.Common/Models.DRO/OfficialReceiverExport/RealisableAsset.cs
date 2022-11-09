using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class RealisableAsset
    {
        public String AssetDescription { get; set; }

        public decimal AssetValue { get; set; }
    }
}
