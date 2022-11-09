using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.API.Common.Utilities.Types;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{
    [Validator(typeof(OwnVehicleValidator))]
    [DataContract]
    public class OwnVehicle : ITableBase, IOwnVehicle
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember, DataType(DataType.Currency)]
        public decimal? Price { get; set; }

        [NotMapped]
        public string UseOfVehicle_FieldsetStart { get; set; }

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

        [NotMapped]
        public CheckboxList VehicleUses { get; set; }
    }
}