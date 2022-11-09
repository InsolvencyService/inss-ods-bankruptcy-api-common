using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class Pension
    {
        public bool? HaveAPension { get; set; }

        public List<PensionDetails> Pensions { get; set; }
    }
}
