using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class PropertyOrCreditor
    {
        public List<PropertyTransaction> PropertyTransactions { get; set; }
        public string PropertyTransactionComment { get; set; }
        public List<PreferredCreditor> PreferredCreditors { get; set; }
        public string PreferredCreditorComment { get; set; }

    }
}
