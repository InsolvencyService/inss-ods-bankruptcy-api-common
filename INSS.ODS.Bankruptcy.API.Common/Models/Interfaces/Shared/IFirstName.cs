using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IFirstName
    {
        /// <summary>
        /// First Name of the applicant
        /// </summary>
        string FirstName { get; set; }
    }

}
