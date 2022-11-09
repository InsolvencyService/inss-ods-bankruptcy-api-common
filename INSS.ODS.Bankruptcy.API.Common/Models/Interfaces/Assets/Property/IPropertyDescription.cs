using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPropertyDescription
    {
        int Id { get; set; }

        string PropertyType { get; set; }

        string OtherPropertyType { get; set; }

        string OwnershipType { get; set; }

        int? BedroomCount { get; set; }

        bool WhoLivesYou { get; set; }

        bool WhoLivesSpouse { get; set; }

        bool WhoLivesFormer { get; set; }

        bool WhoLivesTenant { get; set; }

        bool WhoLivesLodger { get; set; }

        string WhoLivesInProperty_FieldsetStart { get; set; }
    }
}