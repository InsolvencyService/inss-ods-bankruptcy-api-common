namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt
{
    public interface IDebtHistory
    {
        bool? HasEnteredDebtIncurredDetails { get; set; }

        bool? HasAnsweredDebtReliefOptionsUsedQuestion { get; set; }

        bool? HasAnsweredDebtExtraPaymentsMadeQuestion { get; set; }
    }
}
