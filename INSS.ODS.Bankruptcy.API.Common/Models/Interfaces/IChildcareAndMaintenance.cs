using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IChildcareAndMaintenance
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Child_Support_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? ChildSupport { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string ChildSupport_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Child_Care_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? Childcare { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Childcare_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Nappies_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? Nappies { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Nappies_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Prescriptions_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? Prescriptions { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Prescriptions_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Dentistry_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? Dentistry { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Dentistry_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Uniforms_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? Uniforms { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Uniforms_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Meals_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? Meals { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Meals_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Trips_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? Trips { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Trips_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_Transport_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? Transport { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Transport_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_Childcare_Positive_PocketMoney_Label", ErrorMessageResourceType = typeof(ChildcareResources))]
        decimal? PocketMoney { get; set; }



        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string PocketMoney_Frequency { get; set; }

    }
}