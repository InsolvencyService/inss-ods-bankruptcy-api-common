﻿using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    [Validator(typeof(PARVDetailValidator))]
    public class PARVDetail : ITableBase, IPARVDetail
    {
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string CourtName { get; set; }


        [Required]
        [DataMember]
        public DateTime ApprovedDate { get; set; }

       






    }
}
