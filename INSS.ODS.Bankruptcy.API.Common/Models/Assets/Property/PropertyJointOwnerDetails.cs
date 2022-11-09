using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.Runtime.Serialization;
using System;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(PropertyJointOwnerDetailsValidator))]
    [DataContract]
    public class PropertyJointOwnerDetails : IPropertyJointOwnerDetails, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PropertyId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string OtherRelationship { get; set; }

        [DataMember]
        public string Relationship { get; set; }

        [DataMember]
        public double JointOwnerShare { get; set; }

        [DataMember]
        public bool IsSelf
        {
            get
            {
                return !String.IsNullOrWhiteSpace(Relationship) && Relationship.Trim().ToLower() == RelationshipConstants.Self;
            }
        }
    }
}