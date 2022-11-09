using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class DebtHistoryExportDTO   
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? HasEnteredDebtIncurredDetails { get; set; }

        [DataMember]
        public bool? HasAnsweredDebtReliefOptionsUsedQuestion { get; set; }

        [DataMember]
        public bool? HasAnsweredDebtExtraPaymentsMadeQuestion { get; set; }
    }
}