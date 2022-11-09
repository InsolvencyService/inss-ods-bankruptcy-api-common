using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using FluentValidation.Attributes;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPension
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
          decimal? State { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string State_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
             decimal? PensionCredit { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string PensionCredit_Frequency { get; set; }
    }
}