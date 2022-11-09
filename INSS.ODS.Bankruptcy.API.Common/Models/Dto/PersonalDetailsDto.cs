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
    [Validator(typeof(PersonalDetailsValidators))]
    public class PersonalDetailsDto : IPersonalDetails
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string TitleOther { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleNames { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
}
