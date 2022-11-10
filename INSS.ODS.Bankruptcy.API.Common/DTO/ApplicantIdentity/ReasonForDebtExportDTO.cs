using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ReasonForDebtExportDTO
    {
        [DataMember]
        public int Id { get; set; }

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
    }
}