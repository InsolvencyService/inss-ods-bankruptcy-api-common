using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.BankAccount
{
    [Serializable]
    public class BankAccountSummaryDto
    {
        public string BankAccountDetailsId { get; set; }

        public string BankName { get; set; }

        public string SortCode { get; set; }

        public string AccountNumber { get; set; }
        
        public decimal AccountBalance { get; set; }
        
        public int NumberOfAccountHolders { get; set; }

        public bool IsMainAccount { get; set; }
    }
}