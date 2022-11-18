using INSS.ODS.Bankruptcy.API.Common.Resources.DRO;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model.Enums;

public enum EmploymentType
{
    [Display(Name = "EmploymentDetailsResources_EmploymentType_Employed", ResourceType = typeof(EmploymentDetailsResources))]
    Employed,
    [Display(Name = "EmploymentDetailsResources_EmploymentType_SelfEmployedOrTrading", ResourceType = typeof(EmploymentDetailsResources))]
    SelfEmployedOrTrading,
    [Display(Name = "EmploymentDetailsResources_EmploymentType_Unemployed", ResourceType = typeof(EmploymentDetailsResources))]
    Unemployed,
    [Display(Name = "EmploymentDetailsResources_EmploymentType_HousewifeOrHusband", ResourceType = typeof(EmploymentDetailsResources))]
    HousewifeOrHusband,
    [Display(Name = "EmploymentDetailsResources_EmploymentType_Carer", ResourceType = typeof(EmploymentDetailsResources))]
    Carer,
    [Display(Name = "EmploymentDetailsResources_EmploymentType_CompanyDirectorOrPromoter", ResourceType = typeof(EmploymentDetailsResources))]
    CompanyDirectorOrPromoter,
    [Display(Name = "EmploymentDetailsResources_EmploymentType_Retired", ResourceType = typeof(EmploymentDetailsResources))]
    Retired,
    [Display(Name = "EmploymentDetailsResources_EmploymentType_Student", ResourceType = typeof(EmploymentDetailsResources))]
    Student,
    Other
}