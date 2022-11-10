using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    [Validator(typeof(ContactDetailsValidator))]
    public class ContactDetails : ITableBase, IContactDetails
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string Telephone { get; set; }
    }
}
