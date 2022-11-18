using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class PartnershipDetail : ITableBase, IPartnershipDetail
{
    public int Id { get; set; }

    [Required]
    [DataMember]
    public string BusinessName { get; set; }

    [Required]
    [DataMember]
    public string BusinessType { get; set; }

    [Required]
    [DataMember]
    public DateTime TradingStartedDate { get; set; }

    [DataMember]
    public DateTime? TradingStoppedDate { get; set; }

    [DataMember]
    public IList<PartnershipBusinessName> BusinessNames
    {
        get;
        set;
    }

    [DataMember]
    public IList<PartnerDetail> PartnersDetails { get; set; }

    [DataMember]
    public IList<PartnershipTradingAddress> TradingAddressses { get; set; }

    [DataMember]
    public TaxDetail TaxDetail { get; set; }

    [DataMember]
    public IList<PartnershipCurrentEmployeeDetail> CurrentEmployees { get; set; }







}
