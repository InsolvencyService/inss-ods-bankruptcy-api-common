namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account;

/// <summary>
/// Contains basic details for a DRO user along with their group memberships.
/// </summary>
public class UserSummary
{
    /// <summary>
    /// Summary of a group a user belongs to
    /// </summary>
    public class UserGroupSummary
    {
        public string Code { get; set; }

        public string Name { get; set; }

        // Is user approved for this group
        public bool Approved { get; set; }

        public int GroupRequests { get; set; }
    }

    public string Email { get; set; }

    public string Forename { get; set; }

    public string Surname { get; set; }

    public string UserName { get; set; }

    public string UserId { get; set; }

    public IList<UserGroupSummary> Groups { get; set; }
}
