using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Employment
{
    public class EmploymentSummaryInfoDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool? HasBeenDirector { get; set; }

        [DataMember]
        public bool? HasBeenSelfEmployed { get; set; }

        [DataMember]
        public bool? HasBeenPartner { get; set; }

        [DataMember]
        public bool? HasBeenEmployed { get; set; }

        [DataMember]
        public bool HasCurrentDirectorship { get; set; }

        [DataMember]
        public bool HasCurrentSelfEmployment { get; set; }

        [DataMember]
        public bool HasCurrentPartnership { get; set; }

        [DataMember]
        public bool HasCurrentEmployer { get; set; }

        [DataMember]
        public bool HasAnyFormOfCurrentEmployment
        {
            get
            {
                return HasCurrentDirectorship || HasCurrentSelfEmployment || HasCurrentPartnership || HasCurrentEmployer;
            }
        }

    }
}
