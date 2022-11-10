using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.ApplicationOverview
{
    public interface IRefundBankDetails
    {
        string SortCode { get; set; }
        string AccountNumber { get; set; }
        string BankName { get; set; }
        string AccountHolder { get; set; }
    }
}
