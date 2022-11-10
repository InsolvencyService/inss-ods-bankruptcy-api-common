using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.BktReference
{
    public interface IBktRegistration : ITableBase
    {
        string BktReference { get; }
    }
}
