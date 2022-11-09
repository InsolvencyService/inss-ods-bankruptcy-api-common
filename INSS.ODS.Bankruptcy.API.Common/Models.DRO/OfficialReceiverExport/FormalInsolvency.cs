using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class FormalInsolvency
    {
        public DateTime FormalInsolvencyDate { get; set; }
        public string ProceedingName { get; set; }
    }
}
