using System;
using System.Collections.Generic;
using System.Text;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }

        public string SingleLineAddress {
            get
            {
                List<string> addressParts = new List<string>();

                if (!string.IsNullOrEmpty(Line1)) { addressParts.Add(Line1); }
                if (!string.IsNullOrEmpty(Line2)) { addressParts.Add(Line2); }
                if (!string.IsNullOrEmpty(Line3)) { addressParts.Add(Line3); }
                if (!string.IsNullOrEmpty(Town)) { addressParts.Add(Town); }
                if (!string.IsNullOrEmpty(County)) { addressParts.Add(County); }
                if (!string.IsNullOrEmpty(Postcode)) { addressParts.Add(Postcode); }
                if (!string.IsNullOrEmpty(Country)) { addressParts.Add(Country); }

                return string.Join(", ", addressParts);
            }
        }
    }
}
