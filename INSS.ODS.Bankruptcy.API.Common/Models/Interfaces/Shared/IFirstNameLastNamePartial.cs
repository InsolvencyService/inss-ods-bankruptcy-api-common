using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IFirstNameLastNamePartial : IFirstName, ILastName
    {
    }
}
