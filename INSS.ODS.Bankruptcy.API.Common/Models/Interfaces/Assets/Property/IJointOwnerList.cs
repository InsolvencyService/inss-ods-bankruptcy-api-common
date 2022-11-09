using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IJointOwnerList<T> where T : IPropertyJointOwnerDetails
    {
        int PropertyId { get; set; }
        List<T> JointOwners { get; set; }
    }
}