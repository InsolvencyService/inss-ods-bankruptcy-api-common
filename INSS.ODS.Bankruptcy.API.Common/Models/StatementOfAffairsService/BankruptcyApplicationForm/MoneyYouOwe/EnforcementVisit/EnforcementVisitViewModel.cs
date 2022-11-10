using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.MoneyYouOwe.EnforcementVisit
{
    public class EnforcementVisitViewModel
    {
        public DateTime VisitDate { get; set; }
        public bool? WereAnyItemsTaken { get; set; }
        public List<SeizedAndSoldAssetViewModel> SeizedAndSoldAssets { get; set; }
    }
}
