namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

//[Validator(typeof(PersonalDetailsViewModelValidator))]
public class PersonalDetails
{
    public string Urn { get; set; }
    public Title? Title {get; set; }
    public string OtherTitle { get; set; }
    public string FirstName { get; set; }
    public string MiddleNames { get; set; }
    public bool? KnownByAnotherName { get; set; }
    public List<OtherName> OtherNames { get; set; } 
    public string CityOfBirth { get; set; }
    public string NationalInsuranceNumber { get; set; }
    public int? DependantChildrenUnder14 { get; set; }
    public int? DependantChildren14To18 { get; set; }
    public int? DependantOthers { get; set; }
    public Gender? Gender { get; set; }
    public Relationship? InRelationship { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public LegacyAddress CurrentAddress { get; set; }
    public bool? LivedAtOtherAddress { get; set; }
    public bool? LiveInEnglandOrWales { get; set; }
    public bool? EverLivedInEnglandOrWales { get; set; }
    public bool? BusinessInEnglandOrWales { get; set; }
    public string Telephone { get; set; }
    public string Mobile { get; set; }
    public string EmailAddress { get; set; }
    public LegacyAddress PreviousAddress { get; set; }
    public List<LegacyAddress> PreviousAddresses { get; set; }
}