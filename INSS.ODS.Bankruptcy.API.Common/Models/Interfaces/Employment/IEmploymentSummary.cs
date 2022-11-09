using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IEmploymentSummary
    {
        [DataMember(IsRequired = true)]
        bool? HasBeenDirector { get; set; }
        [DataMember(IsRequired = true)]
        bool? HasBeenSelfEmployed { get; set; }
        [DataMember(IsRequired = true)]
        bool? HasBeenPartner { get; set; }
        [DataMember(IsRequired = true)]
        bool? HasBeenEmployed { get; set; }
    }
}
