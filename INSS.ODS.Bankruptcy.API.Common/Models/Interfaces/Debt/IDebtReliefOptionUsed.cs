using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt
{
    public interface IDebtReliefOptionUsed
    {
        string DebtReliefOptionType { get; set; }

        DateTime DebtReliefOptionStartDate { get; set; }

        string DebtReliefOptionReferenceNumber { get; set; }
    }
}
