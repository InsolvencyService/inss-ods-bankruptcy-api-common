using System.Text;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.SelfEmployments
{
    public class BusinessCurrentEmployeeViewModel 
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AddressViewModel Address { get; set; }

        public bool? DoesThisEmployeeClaimYouOweThemMoney { get; set; }

        public BusinessEmployeeAmountOwedViewModel AmountOwed { get; set; }

        public string FullName {
            get
            {
                var sb = new StringBuilder();

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    sb.Append(FirstName);
                }

                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(LastName);
                    }
                    else
                    {
                        sb.Append(" " + LastName);
                    }
                }

                return sb.ToString();
            }
        }

    }
}