using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{
    [Validator(typeof(DisposalValueValidator))]
    [DataContract]
    public class VehicleDisposalValue : ITableBase, IDisposalValue
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}