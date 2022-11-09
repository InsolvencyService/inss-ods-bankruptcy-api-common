using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{

    public interface IHouseholdMember : IFirstName, ILastName
    {

        String AgeGroup { get; set; }

        string Relationship { get; set; }

        string RealtionshipOther { get; set; }

        String FinanciallyDependentOption { get; set; }

        bool FinanciallyDependent { get; set; }
    }
}
