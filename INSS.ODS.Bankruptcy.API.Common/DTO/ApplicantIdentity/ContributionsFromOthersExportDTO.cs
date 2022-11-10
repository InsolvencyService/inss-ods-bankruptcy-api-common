using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ContributionsFromOthersExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? HouseholdPersonContribution { get; set; }

        [DataMember]
        public string HouseholdPersonContribution_Frequency { get; set; }
    }
}