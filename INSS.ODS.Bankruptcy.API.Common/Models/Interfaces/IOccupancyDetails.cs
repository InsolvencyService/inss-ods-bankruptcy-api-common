using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IOccupancyDetails
    {
        Address HomeAddress { get; set; }

        DateTime? DateMovedIn { get; set; }

        DateTime? DateMovedOut { get; set; }

        bool IsCurrentAddress { get; set; }

        string PropertyOwnership { get; set; }

        string PropertyOwnershipOther { get; set; }
    }
}
