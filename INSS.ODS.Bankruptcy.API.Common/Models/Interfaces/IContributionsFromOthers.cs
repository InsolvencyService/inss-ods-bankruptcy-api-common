using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IContributionsFromOthers
    {
        [DataMember(IsRequired = true), DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessageResourceName = "Income_Contributions_HouseholdPerson_Label", ErrorMessageResourceType = typeof(ContributionsResources))]
        decimal? HouseholdPersonContribution { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string HouseholdPersonContribution_Frequency { get; set; }

    }
}
