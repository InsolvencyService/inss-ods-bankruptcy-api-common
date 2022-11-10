using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;
using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ISecurityQuestionAnswerItem : ITableBase, IIndexedItem
    {
        /// <summary>
        /// Applicant security question
        /// </summary>
        [DataMember(IsRequired = true)]
        String SecurityQuestion { get; set; }

        /// <summary>
        /// Applicant security answer
        /// </summary>
        [DataMember(IsRequired = true)]
        String SecurityAnswer { get; set; }
    }
}
