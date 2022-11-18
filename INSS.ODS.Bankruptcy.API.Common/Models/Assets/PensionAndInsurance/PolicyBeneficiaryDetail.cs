using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
public class PolicyBeneficiaryDetail : IPolicyBeneficiaryDetail, ITableBase
{
    public int Id { get; set; }

    public int PolicyMainId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Relationship { get; set; }
    public string RelationshipOther { get; set; }

    public double BeneficiaryShare { get; set; }

    public bool IsSelf
    {
        get
        {
            return !String.IsNullOrWhiteSpace(Relationship) && Relationship.Trim().ToLower() == RelationshipConstants.Self;
        }
    }
}
