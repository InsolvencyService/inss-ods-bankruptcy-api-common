using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using System.Runtime.Serialization;
using System;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{
    [Validator(typeof(ThirdPartyVehicleValidator))]
    [DataContract]
    public class ThirdPartyVehicle : ITableBase, IThirdPartyVehicle
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string OwnerName { get; set; }

        [DataMember]
        public string RelationshipType { get; set; }

        [DataMember]
        public string RelationshipTypeOther { get; set; }
    }
}