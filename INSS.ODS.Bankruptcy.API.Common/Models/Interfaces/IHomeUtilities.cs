using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IHomeUtilities
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_Rent_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? Rent { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Rent_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_Mortgage_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? Mortgage { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Mortgage_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_SecuredLoans_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? SecuredLoans { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string SecuredLoans_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_GroundRentServiceCharges_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? GroundRentServiceCharges { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string GroundRentServiceCharges_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_BuildingContentInsuranceCharges_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? BuildingContentInsurance { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string BuildingContentInsurance_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_ApplianceFurnitureRental_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? ApplicanceFurnitureRental { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string ApplicanceFurnitureRental_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_TVLicence_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? TVLicence { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string TVLicence_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_CouncilTax_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? CouncilTax { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string CouncilTax_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_Gas_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? Gas { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Gas_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_Electricity_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? Electricity { get; set; }



        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Electricity_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_HomeUtilities_Positive_Water_Label", ErrorMessageResourceType = typeof(HomeUtilitiesResources))]
        decimal? Water { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Water_Frequency { get; set; }
    }
}