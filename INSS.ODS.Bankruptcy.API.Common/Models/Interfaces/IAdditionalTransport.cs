using INSS.ODS.Bankruptcy.API.Common.Resources;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IAdditionalTransport
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Additional_Transport_Text { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        decimal? Additional_Transport_Value { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Additional_Transport_Frequency { get; set; }

    
    }
}