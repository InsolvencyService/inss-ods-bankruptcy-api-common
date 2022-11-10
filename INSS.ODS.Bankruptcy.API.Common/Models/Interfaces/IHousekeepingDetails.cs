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
    public interface IHousekeepingDetails
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Positive_Groceries_Label", ErrorMessageResourceType = typeof(HousekeepingResources))]
        decimal? Groceries { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Groceries_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Positive_Toiletries_Label", ErrorMessageResourceType = typeof(HousekeepingResources))]
        decimal? Toiletries { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Toiletries_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Positive_Alcohol_Label", ErrorMessageResourceType = typeof(HousekeepingResources))]
        decimal? Alcohol { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Alcohol_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Positive_MealsAtWork_Label", ErrorMessageResourceType = typeof(HousekeepingResources))]
        decimal? MealsAtWork { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string MealsAtWork_Frequency { get; set; }
    }
}