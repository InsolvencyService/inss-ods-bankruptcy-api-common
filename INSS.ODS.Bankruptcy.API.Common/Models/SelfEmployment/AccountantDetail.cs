using INSS.ODS.Bankruptcy.API.Common.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.ComponentModel.DataAnnotations.Schema;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    [Validator(typeof(SelfEmployedAccountantDetailValidator<Address>))]
    public class AccountantDetail : ITableBase, IAccountantDetail<Address>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string AccountantName { get; set; }

        [DataMember]
        [Required]
        public virtual Address AccountantAddress { get; set; }
        
        [DataMember]
        [Required]
        public DateTime DateStarted { get; set; }

        [DataMember]
        public DateTime? DateStopped { get; set; }
    }
}
