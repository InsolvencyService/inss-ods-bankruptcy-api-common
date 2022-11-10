using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class PreviousInsolvency
    {
        public DateTime PreviousInsolvencyDate { get; set; }
        public string InsolvencyProcedureName { get; set; }
    }
}
