using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;

[DataContract]
public class InsolvencyPractitioner : IInsolvencyPractitioner, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public virtual Address Address { get; set; }

}
