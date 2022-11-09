using System.Text;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common
{
    public class AddressViewModel
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string TownCity { get; set; }

        public string County { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public string NormalisedAddress
        {
            get
            {
                var sb = new StringBuilder();

                if (!string.IsNullOrWhiteSpace(AddressLine1))
                {
                    sb.Append(AddressLine1);
                }

                if (!string.IsNullOrWhiteSpace(AddressLine2))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(AddressLine2);
                    }
                    else
                    {
                        sb.Append(", " + AddressLine2);
                    }
                }

                if (!string.IsNullOrWhiteSpace(AddressLine3))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(AddressLine3);
                    }
                    else
                    {
                        sb.Append(", " + AddressLine3);
                    }
                }

                if (!string.IsNullOrWhiteSpace(TownCity))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(TownCity);
                    }
                    else
                    {
                        sb.Append(", " + TownCity);
                    }
                }

                if (!string.IsNullOrWhiteSpace(County))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(County);
                    }
                    else
                    {
                        sb.Append(", " + County);
                    }
                }

                if (!string.IsNullOrWhiteSpace(PostCode))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(PostCode);
                    }
                    else
                    {
                        sb.Append(", " + PostCode);
                    }
                }

                if (!string.IsNullOrWhiteSpace(Country))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(Country);
                    }
                    else
                    {
                        sb.Append(", " + Country);
                    }
                }

                return sb.ToString();
            }
        }
    }
}