using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.CompanyDirectorships
{
    [Serializable]
    public class CompanyDirectorshipSummaryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string RegistrationNumber { get; set; }

        public string RegistrationCountry { get; set; }

        public string Insolvent { get; set; }
    }
}
