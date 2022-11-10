using System.Collections.Generic;
using System.Text;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Vehicles
{
    public class VehicleOwnedDetailsViewModel
    {
        public decimal? VehicleWorth { get; set; }
        public bool? VehicleUsedForWorkCommute { get; set; }
        public bool? VehicleUsedForSchool { get; set; }
        public bool? VehicleUsedForRelativeCare { get; set; }
        public bool? VehicleUsedForSocialising { get; set; }
        public bool? VehicleUsedForOther { get; set; }
        public string VehicleUsedForOtherText { get; set; }
        public string VehicleUsedFor
        {
            get
            {
                var sb = new StringBuilder();

                if (VehicleUsedForWorkCommute.HasValue)
                {
                    sb.Append("Work and commuting\n");
                }

                if (VehicleUsedForSchool.HasValue)
                {
                    sb.Append("Taking children to school\n");
                }

                if (VehicleUsedForRelativeCare.HasValue)
                {
                    sb.Append("Caring for a relative\n");
                }

                if (VehicleUsedForSocialising.HasValue)
                {
                    sb.Append("Socialising\n");
                }

                if (VehicleUsedForOther.HasValue && !string.IsNullOrWhiteSpace(VehicleUsedForOtherText))
                {
                    sb.AppendFormat("Other: {0}\n", VehicleUsedForOtherText);
                }

                //Chop last line break
                sb.Replace("\n", "", sb.Length - 1, 1);

                return sb.ToString();
            }
        }
    }
}