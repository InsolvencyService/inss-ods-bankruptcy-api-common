using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPropertyJointOwnerDetailsList<T> where T : IPropertyJointOwnerDetails
    {
        int PropertyId { get; set; }
        List<T> JointOwners { get; set; }
    }
}