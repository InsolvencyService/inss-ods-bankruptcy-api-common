using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation.Attributes;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    [Validator(typeof(FirstNameOrLastNameValidator))]
    public class OtherName : ITableBase, IOtherName
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}
