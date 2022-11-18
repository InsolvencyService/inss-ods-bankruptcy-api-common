using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    public class PensionDto
    {
        public PensionDto()
        {
            OtherPensions = new List<OtherPensionDto>();
        }

        public int Id { get; set; }
        public List<OtherPensionDto> OtherPensions { get; set; } 
        public decimal? State { get; set; }
        public string State_Frequency { get; set; }
        public decimal? PensionCredit { get; set; }
        public string PensionCredit_Frequency { get; set; }
    }
}
