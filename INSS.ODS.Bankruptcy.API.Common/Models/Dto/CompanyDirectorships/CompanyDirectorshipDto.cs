using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.CompanyDirectorships
{
    [DataContract]
    public class CompanyDirectorshipDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string LimitedCompanyName { get; set; }

        [DataMember]
        public bool IsCompanyRegisteredInTheUK { get; set; }

        [DataMember]
        public string CompanyRegistrationCountry { get; set; }

        [DataMember]
        public string CompanyRegistrationNumber { get; set; }

        [DataMember]
        public bool IsCompanySubjectToInsolvencyProceedings { get; set; }

        [DataMember]
        public bool? AreYouStillAnActiveDirector { get; set; }

    }
}
