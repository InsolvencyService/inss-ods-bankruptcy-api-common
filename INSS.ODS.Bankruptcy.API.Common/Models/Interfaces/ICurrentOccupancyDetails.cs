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
    public interface ICurrentOccupancyDetails
    {
        /// <summary>
        /// Date Moved In
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Personal_Occupant_DateMoved_Error_Empty", ErrorMessageResourceType = typeof(OccupantResources))]
        [DataMember(IsRequired = true), DataType(DataType.Date)]
        [NotDefaultDate(ErrorMessageResourceName = "Personal_Occupant_DateMoved_Error_Empty", ErrorMessageResourceType = typeof(OccupantResources))]
        [MinimumDate("01/01/1900", ErrorMessageResourceName = "Personal_Occupant_DateMoved_Error_MinimumDate", ErrorMessageResourceType = typeof(OccupantResources))]
        DateTime DateMovedIn { get; set; }

    }
}