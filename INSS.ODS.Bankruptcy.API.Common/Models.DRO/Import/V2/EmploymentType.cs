using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public enum EmploymentType
    {
        SelfEmployedOrTrading = 0,
        Employed = 1,
        Unemployed = 2,
        HousewifeOrHusband = 3,
        Carer = 4,
        CompanyDirectorOrPromoter = 5,
        Retired = 6,
        Student = 7,
        Other = 8
    }
}
