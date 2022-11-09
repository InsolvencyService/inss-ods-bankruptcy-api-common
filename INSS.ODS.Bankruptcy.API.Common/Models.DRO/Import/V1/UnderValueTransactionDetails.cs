using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class UnderValueTransactionDetails
    {
        public bool? GivenAwayOrSold { get; set; }

        public List<UnderValueTransaction> Transactions { get; set; }
    }
}