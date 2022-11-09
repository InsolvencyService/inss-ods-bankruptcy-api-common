using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IApplicationContinueWithUrn
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        [IndexedRequiredLength(MinLength = 12, MaxLength = 12,
           RequiredErrorMessageName = "Application_Continue_URN_Error_Required",
           MinLengthErrorMessageName = "Application_Continue_URN_Error_Length",
           MaxLengthErrorMessageName = "Application_Continue_URN_Error_Length",
           ErrorMessageResourceType = typeof(ContinueResources))]
        string Urn
        {
            get;
            set;
        }

    }
}
