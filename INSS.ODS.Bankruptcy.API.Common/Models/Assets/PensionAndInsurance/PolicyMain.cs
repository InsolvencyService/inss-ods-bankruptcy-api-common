using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class PolicyMain : IPolicyProvider, ITableBase, IPolicyBeneficiaryList<PolicyBeneficiaryDetail>
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string SourceRef { get; set; }

    [DataMember]
    public string ProviderName { get; set; }

    [DataMember]
    public virtual Address ProviderAddress { get; set; }

    [DataMember]
    public virtual PolicyDetail PolicyDetail { get; set; }

    [DataMember]
    public virtual PolicyValue PolicyValue { get; set; }

    [DataMember]
    public virtual PolicyIncome PolicyIncome { get; set; }

    [DataMember]
    public virtual List<PolicyBeneficiaryDetail> PolicyBeneficiaries { get; set; }

    [DataMember]
    [NotMapped]
    public bool IsCompleteRecord
    {
        get
        {
            if (PolicyDetail == null || PolicyValue == null)
            {
                return false;
            }

            if (PolicyValue.CurrentlyReceivingPayment)
            {
                if (PolicyIncome == null)
                {
                    return false;
                }
            }

            //Validate beneficiaries
            if (PolicyBeneficiaries.Any())
            {
                var validator = new PolicyBeneficiaryListValidator<PolicyBeneficiaryDetail>();
                var validationResult = validator.Validate(this);

                if (!validationResult.IsValid)
                {
                    return false;
                }
            }

            return true;
        }
    }


    /// <summary>
    /// This implementation is here solely to run the above validator
    /// </summary>

    #region Interface implementation

    [NotMapped]
    public int PolicyMainId
    {
        get { return Id; }
        set { }
    }

    #endregion
}
