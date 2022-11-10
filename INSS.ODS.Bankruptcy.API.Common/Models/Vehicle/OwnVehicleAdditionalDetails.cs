using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{
    [Validator(typeof(OwnVehicleAdditionalDetailsValidator<Address>))]
    [DataContract]   
    public class OwnVehicleAdditionalDetails : IOwnVehicleAdditionalDetails<Address>, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool IsVehicleKeptAtHomeAddress { get; set; }
        
        [DataMember]
        public virtual Address Address { get; set; }

        [DataMember]
        public string IsFinanceOutstanding { get; set; }
    }
}