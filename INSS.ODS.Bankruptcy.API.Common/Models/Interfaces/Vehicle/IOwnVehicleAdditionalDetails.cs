namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle
{
    public interface IOwnVehicleAdditionalDetails<T> where T : IAddress
    {
        int Id { get; set; }

        bool IsVehicleKeptAtHomeAddress { get; set; }

        T Address { get; set; }

        string IsFinanceOutstanding { get; set; }
    }
}