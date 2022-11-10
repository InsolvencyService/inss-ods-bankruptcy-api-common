namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IAddress
    {
        string Address_1 { get; set; }
        
        string Address_2 { get; set; }
        
        string Address_3 { get; set; }
        
        string County { get; set; }
        
        string TownCity { get; set; }

        string PostCode { get; set; }

        string Country { get; set; }
    }
}
