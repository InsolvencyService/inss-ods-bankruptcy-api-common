using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.BankAccount
{
    public interface IBankAccountDetails
    {
        string AccountNumber { get; set; }
        decimal? CurrentBalance { get; set; }
        DateTime DateOpened { get; set; }
        bool? JointAccount { get; set; }
    }
}
