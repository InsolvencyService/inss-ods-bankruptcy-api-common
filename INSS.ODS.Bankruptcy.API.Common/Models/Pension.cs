using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.Runtime.Serialization;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(PensionValidator))]
    public class Pension : ITableBase, IPension
    {
        public Pension()
        {
            OtherPensions = new List<OtherPension>();
        }

        public int Id { get; set; }
        
        public decimal? State { get; set; }
        public string State_Frequency { get; set; }
        public decimal? PensionCredit { get; set; }
        public string PensionCredit_Frequency { get; set; }

        public List<OtherPension> OtherPensions { get; set; }

        [NotMapped]
        public decimal? Total
        {
            get
            {
                if (IsNotStarted) { return null; }

                var result = ValueFrequencyNormalisation.Normalise(State, State_Frequency)
                             + ValueFrequencyNormalisation.Normalise(PensionCredit, PensionCredit_Frequency);

                foreach (var other in OtherPensions)
                {
                    result += ValueFrequencyNormalisation.Normalise(other.Value, other.Frequency);
                }

                return result;
            }
        }

        [NotMapped]
        public bool IsNotStarted
        {
            get
            {
                return
                    State == null
                    && PensionCredit == null
                    && (OtherPensions== null || !OtherPensions.Any());
            }
        }
    }
}
