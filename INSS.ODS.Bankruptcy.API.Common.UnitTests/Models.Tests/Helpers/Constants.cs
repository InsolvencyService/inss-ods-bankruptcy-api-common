using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Helpers
{
    public static class Constants
    {
        /// <summary>
        /// A string that exceeds the standard 100 character length
        /// </summary>
        internal static readonly string InvalidLengthString = new string('A', 101);
    }
}
