using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [Validator(typeof(PropertyJointOwnerListValidator<PropertyJointOwnerDetails>))]
    public class JointOwnerList : IJointOwnerList<PropertyJointOwnerDetails>
    {
        public int PropertyId { get; set; }        
        public List<PropertyJointOwnerDetails> JointOwners { get; set; }
    }
}