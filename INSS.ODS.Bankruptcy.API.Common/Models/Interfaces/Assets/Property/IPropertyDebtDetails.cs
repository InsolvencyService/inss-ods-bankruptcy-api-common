using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPropertyDebtDetails
    { 
        string DebtType { get; set; }
        
        int PropertyId { get; set; }

        string ReferenceNumber { get; set; }
      
        DateTime DebtStartDate { get; set; }
      
        decimal? AmountOwe { get; set; }
              
        string IsJointDebt { get; set; }

        int CreditorId { get; set; }
    }
}