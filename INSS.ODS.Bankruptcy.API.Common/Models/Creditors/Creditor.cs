using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

[DataContract]
public class Creditor : ICreditor, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string SourceRef { get; set; }

    [DataMember]
    public string CreditorName { get; set; }

    [DataMember]
    public virtual Address CreditorAddress { get; set; }

    [DataMember]
    public bool AddressNotKnown { get; set; }

    [DataMember]
    public AmountYouOwe AmountYouOwe { get; set; }

    [DataMember]
    public ReasonForDebt ReasonForDebt { get; set; }

    [NotMapped]
    public bool IsCompleteRecord
    {
        get
        {
            return AmountYouOwe != null
                && (!AmountYouOwe.RequiresReason || ReasonForDebt != null);
        }
    }

    [NotMapped]
    public bool IsFullyComplete
    {
        get
        {
            bool returnValue = false;
            if (CreditorAction != null)
            {
                if (CreditorAction.ActionValue == false)
                {
                    returnValue = true;
                }
                else
                {
                    if (TypeOfActionTaken != null)
                    {
                        if (!String.IsNullOrEmpty(TypeOfActionTaken.TypeOfAction))
                        {
                            if (TypeOfActionTaken.TypeOfAction == TypeOfActionTakenResources.Creditors_TypeOfActionTaken_ActionType1)
                            {
                                if (EnforcementVisit != null)
                                {
                                    if (EnforcementVisit.ItemsSeizedOrSold.Value == true)
                                    {
                                        if (SeizedAndSoldAssets.Count > 0)
                                        {
                                            returnValue = true;
                                        }
                                    }
                                    else
                                    {
                                        returnValue = true;
                                    }
                                }
                            }
                            else
                            {
                                if (TypeOfActionTaken.TypeOfAction == TypeOfActionTakenResources.Creditors_TypeOfActionTaken_ActionType2)
                                {
                                    if (AttachmentOfEarnings != null)
                                    {
                                        returnValue = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;


        }
    }

    [DataMember]
    public CreditorAction CreditorAction { get; set; }

    [DataMember]
    public TypeOfActionTaken TypeOfActionTaken { get; set; }

    [DataMember]
    public AttachmentOfEarnings AttachmentOfEarnings { get; set; }


    [DataMember]
    public EnforcementVisit EnforcementVisit { get; set; }

    [DataMember]
    public IList<SeizedAndSoldAssets> SeizedAndSoldAssets { get; set; }

    [DataMember]
    public CreditorDetail CreditorDetail { get; set; }

    [DataMember]
    public DebtDetail DebtDetail { get; set; }


}
