using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IOtherPension
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        decimal? Value { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Type { get; set; }
    }
}