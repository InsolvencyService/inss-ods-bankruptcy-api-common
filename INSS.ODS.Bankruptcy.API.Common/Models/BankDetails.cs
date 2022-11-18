using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class BankDetails : ITableBase, IBankDetails
{
    public int Id { get; set; }

    public string BankName { get; set; }

    public string SortCode { get; set; }

    public string AddressLine1 { get; set; }

    public string AddressLine2 { get; set; }

    public string AddressLine3 { get; set; }

    public string TownCity { get; set; }

    public string County { get; set; }

    public string PostCode { get; set; }

    public string Country { get; set; }

    public bool IsManualEntry { get; set; }
}