using System.Text;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties
{
    public class PersonNameViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
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