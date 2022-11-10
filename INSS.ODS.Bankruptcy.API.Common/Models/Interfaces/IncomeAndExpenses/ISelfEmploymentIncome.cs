using INSS.ODS.Bankruptcy.API.Common.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ISelfEmploymentIncome
    {

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        decimal? Profit { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Profit_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Date)]
        DateTime? AccountingPeriodStart { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Date)]
        DateTime? AccountingPeriodEnd { get; set; }

    }
}