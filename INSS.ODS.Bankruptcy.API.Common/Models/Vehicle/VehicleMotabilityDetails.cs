using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{
    [DataContract]
    public class VehicleMotabilityDetails : ITableBase, IMotabilityDetails
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string MotabilityCRN { get; set; }
    }
}