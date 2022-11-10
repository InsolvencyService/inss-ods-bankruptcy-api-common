using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class ContributionsFromOthers : ITableBase, IContributionsFromOthers
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? HouseholdPersonContribution { get; set; }

        [DataMember]
        public string HouseholdPersonContribution_Frequency { get; set; }


        [NotMapped]
        public decimal? Total
        {
            get
            {
                if (IsNotStarted) { return null; }

                return
                    ValueFrequencyNormalisation.Normalise(HouseholdPersonContribution,
                        HouseholdPersonContribution_Frequency);

            }
        }

        [NotMapped]
        public bool IsNotStarted
        {
            get { return HouseholdPersonContribution == null; }
        }

    }
}
