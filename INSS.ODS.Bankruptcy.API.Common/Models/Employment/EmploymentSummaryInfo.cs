using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Employment
{
    public class 
        EmploymentSummaryInfo : ITableBase, IEmploymentSummary
    {
        public int Id { get; set; }

        public bool? HasBeenDirector { get; set; }

        public bool? HasBeenSelfEmployed { get; set; }

        public bool? HasBeenPartner { get; set; }

        public bool? HasBeenEmployed { get; set; }
    }
}