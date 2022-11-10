using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt
{
    public interface IPreferentialPaymentDetail
    {
        DateTime? PaymentDate { get; set; }

        decimal? PaymentAmount { get; set; }

        string AssetName { get; set; }
    }
}