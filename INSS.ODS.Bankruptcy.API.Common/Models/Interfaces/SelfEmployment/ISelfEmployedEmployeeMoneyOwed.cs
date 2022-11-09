using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ISelfEmployedEmployeeMoneyOwed
    {
        decimal? Amount { get; set; }

        string Reason { get; set; }

       
    }
}
