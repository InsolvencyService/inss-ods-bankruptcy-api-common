using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors
{
    public interface ICreditorDetail
    {
        int Id { get; set; }
        
        decimal? Amount { get; set; }

        string Reference { get; set; }

        string DebtType { get; set; }

        string DebtTypeOther { get; set; }

    }
}
