﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IPropertyAddressPartial
    {
        string Firstline { get; set; }

        string Postalcode { get; set; }
    }
}
