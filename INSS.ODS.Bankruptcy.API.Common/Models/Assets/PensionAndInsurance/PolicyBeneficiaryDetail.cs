using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [Validator(typeof(PolicyBeneficiaryDetailValidator))]
    public class PolicyBeneficiaryDetail : IPolicyBeneficiaryDetail, ITableBase
    {
        public int Id { get; set; }

        public int PolicyMainId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Relationship { get; set; }
        public string RelationshipOther { get; set; }

        public double BeneficiaryShare { get; set; }

        public bool IsSelf
        {
            get
            {
                return !String.IsNullOrWhiteSpace(Relationship) && Relationship.Trim().ToLower() == RelationshipConstants.Self;
            }
        }
    }
}
