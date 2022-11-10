using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IWages
    {
        [DataMember, DataType(DataType.Currency)]
        [WagesNetIncomeRequiredIfAnyOtherAmountIsEnteredFieldAttribute(
               ErrorMessageResourceName = "Income_Wages_NetIncome_Error_Mandatory",
               ErrorMessageResourceType = typeof(WagesResources))]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Income_Wages_NetIncome_Error_ExpectedPositiveValue", ErrorMessageResourceType = typeof(WagesResources))]
        decimal? NetIncome { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string NetIncome_Frequency { get; set; }

        [DataMember, DataType(DataType.Currency)]
        [WagesNetIncomeGreaterThanTaxAttribute(
                 ErrorMessageResourceName = "Income_Wages_NetIncome_Error_NetIncomeGreaterThanIncomeTax",
                 ErrorMessageResourceType = typeof(WagesResources))]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Income_Wages_IncomeTaxAmount_Error_ExpectedPositiveValue", ErrorMessageResourceType = typeof(WagesResources))]
        decimal? IncomeTax { get; set; }

        [DataMember, DataType(DataType.Text)]
        string IncomeTax_Frequency { get; set; }

        [DataMember, DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Income_Wages_OverTimeIncome_Error_ExpectedPositiveValue", ErrorMessageResourceType = typeof(WagesResources))]
        decimal? OverTime { get; set; }

        [DataMember, DataType(DataType.Text)]
        string OverTime_Frequency { get; set; }

        [DataMember, DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Income_Wages_Bonuses_Error_ExpectedPositiveValue", ErrorMessageResourceType = typeof(WagesResources))]
        decimal? Bonus { get; set; }

        [DataMember, DataType(DataType.Text)]
        string Bonus_Frequency { get; set; }

        [DataMember, DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Income_Wages_OtherPayments_Error_ExpectedPositiveValue", ErrorMessageResourceType = typeof(WagesResources))]
        decimal? OtherPayments { get; set; }

        [DataMember, DataType(DataType.Text)]
        string OtherPayments_Frequency { get; set; }
    }
}