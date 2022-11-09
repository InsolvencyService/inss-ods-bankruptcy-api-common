using System;
using INSS.ODS.API.Common.Utilities.Types;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle
{
    public interface IOwnVehicle
    {
        int Id { get; set; }

        decimal? Price { get; set; }
        
        bool UsageAsWorkCommute { get; set; }

        bool UsageAsToSchool { get; set; }

        bool UsageAsRelativeCare { get; set; }

        bool UsageAsSocialising { get; set; }

        bool UsageOther { get; set; }

        String UsageOtherText { get; set; }

        CheckboxList VehicleUses { get; }
    }
}