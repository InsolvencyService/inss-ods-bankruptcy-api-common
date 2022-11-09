using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors
{
    public interface ICreditor
    {
        int Id { get; set; }

        [DataMember(IsRequired = false), DataType(DataType.Text)]
        string SourceRef { get; set; }

        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string CreditorName { get; set; }

        [DataMember]
        Address CreditorAddress { get; set; }

    }
}
