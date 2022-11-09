using INSS.ODS.Bankruptcy.API.Common.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ITransport
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
          decimal? Vehicle_Finance { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Vehicle_Finance_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
          decimal? Vehicle_Insurance { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Vehicle_Insurance_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        decimal? Breakdown_Cover { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Breakdown_Cover_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
         decimal? Vehicle_Tax { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Vehicle_Tax_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        decimal? MOT { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string MOT_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
         decimal? Fuel_Parking_Toll { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Fuel_Parking_Toll_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
          decimal? Public_Transport { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Public_Transport_Frequency { get; set; }

        //List<AdditionalTransport> AdditionalTransport { get; set; }
        
    }
}