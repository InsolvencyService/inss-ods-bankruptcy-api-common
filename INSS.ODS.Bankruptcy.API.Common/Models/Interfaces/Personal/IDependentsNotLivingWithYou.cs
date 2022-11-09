using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IDependentsNotLivingWithYou<T>: IFirstName, ILastName where T : IAddress
    {

        /// <summary>
        /// Age of Dependant
        /// </summary>
        int? Age { get; set; }

        T Address { get; set; } 

        /// <summary>
        /// Relationship
        /// </summary>
        string Relationship { get; set; }

        String RelationshipOther { get; set; }

    }
}
