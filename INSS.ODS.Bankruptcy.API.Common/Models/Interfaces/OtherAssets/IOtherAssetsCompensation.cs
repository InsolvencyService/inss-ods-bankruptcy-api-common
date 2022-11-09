using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.OtherAssets
{
    public interface IOtherAssetsCompensation
    {
        string Description { get; set; }
        decimal? Amount { get; set; }
    }
}
