using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Shared
{
    /// <summary>
    /// A simple class to wrap string values
    /// Gets around the "no media formatter for text/plain" error when returning raw strings from WebApi
    /// </summary>
    [DataContract]
    public class StringDto
    {
        [DataMember]
        public string Value { get; set; }

        public StringDto(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
