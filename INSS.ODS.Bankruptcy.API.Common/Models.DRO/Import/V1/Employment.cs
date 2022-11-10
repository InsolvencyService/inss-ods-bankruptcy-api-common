using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class Employment
    {
        public bool? PreviouslySelfEmployed { get; set; }

        public List<EmploymentDetail> EmploymentDetails { get; set; }
    }
}