namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt
{
    public interface IPreferredCreditorRelationship
    {
        string RelationshipToYou { get; set; }

        string RelationshipToYouOther { get; set; }
    }
}