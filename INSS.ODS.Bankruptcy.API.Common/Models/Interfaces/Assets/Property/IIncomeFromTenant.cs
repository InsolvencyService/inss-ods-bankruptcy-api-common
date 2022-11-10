namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IIncomeFromTenant
    {       
        decimal? IncomeAmount { get; set; }  
             
        string IncomeFrequency { get; set; } 
              
        string ManagingAgent { get; set; }
    }
}