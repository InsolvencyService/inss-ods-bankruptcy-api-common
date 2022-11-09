using System.ComponentModel.DataAnnotations;
using INSS.ODS.Bankruptcy.API.Common.Resources.DRO;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model.Enums
{
    public enum Relationship
    {
        [Display(Name = "PersonalDetails_Relationship_Single", ResourceType = typeof(PersonalDetailsResources))]
        Single,        
        [Display(Name = "PersonalDetails_Relationship_MarriedOrCivilPartnership", ResourceType = typeof(PersonalDetailsResources))]
        MarriedOrCivilPartnership,
        [Display(Name = "PersonalDetails_Relationship_InARelationshipAndLivingApart", ResourceType = typeof(PersonalDetailsResources))]
        InARelationshipAndLivingApart,
        [Display(Name = "PersonalDetails_Relationship_LivingTogether", ResourceType = typeof(PersonalDetailsResources))]
        LivingTogether,
        [Display(Name = "PersonalDetails_Relationship_DivorcedOrFormerCivilPartner", ResourceType = typeof(PersonalDetailsResources))]
        DivorcedOrFormerCivilPartner,
        [Display(Name = "PersonalDetails_Relationship_Seperated", ResourceType = typeof(PersonalDetailsResources))]
        Separated,
        [Display(Name = "PersonalDetails_Relationship_WidowedOrSurvivingCivilPartner", ResourceType = typeof(PersonalDetailsResources))]
        WidowedOrSurvivingCivilPartner
        
    }
}