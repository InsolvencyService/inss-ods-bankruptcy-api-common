using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships
{
    public interface ILimitedCompanyName
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string LimitedCompanyName { get; set; }
    }
}
