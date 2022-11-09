using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources.Employment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Employment
{
    public interface IEmploymentStatus
    {
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Employment_EmploymentStatus_Status_Error_Empty", ErrorMessageResourceType = typeof(EmploymentStatusResources))]
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        String Status { get; set; }
    }
}
