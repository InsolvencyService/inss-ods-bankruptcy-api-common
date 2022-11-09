using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.CompanyDirectorships
{
    [DataContract]
    public class InsolvencyPractitionerDto
    {
        [DataMember]
        public int CompanyDirectorshipId { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address_1 { get; set; }

        [DataMember]
        public string Address_2 { get; set; }

        [DataMember]
        public string Address_3 { get; set; }

        [DataMember]
        public string TownCity { get; set; }

        [DataMember]
        public string County { get; set; }

        [DataMember]
        public string PostCode { get; set; }

        [DataMember]
        public string Country { get; set; }
    }
}
