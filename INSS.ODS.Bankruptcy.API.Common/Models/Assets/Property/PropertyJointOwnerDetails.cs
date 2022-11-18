using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

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