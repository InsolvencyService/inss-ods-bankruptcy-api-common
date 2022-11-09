using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle
{
    public interface IFinanceAgreement
    {       
        decimal? Amount { get; set; }

        string ReferenceNumber { get; set; }

        DateTime AgreementStartedDate { get; set; }

        string FinanceCompanyName { get; set; }
    }
}