using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPolicyProvider
    {
        [DataMember]
        string SourceRef { get; set; }

        [DataMember]
        string ProviderName { get; set; }

        [DataMember]
        Address ProviderAddress { get; set; }

    }
}