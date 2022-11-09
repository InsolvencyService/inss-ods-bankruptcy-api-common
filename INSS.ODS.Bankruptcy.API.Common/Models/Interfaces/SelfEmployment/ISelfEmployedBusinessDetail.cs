using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ISelfEmployedBusinessDetail
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string BusinessName { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string BusinessType { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Date)]
        DateTime TradingStartedDate { get; set; }

        [DataType(DataType.Date)]
        DateTime? TradingStoppedDate { get; set; }
    }
}
