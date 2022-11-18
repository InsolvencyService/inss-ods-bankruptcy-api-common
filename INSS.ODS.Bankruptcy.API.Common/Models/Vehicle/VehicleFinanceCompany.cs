using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{    
    [DataContract]
    public class VehicleFinanceCompany : IVehicleFinanceCompany, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public virtual Address Address { get; set; }

        [DataMember]
        public bool IsVehicleReturnedorRepossessed { get; set; }
    }
}