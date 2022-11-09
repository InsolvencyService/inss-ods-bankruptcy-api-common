using INSS.ODS.Bankruptcy.API.Common.Resources;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IBenefits
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
         decimal? ChildTaxCredit { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string ChildTaxCredit_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
          decimal? ChildBenefit { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string ChildBenefit_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
         decimal? ChildSupport { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string ChildSupport_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
           decimal? Universal_Credit { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Universal_Credit_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
           decimal? JobSeekers { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string JobSeekers_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
           decimal? Income_Support { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Income_Support_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
              decimal? Working_Tax_Credit { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Working_Tax_Credit_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
            decimal? Sick_Pay { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Sick_Pay_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
          decimal? Disability { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Disability_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
           decimal? Carers_Allowance { get; set; }



        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Carers_Allowance_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
             decimal? Housing_Benefit { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Housing_Benefit_Frequency { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Currency)]
               decimal? Council_Tax_Support { get; set; }


        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Council_Tax_Support_Frequency { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Other_Text { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Currency)]
               decimal? Other_Value { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Other_Frequency { get; set; }
    }
}