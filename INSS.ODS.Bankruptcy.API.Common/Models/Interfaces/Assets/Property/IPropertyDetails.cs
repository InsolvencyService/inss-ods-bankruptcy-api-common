using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPropertyDetails
    {
        [DataMember]
        Address PropertyAddress { get; set; }

        [DataMember]
        decimal ApplicantInterestValueInProperty { get; }
    }
}