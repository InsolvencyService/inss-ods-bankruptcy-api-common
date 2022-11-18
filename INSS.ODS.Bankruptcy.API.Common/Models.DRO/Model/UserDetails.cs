namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class UserDetails
{
    public int IntermediaryId { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Address OfficeAddress { get; set; }
}
