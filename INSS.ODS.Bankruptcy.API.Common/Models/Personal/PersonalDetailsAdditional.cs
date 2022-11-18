using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class PersonalDetailsAdditional: ITableBase, IPersonalDetailsAdditional
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NationalInsuranceNumber { get; set; }

        [DataMember]
        public string RelationshipStatus { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public bool IsSectionComplete
        {
            get
            {
                return !string.IsNullOrEmpty(NationalInsuranceNumber) 
                    && !string.IsNullOrEmpty(RelationshipStatus) 
                    && !string.IsNullOrEmpty(Gender);
            }
        }
    }
}
