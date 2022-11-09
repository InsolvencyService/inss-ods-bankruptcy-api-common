using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle
{
    public interface IThirdPartyVehicle
    {
        int Id { get; set; }

        string OwnerName { get; set; }

        string RelationshipType { get; set; }

        string RelationshipTypeOther { get; set; }
    }
}