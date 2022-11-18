namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class ApplicationSummary
{
    public string Reference { get; set; }
    public string Ai { get; set; }
    public string Organisation { get; set; }
    public LegacyAddress Address { get; set; }
    public ApplicationStatus Status { get; set; }
    public string AiUsername { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }
    public string NiNumber { get; set; }
    public string Telephone { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public bool DueForDeletion { get; set; }
}
