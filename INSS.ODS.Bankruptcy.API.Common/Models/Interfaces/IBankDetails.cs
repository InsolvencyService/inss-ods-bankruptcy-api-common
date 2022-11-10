using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IBankDetails
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string BankName { get; set; }

        [DataMember, DataType(DataType.Text)]
        string SortCode { get; set; }

        [DataMember, DataType(DataType.Text)]
        string AddressLine1 { get; set; }

        [DataMember, DataType(DataType.Text)]
        string AddressLine2  { get; set; }

        [DataMember, DataType(DataType.Text)]
        string AddressLine3 { get; set; }

        [DataMember, DataType(DataType.Text)]
        string TownCity { get; set; }

        [DataMember, DataType(DataType.Text)]
        string County { get; set; }

        [DataMember, DataType(DataType.Text)]
        string PostCode { get; set; }

        [DataMember, DataType(DataType.Text)]
        string Country { get; set; }

        [DataMember]
        bool IsManualEntry { get; set; }
        
    }
}
