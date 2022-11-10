using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    [Validator(typeof(JointAccountOwnerValidator))]
    public class JointAccountOwner : ITableBase, IJointAccountOwner
    {
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string FirstName { get; set; }

        [Required]
        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public BankAccountDetails BankAccountDetails { get; set; }
    }
}
