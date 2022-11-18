using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
public class PolicyBeneficiaryList : IPolicyBeneficiaryList<PolicyBeneficiaryDetail>
{
    public int PolicyMainId { get; set; }
    public List<PolicyBeneficiaryDetail> PolicyBeneficiaries { get; set; }
}
