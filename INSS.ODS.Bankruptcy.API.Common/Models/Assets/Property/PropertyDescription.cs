using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class PropertyDescription : ITableBase, IPropertyDescription
{
    [DataMember] 
    public int Id { get; set; }

    [DataMember]
    public string PropertyType { get; set; }

    [DataMember]
    public string OtherPropertyType { get; set; }

    [DataMember]
    public string OwnershipType { get; set; }

    [DataMember]
    public int? BedroomCount { get; set; }
    
    [NotMapped]
    public string WhoLivesInProperty_FieldsetStart { get; set; }

    [DataMember]
    public bool WhoLivesYou { get; set; }

    [DataMember]
    public bool WhoLivesSpouse { get; set; }

    [DataMember]
    public bool WhoLivesFormer { get; set; }

    [DataMember]
    public bool WhoLivesTenant { get; set; }

    [DataMember]
    public bool WhoLivesLodger { get; set; }      
}