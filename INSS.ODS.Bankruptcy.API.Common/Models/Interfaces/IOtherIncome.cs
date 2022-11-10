using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IOtherIncomeDetails
    {
        [DataMember, DataType(DataType.Text)]              
        string Source { get; set; }

        [DataMember, DataType(DataType.Currency)]
        decimal? Amount { get; set; }

        [DataMember, DataType(DataType.Text)]
        string AmountFrequency { get; set; }
    }
}