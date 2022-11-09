using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    [Validator(typeof(OtherIncomeValidator))]
    public class OtherIncomeDetails : ITableBase, IOtherIncomeDetails
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string AmountFrequency { get; set; }

        [NotMapped]
        public decimal? Total
        {
            get
            {
                if (IsNotStarted) { return null; }
                return ValueFrequencyNormalisation.Normalise(Amount, AmountFrequency);
            }
        }

        [NotMapped]
        public bool IsNotStarted
        {
            get { return !Amount.HasValue; }
        }
    }
}