using INSS.ODS.Bankruptcy.API.Common.Resources.Income;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPensionInsuranceHealthcare
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_PersonalPensionPayments_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? PersonalPensionPayments { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string PersonalPensionPayments_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_LifeInsurance_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? LifeInsurance { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string LifeInsurance_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_HealthInsurance_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? HealthInsurance { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string HealthInsurance_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_PaymentProtectionInsurance_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? PaymentProtectionInsurance { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string PaymentProtectionInsurance_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_PetInsurance_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? PetInsurance { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string PetInsurance_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_VeterinaryBills_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? VeterinaryBills { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string VeterinaryBills_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_AdultCareCosts_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? AdultCareCosts { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string AdultCareCosts_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_PrescriptionsAndMedicines_Label", ErrorMessageResourceType = typeof(PersonalLeisureExpenses))]
        decimal? PrescriptionsAndMedicines { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string PrescriptionsAndMedicines_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_Dentistry_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? Dentistry { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Dentistry_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Expenses_PensionExpense_Positive_Opticians_Label", ErrorMessageResourceType = typeof(PensionExpenseResources))]
        decimal? Opticians { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Opticians_Frequency { get; set; }

    }
}
