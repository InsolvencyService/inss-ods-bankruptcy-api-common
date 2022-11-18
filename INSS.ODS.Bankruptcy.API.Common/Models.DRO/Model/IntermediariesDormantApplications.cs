namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class IntermediariesDormantApplications
{
    
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public List<DormantApplication> Applications { get; set; }
}
