using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IFormerEmployeeDetail : IFirstName, ILastName
    {

        decimal? Amount { get; set; }

        string Reason { get; set; }

    }
}
