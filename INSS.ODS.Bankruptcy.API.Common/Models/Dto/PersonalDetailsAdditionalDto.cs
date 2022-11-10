using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    [Validator(typeof(PersonalDetailsAdditionalValidators))]
    public class PersonalDetailsAdditionalDto : IPersonalDetailsAdditional
    {
        [DataMember]
        public string NationalInsuranceNumber { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string RelationshipStatus { get; set; }

        [DataMember]
        public bool IsSectionComplete
        {
            get
            {
                return !string.IsNullOrEmpty(Gender)
                       && !string.IsNullOrEmpty(NationalInsuranceNumber)
                       & !string.IsNullOrEmpty(RelationshipStatus);
            }
        }
    }
}
