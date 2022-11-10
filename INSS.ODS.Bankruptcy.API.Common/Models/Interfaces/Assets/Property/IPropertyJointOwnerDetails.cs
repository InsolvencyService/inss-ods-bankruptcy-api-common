namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPropertyJointOwnerDetails : IFirstNameLastNamePartial
    {
        int PropertyId { get; set; }

        string Relationship { get; set; }

        string OtherRelationship { get; set; }

        double JointOwnerShare { get; set; }

        bool IsSelf { get; }
    }
}