using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships
{
    public interface ILimitedCompanyDetails
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        bool? IsCompanyRegisteredInTheUK { get; set; }

        [DataMember, DataType(DataType.Text)]
        string CompanyRegistrationCountry { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string CompanyRegistrationNumber { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        bool? IsCompanySubjectToInsolvencyProceedings { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        bool? AreYouStillAnActiveDirector { get; set; }

        
    }
}
