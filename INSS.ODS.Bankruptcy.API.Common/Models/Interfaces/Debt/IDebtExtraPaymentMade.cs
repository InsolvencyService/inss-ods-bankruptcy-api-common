using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt
{
    public interface IDebtExtraPaymentMade
    {
        DateTime PaymentDate { get; set; }

        decimal? PaymentAmount { get; set; }

        string AssetName { get; set; }
    }
}
