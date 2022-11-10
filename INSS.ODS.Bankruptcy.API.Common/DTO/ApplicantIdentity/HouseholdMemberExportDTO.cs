using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class HouseholdMemberExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string AgeGroup { get; set; }

        [DataMember]
        public string Relationship { get; set; }

        [DataMember]
        public string RealtionshipOther { get; set; }

        [DataMember]
        public bool FinanciallyDependent { get; set; }
    }
}