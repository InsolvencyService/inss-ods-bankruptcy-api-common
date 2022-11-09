using System.Runtime.Serialization;
using INSS.ODS.API.Common.Utilities.Types;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Creditors
{
    [DataContract]
    public class DebtDetailsDto
    {
        [DataMember]
        public bool DebtRepayment { get; set; }

        [DataMember]
        public bool HouseholdBills { get; set; }

        [DataMember]
        public bool Holidays { get; set; }

        [DataMember]
        public bool HomeImprovements { get; set; }

        [DataMember]
        public bool PaymentsToFamily { get; set; }

        [DataMember]
        public bool TradingExpenses { get; set; }

        [DataMember]
        public bool VehiclePurchase { get; set; }

        [DataMember]
        public bool Wedding { get; set; }

        [DataMember]
        public bool Gambling { get; set; }

        [DataMember]
        public bool Other { get; set; }

        [DataMember]
        public string Other_Text { get; set; }

        [DataMember]
        public CheckboxList ReasonsForDebt { get; set; }

        [DataMember]
        public string ApproxDebtStartedDateRange { get; set; }

        [DataMember]
        public bool? SeizedOrSoldAssets { get; set; }

        [DataMember]
        public bool? AttachmentOfEarnings { get; set; }

    }
}
