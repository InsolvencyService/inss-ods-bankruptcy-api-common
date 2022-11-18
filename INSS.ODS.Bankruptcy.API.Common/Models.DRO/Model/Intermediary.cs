namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class Intermediary
{

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public byte Level { get; set; }

    public DateTime JoinDate { get; set; }

    public DateTime? DateAppointed { get; set; }

    public int ISCISIntermediaryID { get; set; }

    public bool ChangeIntermediaryPassword { get; set; }

    public short RecentUnsuccessfulLogins { get; set; }

    public DateTime LockExpireDate { get; set; }

    public byte[] IntermediaryPasswordEncr { get; set; }


}
