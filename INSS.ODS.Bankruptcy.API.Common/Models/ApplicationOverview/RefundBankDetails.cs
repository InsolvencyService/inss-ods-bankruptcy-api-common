using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.ApplicationOverview;

namespace INSS.ODS.Bankruptcy.API.Common.Models.ApplicationOverview;

public class RefundBankDetails: IRefundBankDetails, ITableBase
{
    public int Id { get; set; }
    public string SortCode { get; set; }
    public string AccountNumber { get; set; }
    public string BankName { get; set; }
    public string AccountHolder { get; set; }
}
