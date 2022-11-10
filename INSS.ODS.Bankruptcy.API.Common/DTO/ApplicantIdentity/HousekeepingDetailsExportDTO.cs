using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class HousekeepingDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Groceries { get; set; }

        [DataMember]
        public string Groceries_Frequency { get; set; }

        [DataMember]
        public decimal? Toiletries { get; set; }

        [DataMember]
        public string Toiletries_Frequency { get; set; }

        [DataMember]
        public decimal? Alcohol { get; set; }

        [DataMember]
        public string Alcohol_Frequency { get; set; }

        [DataMember]
        public decimal? MealsAtWork { get; set; }

        [DataMember]
        public string MealsAtWork_Frequency { get; set; }
    }
}