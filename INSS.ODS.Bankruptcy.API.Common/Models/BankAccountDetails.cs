using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.BankAccount;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

public class BankAccountDetails : ITableBase, IBankAccountDetails
{
    public BankAccountDetails()
    {
    }

    public int Id { get; set; }

    public string AccountNumber { get; set; }
    
    public decimal? CurrentBalance { get; set; }
    
    public DateTime DateOpened { get; set; }
    
    public bool? JointAccount { get; set; }

    public BankDetails BankDetails { get; set; }

    public bool? IsMainAccount { get; set; }
}