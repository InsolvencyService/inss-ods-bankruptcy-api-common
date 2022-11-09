using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Vehicle
{
    [DataContract]
    public class VehicleFinanceCompanyDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public bool IsVehicleReturnedorRepossessed { get; set; }
    }
}