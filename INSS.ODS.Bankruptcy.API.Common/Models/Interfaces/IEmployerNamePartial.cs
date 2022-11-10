using System;
using System.ComponentModel.DataAnnotations;
using INSS.ODS.Bankruptcy.API.Common.Resources.Employment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IEmployerNamePartial
    {
        [Required(AllowEmptyStrings = false,
                  ErrorMessageResourceName = "Employment_History_EmployerName_Error_NotEmpty",
                  ErrorMessageResourceType = typeof(HistoryResources))]
        [MaxLength(100, ErrorMessageResourceName = "Employment_History_EmployerName_Error_MaxLength",
                      ErrorMessageResourceType = typeof(HistoryResources))]
        String EmployerName { get; set; }

    }
}
