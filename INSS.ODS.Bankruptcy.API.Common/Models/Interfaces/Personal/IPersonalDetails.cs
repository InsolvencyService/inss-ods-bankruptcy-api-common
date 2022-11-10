using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPersonalDetails : IFirstName, IMiddleNames, ILastName
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        String Title { get; set; }

        [DataMember(IsRequired = false), DataType(DataType.Text)]
        String TitleOther { get; set; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        [DataMember(IsRequired = true), DataType(DataType.Date)]
        DateTime DateOfBirth { get; set; }
    }
}
