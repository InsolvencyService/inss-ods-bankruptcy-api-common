using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ICompanyPartnershipTradingAddressPartial
    {
        [DataType(DataType.Text)]
        string Address_1 { get; set; }
        
    }
}
