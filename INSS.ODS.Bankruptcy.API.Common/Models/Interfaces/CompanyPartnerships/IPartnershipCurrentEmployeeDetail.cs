using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPartnershipCurrentEmployeeDetail : IFirstName, ILastName
    {
        bool? MoneyOwed { get; set; }
    }
}
