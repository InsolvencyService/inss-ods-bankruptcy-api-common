using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class CreditorExportDTO  
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public string CreditorName { get; set; }

        [DataMember]
        public AddressExportDTO CreditorAddress { get; set; }

        [DataMember]
        public AmountYouOweExportDTO AmountYouOwe { get; set; }

        [DataMember]
        public ReasonForDebtExportDTO ReasonForDebt { get; set; }

        [DataMember]
        public CreditorActionExportDTO CreditorAction { get; set; }

        [DataMember]
        public TypeOfActionTakenExportDTO TypeOfActionTaken { get; set; }

        [DataMember]
        public AttachmentOfEarningsExportDTO AttachmentOfEarnings { get; set; }


        [DataMember]
        public EnforcementVisitExportDTO EnforcementVisit { get; set; }

        [DataMember]
        public IList<SeizedAndSoldAssetsExportDTO> SeizedAndSoldAssets { get; set; }
    }
}