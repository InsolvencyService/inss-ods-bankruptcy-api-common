namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle
{
    public interface IDisposalValue
    {
        int Id { get; set; }

        decimal? Amount { get; set; }
    }
}