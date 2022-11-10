using System.Text;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties
{
    public class PropertyDetailsViewModel
    {
        public string PropertyType { get; set; }

        public string OwnershipType { get; set; }

        public int? NumberOfRooms { get; set; }

        public bool? YouLiveAtTheProperty { get; set; }

        public bool? CurrentSpousePartnerLiveAtTheProperty { get; set; }

        public bool? FormerSpousePartnerLiveAtTheProperty { get; set; }

        public bool? TenantLiveAtTheProperty { get; set; }

        public bool? LodgerLiveAtTheProperty { get; set; }

        public string WhoLivesAtTheProperty {
            get
            {
                var sb = new StringBuilder();

                if ((YouLiveAtTheProperty.HasValue) && (YouLiveAtTheProperty.Value))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append("You");
                    }
                }

                if ((CurrentSpousePartnerLiveAtTheProperty.HasValue) && (CurrentSpousePartnerLiveAtTheProperty.Value))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append("Your spouse / civil partner");
                    }
                    else
                    {
                        sb.Append(", your spouse / civil partner");
                    }
                }

                if ((FormerSpousePartnerLiveAtTheProperty.HasValue) && (FormerSpousePartnerLiveAtTheProperty.Value))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append("Former spouse / civil partner");
                    }
                    else
                    {
                        sb.Append(", former spouse / civil partner");
                    }
                }

                if ((TenantLiveAtTheProperty.HasValue) && (TenantLiveAtTheProperty.Value))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append("A tenant");
                    }
                    else
                    {
                        sb.Append(", a tenant");
                    }
                }

                if ((LodgerLiveAtTheProperty.HasValue) && (LodgerLiveAtTheProperty.Value))
                {
                    if (sb.Length == 0)
                    {
                        sb.Append("A lodger");
                    }
                    else
                    {
                        sb.Append(", a lodger");
                    }
                }

                return sb.ToString();
            }
        }
    }
}