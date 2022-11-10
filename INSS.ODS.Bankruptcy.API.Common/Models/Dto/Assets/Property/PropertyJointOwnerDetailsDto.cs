using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class PropertyJointOwnerDetailsDto
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