using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ISavingsFinesOtherCosts
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_SavingsFinesOtherCosts_Positive_Savings_Label", ErrorMessageResourceType = typeof(SavingsFinesOtherCostsResources))]
        decimal? Savings { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Savings_Frequency { get; set; }
    }
}