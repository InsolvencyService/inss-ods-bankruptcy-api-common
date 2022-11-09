using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.AdjReference
{
    public interface IAdjRegistration : ITableBase
    {
        [DataMember]
        [StringLength(16)]
        String ClientName { get; set; }

        string AdjReference { get; }
    }
}
