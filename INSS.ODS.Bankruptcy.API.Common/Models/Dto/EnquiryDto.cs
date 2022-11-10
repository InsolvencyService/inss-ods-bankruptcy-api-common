using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class EnquiryDto
    {

        [DataMember]
        public string Urn { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string RefererUrl { get; set; }

        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public bool NoEmail { get; set; }

        [DataMember]
        public string Telephone { get; set; }

        [DataMember]
        public string DescriptionText { get; set; }

    }
}