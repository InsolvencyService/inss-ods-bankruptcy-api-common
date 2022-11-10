using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPolicyBeneficiaryDetail : IFirstNameLastNamePartial
    {
        int PolicyMainId { get; set; }
        string Relationship { get; set; }
        string RelationshipOther { get; set; }
        double BeneficiaryShare { get; set; }
        bool IsSelf { get; }
    }
}
