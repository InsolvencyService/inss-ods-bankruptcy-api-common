namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

/// <summary>
/// Used to populate application lists on the DRO website.
/// </summary>
public class DroApplicationSummary
{
    // Name of intermediary
    public string UserName { get; set; }
    
    public bool IsOwner { get; set; }
    
    public string DroReference { get; set; }
    
    public string Forename { get; set; }
    
    public string Surname { get; set; }
    
    public ApplicationStatus ApplicationStatus { get; set; }

    public string Urn { get; set; }
    
    public DateTime? LastEdited { get; set; }
}
