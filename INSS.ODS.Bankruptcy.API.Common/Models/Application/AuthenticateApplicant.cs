using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

public class AuthenticateApplicant : IAuthenticateApplicant
{
    [DataMember]
    public String Urn { get; set; }

    [DataMember]
    public String Question { get; set; }

    [DataMember]
    public String SecurityAnswer { get; set; }
}
