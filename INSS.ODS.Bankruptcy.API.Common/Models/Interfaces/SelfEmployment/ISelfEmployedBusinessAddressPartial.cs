using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ISelfEmployedBusinessAddressPartial
    {
        [DataType(DataType.Text)]
        string Address_1 { get; set; }
        
    }
}
