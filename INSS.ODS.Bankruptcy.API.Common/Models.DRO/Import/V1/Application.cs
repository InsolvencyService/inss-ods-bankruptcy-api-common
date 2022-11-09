using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class Application
    {
        public string Surname { get; set; }

        public PersonalDetails PersonalDetails { get; set; }
        public InsolvencyHistory InsolvencyHistory { get; set; }
        
        public Assets Assets { get; set; }

        public Pension Pensions { get; set; }

        public UnderValueTransactionDetails UnderValueTransactions { get; set; }

        public PreferredCreditorDetails PreferredCreditors { get; set; }

        public List<Creditor> Creditors { get; set; }

        public IncomeExpenditure IncomeExpenditure { get; set; }

        public Employment Employment { get; set; }
    }
}
