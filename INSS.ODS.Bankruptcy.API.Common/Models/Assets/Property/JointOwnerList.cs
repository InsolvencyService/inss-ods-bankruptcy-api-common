using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
public class JointOwnerList : IJointOwnerList<PropertyJointOwnerDetails>
{
    public int PropertyId { get; set; }        
    public List<PropertyJointOwnerDetails> JointOwners { get; set; }
}