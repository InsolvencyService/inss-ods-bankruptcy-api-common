using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class PersonalLeisureExpensesDto : BaseDto
    {
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
