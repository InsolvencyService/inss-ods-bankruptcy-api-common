using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public class UnderValueTransactionDetails
    {
        public bool? GivenAwayOrSold { get; set; }

        public List<UnderValueTransaction> Transactions { get; set; }
    }
}