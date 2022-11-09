using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPolicyBeneficiaryList<T> where T: IPolicyBeneficiaryDetail
    {
        int PolicyMainId { get; set; }
        List<T> PolicyBeneficiaries { get; set; }
    }
}
