using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IApplicantDetails : IFirstName, ILastName, IMiddleNames
    {
        /// <summary>
        /// Date of Birth
        /// </summary>
        [DataMember(IsRequired = true), DataType(DataType.Date)]
        DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Email Address
        /// </summary>
        [DataMember(IsRequired = false), DataType(DataType.EmailAddress)]
        String Email { get; set; }

        [NotMapped]
        [DataMember]
        String ConfirmEmail { get; set; }
    }
}
