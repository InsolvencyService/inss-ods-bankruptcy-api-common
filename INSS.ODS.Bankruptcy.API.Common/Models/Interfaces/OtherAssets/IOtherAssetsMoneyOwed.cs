using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.OtherAssets
{
    public interface IOtherAssetsMoneyOwed
    {
        string Reason { get; set; }
        decimal? Amount { get; set; }
        string WhoOwesYou { get; set; }
    }
}
