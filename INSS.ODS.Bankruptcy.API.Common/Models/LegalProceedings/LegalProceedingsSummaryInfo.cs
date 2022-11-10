using System;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.LegalProceedings
{
    [Serializable]
    public class LegalProceedingsSummaryInfo : ITableBase, ILegalProceedingsSummaryInfo
    {
        public int Id { get; set; }

        public bool? HasSeparated { get; set; }
        public bool? HasOngoingLegalClaims { get; set; }
    }
}