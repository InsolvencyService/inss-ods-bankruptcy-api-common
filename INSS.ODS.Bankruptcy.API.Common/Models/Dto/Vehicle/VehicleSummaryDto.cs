using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Vehicle
{
    [DataContract]
    public class VehicleSummaryDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Make { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public string OwnershipType { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; }

        [DataMember]
        public bool IsCompleteRecord { get; set; }
    }
}
