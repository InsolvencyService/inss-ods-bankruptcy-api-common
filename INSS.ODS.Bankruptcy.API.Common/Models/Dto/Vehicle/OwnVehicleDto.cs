using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.API.Common.Utilities.Types;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Vehicle
{
    [DataContract]
    public class OwnVehicleDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember, DataType(DataType.Currency)]
        public decimal? Price { get; set; }
      
        [DataMember]
        public bool UsageAsWorkCommute { get; set; }

        [DataMember]
        public bool UsageAsToSchool { get; set; }

        [DataMember]
        public bool UsageAsRelativeCare { get; set; }

        [DataMember]
        public bool UsageAsSocialising { get; set; }

        [DataMember]
        public bool UsageOther { get; set; }

        [DataMember]
        public string UsageOtherText { get; set; }

        [DataMember]
        public CheckboxList VehicleUses { get; set; }
    }
}
