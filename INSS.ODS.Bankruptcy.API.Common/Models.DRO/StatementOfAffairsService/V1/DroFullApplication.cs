using INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;
using System.Text;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.StatementOfAffairsService.V1;

public class DroFullApplication
{
    public string Urn { get; set; }
    public string Surname { get; set; }

    public string DroReference { get; set; }

    public DRO.Model.Application ApplicationDetails { get; set; }

    public DRO.Model.PersonalDetails PersonalDetails { get; set; }
    public InsolvencyHistory InsolvencyHistory { get; set; }

    public DRO.Model.Employment EmploymentDetails { get;set; }
    public List<EmploymentDetail> Employment { get; set; }
    public List<PreviousTrading> PreviousTrading { get; set; }

    public Assets Assets { get; set; }
    public List<EssentialTool> EssentialTools { get; set; } 

    public DRO.Model.Pension PensionDetails { get; set; }
    public List<PensionDetails> Pensions { get; set; } 

    public UnderValueTransactionDetails UnderValueTransactionDetails { get; set; }
    public List<UnderValueTransaction> UnderValueTransactions { get; set; } 

    public PreferredCreditorDetails PreferredCreditorDetails { get; set; }
    public List<PreferredCreditor> PreferredCreditors { get; set; } 

    public List<Creditor> Creditors { get; set; }

    public IncomeExpenditure IncomeExpenditure { get; set; }

    public string DisplayName
    {
        get
        {
            StringBuilder sb = new StringBuilder();

            if (PersonalDetails != null)
            {
                if (PersonalDetails.Title.HasValue)
                {
                    if (PersonalDetails.OtherTitle != null)
                    { sb.AppendFormat("{0} ", PersonalDetails.OtherTitle);  }

                    else
                    sb.AppendFormat("{0} ", PersonalDetails.Title);
                }

                if (!string.IsNullOrEmpty(PersonalDetails.FirstName))
                {
                    sb.AppendFormat("{0} ", PersonalDetails.FirstName);
                }

                if (!string.IsNullOrEmpty(PersonalDetails.MiddleNames))
                {
                    sb.AppendFormat("{0} ", PersonalDetails.MiddleNames);
                }
            }

            sb.AppendFormat(Surname);

            return sb.ToString();
        }
    }

    public decimal QualifyingDebts
    {
        get
        {
            var total = 0m;
            if (Creditors != null)
            {                    
                foreach(var creditor in Creditors)
                {
                    if (creditor.ExcludedDebt.HasValue && !creditor.ExcludedDebt.Value)
                    {
                        total += creditor.AmountOwed.Value;
                    }
                }
            }
            return total;
        }
    }
}
