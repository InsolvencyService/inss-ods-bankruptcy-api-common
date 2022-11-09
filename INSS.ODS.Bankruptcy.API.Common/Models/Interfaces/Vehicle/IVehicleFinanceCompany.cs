using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle
{
    public interface IVehicleFinanceCompany
    {
        int Id { get; set; }

        string Name { get; set; }

        [DataMember]
        string SourceRef { get; set; }

        [DataMember]
        Address Address { get; set; }

        [DataMember]
        bool IsVehicleReturnedorRepossessed { get; set; }
    }
}