using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model
{
    public class StringDto
    {
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
