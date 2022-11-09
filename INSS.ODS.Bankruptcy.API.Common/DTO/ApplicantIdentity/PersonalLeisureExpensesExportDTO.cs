using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PersonalLeisureExpensesExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? ClothingAndFootwear { get; set; }

        [DataMember]
        public string ClothingAndFootwear_Frequency { get; set; }

        [DataMember]
        public decimal? Hairdressing { get; set; }

        [DataMember]
        public string Hairdressing_Frequency { get; set; }

        [DataMember]
        public decimal? HomePhoneInternetAndTV { get; set; }

        [DataMember]
        public string HomePhoneInternetAndTV_Frequency { get; set; }

        [DataMember]
        public decimal? MobilePhone { get; set; }

        [DataMember]
        public string MobilePhone_Frequency { get; set; }

        [DataMember]
        public decimal? LaundryAndDryCleaning { get; set; }

        [DataMember]
        public string LaundryAndDryCleaning_Frequency { get; set; }

        [DataMember]
        public decimal? HobbiesLeisureAndSport { get; set; }

        [DataMember]
        public string HobbiesLeisureAndSport_Frequency { get; set; }

        [DataMember]
        public decimal? NewspapersAndMagazines { get; set; }

        [DataMember]
        public string NewspapersAndMagazines_Frequency { get; set; }

        [DataMember]
        public decimal? Gifts { get; set; }

        [DataMember]
        public string Gifts_Frequency { get; set; }

        [DataMember]
        public decimal? Smoking { get; set; }

        [DataMember]
        public string Smoking_Frequency { get; set; }
    }
}