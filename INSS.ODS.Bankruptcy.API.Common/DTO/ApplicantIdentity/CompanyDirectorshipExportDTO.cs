using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class CompanyDirectorshipExportDTO
    {
        [DataMember]
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
        public InsolvencyPractitionerExportDTO InsolvencyPractitioner { get; set; }
    }
}