using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships
{
    [DataContract]
    [Validator(typeof(CompanyDirectorshipValidator))]
    public class CompanyDirectorship : ILimitedCompanyDetails, ILimitedCompanyName, ITableBase
    {
        public int Id { get; set; }

        [DataMember]
        public string LimitedCompanyName { get; set; }

        [DataMember]
        public bool? IsCompanyRegisteredInTheUK { get; set; }

        [DataMember]
        public string CompanyRegistrationCountry { get; set; }

        [DataMember]
        public string CompanyRegistrationNumber { get; set; }

        [DataMember]
        public bool? IsCompanySubjectToInsolvencyProceedings { get; set; }

        [DataMember]
        public bool? AreYouStillAnActiveDirector { get; set; }

        [DataMember]
        public InsolvencyPractitioner InsolvencyPractitioner { get; set; }
    }
}
