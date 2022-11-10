using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPersonalLeisureExpenses
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_ClothingAndFootwear_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? ClothingAndFootwear { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string ClothingAndFootwear_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_Hairdressing_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? Hairdressing { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Hairdressing_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_HomePhoneInternetAndTV_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? HomePhoneInternetAndTV { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string HomePhoneInternetAndTV_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_MobilePhone_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? MobilePhone { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string MobilePhone_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_LaundryAndDryCleaning_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? LaundryAndDryCleaning { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string LaundryAndDryCleaning_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_HobbiesLeisureAndSport_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? HobbiesLeisureAndSport { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string HobbiesLeisureAndSport_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_NewspapersAndMagazines_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? NewspapersAndMagazines { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string NewspapersAndMagazines_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_Gifts_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? Gifts { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Gifts_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Personal_Smoking_Error_Negative", ErrorMessageResourceType = typeof(PersonalResources))]
        decimal? Smoking { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Smoking_Frequency { get; set; }
    }
}
