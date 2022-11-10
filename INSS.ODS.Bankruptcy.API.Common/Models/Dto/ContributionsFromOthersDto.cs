using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class ContributionsFromOthersDto : BaseDto
    {
        [DataMember]
        public decimal? HouseholdPersonContribution { get; set; }

        [DataMember]
        public string HouseholdPersonContribution_Frequency { get; set; }



    }
}
