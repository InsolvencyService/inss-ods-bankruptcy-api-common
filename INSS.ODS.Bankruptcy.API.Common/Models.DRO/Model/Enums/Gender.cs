using System.ComponentModel.DataAnnotations;
using INSS.ODS.Bankruptcy.API.Common.Resources.DRO;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model.Enums
{
    public enum Gender
    {
        Male,
        Female,
        [Display(Name="PersonalDetails_Gender_Unspecified_Label", ResourceType = typeof(PersonalDetailsResources))]
        Unspecified
    }
}