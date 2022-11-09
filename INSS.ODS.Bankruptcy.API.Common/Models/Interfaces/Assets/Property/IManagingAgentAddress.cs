using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IManagingAgentAddress
    {
        string AgentName { get; set; }

        Address AgentAddress { get; set; }
    }
}