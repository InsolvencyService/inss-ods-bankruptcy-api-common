using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IBeneficialInterest
    {
        int Id { get; set; }
        decimal? Amount { get; set; }
    }
}