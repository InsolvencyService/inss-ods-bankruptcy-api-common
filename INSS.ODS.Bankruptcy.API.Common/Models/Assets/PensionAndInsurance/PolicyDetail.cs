using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class PolicyDetail : IPolicyDetail, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string CommencementDate { get; set; }

    [DataMember]
    public string PolicyReferenceNo { get; set; }

    [DataMember]
    public string PolicyType { get; set; }

    [DataMember]
    public string PolicyTypeOther { get; set; }

    public bool IsPensionPolicy
    {
        get
        {
            return !String.IsNullOrWhiteSpace(PolicyType)
                &&
                (PolicyType.Trim().ToLower() == PolicyDetailsResources.PensionAndInsurance_PolicyDetails_WorkplacePension_Label.ToLower()
                || PolicyType.Trim().ToLower() == PolicyDetailsResources.PensionAndInsurance_PolicyDetails_PersonalPension_Label.ToLower()
                || PolicyType.Trim().ToLower() == PolicyDetailsResources.PensionAndInsurance_PolicyDetails_SelfInvestedPersonalPension_Label.ToLower()
                );
        }
    }

}