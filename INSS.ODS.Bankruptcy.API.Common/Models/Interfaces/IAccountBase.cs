using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IAccountBase
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string SortCode { get; set; }
    }
}
