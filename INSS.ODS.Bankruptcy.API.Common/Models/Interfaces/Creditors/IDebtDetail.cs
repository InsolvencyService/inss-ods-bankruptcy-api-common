using INSS.ODS.API.Common.Utilities.Types;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors
{
    public interface IDebtDetail
    {
        int Id { get; set; }

        bool DebtRepayment { get; set; }
        bool HouseholdBills { get; set; }
        bool Holidays { get; set; }
        bool HomeImprovements { get; set; }
        bool PaymentsToFamily { get; set; }
        bool TradingExpenses { get; set; }
        bool VehiclePurchase { get; set; }
        bool Wedding { get; set; }
        bool Gambling { get; set; }
        bool Other { get; set; }
        string Other_Text { get; set; }

        bool AnySelected { get; }

        CheckboxList ReasonsForDebt { get; }

        string ApproxDebtStartedDateRange { get; set; }

        bool? SeizedOrSoldAssets { get; set; }

        bool? AttachmentOfEarnings { get; set; }

        bool ValidationHook { get; set; }

        bool RequiresReason { get; set; }

    }
}
