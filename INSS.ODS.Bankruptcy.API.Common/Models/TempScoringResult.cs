using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    public struct TempScoringResult
    {
        public string Urn;
        public string Status;
        public string AddressVerified { get; set; }
        public string SurplusIncome { get; set; }
        public string ValueOfAssets { get; set; }
        public string  Liabilities { get; set; }
        public string Creditors { get; set; }
        public string  PreviousInsolvency { get; set; }
        public string RealProperties { get; set; }
    }
}
