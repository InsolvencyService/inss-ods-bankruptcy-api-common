using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IEmployeeDetail : IFirstName, ILastName
    {
        bool? MoneyOwed { get; set; }
    }
}
