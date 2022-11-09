using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.MoneyYouOwe.EnforcementVisit
{
    public class SeizedAndSoldAssetViewModel
    {
        public string Name { get; set; }
        public decimal? Value { get; set; }
        public bool? Sold { get; set; }
    }
}
