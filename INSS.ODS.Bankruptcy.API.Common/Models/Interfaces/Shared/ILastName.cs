using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ILastName
    {
        /// <summary>
        /// Last Name of the applicant
        /// </summary>
        string LastName { get; set; }
    }

 }
