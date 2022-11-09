using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class PersonalLeisureExpenses: ITableBase, IPersonalLeisureExpenses
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

        [NotMapped]
        public decimal? Total
        {
            get
            {
                if (IsNotStarted) { return null; }
                return
                    ValueFrequencyNormalisation.Normalise(ClothingAndFootwear, ClothingAndFootwear_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Hairdressing, Hairdressing_Frequency)
                    + ValueFrequencyNormalisation.Normalise(HomePhoneInternetAndTV, HomePhoneInternetAndTV_Frequency)
                    + ValueFrequencyNormalisation.Normalise(MobilePhone, MobilePhone_Frequency)
                    + ValueFrequencyNormalisation.Normalise(LaundryAndDryCleaning, LaundryAndDryCleaning_Frequency)
                    + ValueFrequencyNormalisation.Normalise(HobbiesLeisureAndSport, HobbiesLeisureAndSport_Frequency)
                    + ValueFrequencyNormalisation.Normalise(NewspapersAndMagazines, NewspapersAndMagazines_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Gifts, Gifts_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Smoking, Smoking_Frequency);
            }
        }

        [NotMapped]
        public bool IsNotStarted
        {
            get
            {
                return
                    ClothingAndFootwear == null
                    && Hairdressing == null
                    && HomePhoneInternetAndTV == null
                    && MobilePhone == null
                    && LaundryAndDryCleaning == null
                    && HobbiesLeisureAndSport == null
                    && NewspapersAndMagazines == null
                    && Gifts == null
                    && Smoking == null;
            }
        }
    }
}
