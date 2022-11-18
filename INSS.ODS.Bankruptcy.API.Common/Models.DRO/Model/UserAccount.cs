namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class UserAccount
{
    public string Id { get; set; }

    /// <summary>
    /// This is the Id stored in the ISCIS database, not the Id 
    /// that the intermediary logs in with
    /// </summary>
    public int? IscisIntermediaryId { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Address OfficeAddress { get; set; }
    public List<string> Roles { get; set; }
    public bool? IsLocked { get; set; }
    public bool? DeleteApplicationsRole { get; set; }
}
