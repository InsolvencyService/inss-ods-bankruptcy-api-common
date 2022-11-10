using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Vehicle
{
    [DataContract]
    [Validator(typeof(OwnVehicleAdditionalDetailsValidator<Address>))]
    public class OwnVehicleAdditionalDetailsDto : IOwnVehicleAdditionalDetails<Address>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool IsVehicleKeptAtHomeAddress { get; set; }

        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public string IsFinanceOutstanding { get; set; }
    }
}