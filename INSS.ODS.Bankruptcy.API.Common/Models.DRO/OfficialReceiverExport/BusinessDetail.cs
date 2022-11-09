using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class BusinessDetail
    {
        public String TypeOfBusiness { get; set; }
        public String TradingInformation { get; set; }
        public Boolean? MainCentreUk { get; set; }
        public Boolean? InsuranceUndertaking { get; set; }
        public Boolean? OutsideEc { get; set; }
        public Address Address { get; set; }
        public Boolean? BusinessOnOwn { get; set; }
    }
}
