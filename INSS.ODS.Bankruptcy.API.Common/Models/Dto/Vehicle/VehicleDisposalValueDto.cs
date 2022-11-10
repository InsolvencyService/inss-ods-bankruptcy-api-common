using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Vehicle
{
    [DataContract]
    public class VehicleDisposalValueDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}