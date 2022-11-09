using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IAuthenticateApplicant 
    {
        ///
        /// Applicant urn
        [DataMember]
        String Urn { get; set; }
           
        /// <summary>
        /// Applicant security question
        /// </summary>
        String Question { get; set; }

        /// <summary>
        /// Applicant security question answer
        /// </summary>
        [Required(AllowEmptyStrings = false,
                  ErrorMessageResourceName = "Application_Continue_Your_Application_Security_Answer_Error_Empty",
                  ErrorMessageResourceType = typeof(ContinueResources))]
        String SecurityAnswer { get; set; }

    }
}