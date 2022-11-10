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
    public interface IHouseholdMemberPartialVm :IFirstNameLastNamePartial
    {
    }
}
