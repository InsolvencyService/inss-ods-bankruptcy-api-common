using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors
{
    public interface ITypeOfActionTaken
    {

        int Id { get; set; }

        string TypeOfAction { get; set; }


    }
}
