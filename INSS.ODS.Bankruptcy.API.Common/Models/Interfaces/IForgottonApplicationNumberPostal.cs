using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using INSS.ODS.Bankruptcy.API.Common.Models.CustomAttributes;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IForgottenApplicationNumberPostal : IFirstName, ILastName
    {

        String AddressLine1 { get; set; }

        String PostCode { get; set; }

    }
}
