using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public class PreferredCreditorDetails
    {
        public bool? PreferredAnyCreditors { get; set; }

        public List<PreferredCreditor> Creditors { get; set; }
    }
}