using INSS.ODS.Bankruptcy.API.Common.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PensionExportDTO
    {
        public PensionExportDTO()
        {
            OtherPensions = new List<OtherPensionExportDTO>();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? State { get; set; }

        [DataMember]
        public string State_Frequency { get; set; }

        [DataMember]
        public decimal? PensionCredit { get; set; }

        [DataMember]
        public string PensionCredit_Frequency { get; set; }

        [DataMember]
        public List<OtherPensionExportDTO> OtherPensions { get; set; }

        public decimal? Total
        {
            get
            {
                if (IsNotStarted) { return null; }

                var result = ValueFrequencyNormalisation.Normalise(State, State_Frequency)
                             + ValueFrequencyNormalisation.Normalise(PensionCredit, PensionCredit_Frequency);

                foreach (var other in OtherPensions)
                {
                    result += ValueFrequencyNormalisation.Normalise(other.Value, other.Frequency);
                }

                return result;
            }
        }

        public bool IsNotStarted
        {
            get
            {
                return
                    State == null
                    && PensionCredit == null
                    && (OtherPensions == null || !OtherPensions.Any());
            }
        }
    }
}