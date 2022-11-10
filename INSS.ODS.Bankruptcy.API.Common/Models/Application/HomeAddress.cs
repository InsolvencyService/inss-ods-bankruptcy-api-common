using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    [Validator(typeof(HomeAddressValidator))]
    public class HomeAddress : ITableBase, IHomeAddress
    {
        public int Id { get; set; }

        [Required]
        [DataMember]
        public virtual Address HomeRegistrationAddress { get; set; }

      
    }
}
