using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPersonalDetailsAdditional
    {
        /// <summary>
        /// National Insurance Number
        /// </summary>
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string NationalInsuranceNumber { get; set; }

        /// <summary>
        /// Relationship Status
        /// </summary>
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string RelationshipStatus { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string Gender { get; set; }

        /// <summary>
        /// IsSectionComplete
        /// </summary>
        [NotMapped]
        bool IsSectionComplete { get; }
    }
}
