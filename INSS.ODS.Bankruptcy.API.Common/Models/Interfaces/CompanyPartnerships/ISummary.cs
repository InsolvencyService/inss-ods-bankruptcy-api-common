using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyPartnerships
{
    public interface ISummary
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string PartnershipName { get; set; }
    }
}
