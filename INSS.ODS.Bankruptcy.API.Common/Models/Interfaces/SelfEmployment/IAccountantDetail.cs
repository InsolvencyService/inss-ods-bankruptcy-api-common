using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IAccountantDetail<TAddress> where TAddress : IAddress
    {
        string AccountantName { get; set; }
        TAddress AccountantAddress { get; set; }
        DateTime DateStarted { get; set; }
        DateTime? DateStopped { get; set; }
    }
}
