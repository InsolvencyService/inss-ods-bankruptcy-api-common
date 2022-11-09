using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class CurrentInsolvency
    {
        public string OrganisationName;
        public Address OrganisationAddress { get; set; }
        public string OrganisationReference;
        public DateTime CurrentInsolvencyDate;
        public string CurrentProceedingName;
    }
}
