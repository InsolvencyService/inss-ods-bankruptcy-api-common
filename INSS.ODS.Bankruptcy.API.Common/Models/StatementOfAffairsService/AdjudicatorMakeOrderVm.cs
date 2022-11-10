using INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService
{
    [Serializable]
    public class AdjudicatorMakeOrderVm
    {
        [Required]
        public string Urn { get; set; }

        public string BKTReference { get; set; }

        public DateTime SubmittedDate { get; set; }

        public PersonalDetailsExportDTO PersonalDetails { get; set; }

        public IList<OccupancyDetailsExportDTO> OccupancyDetails { get; set; }

        public ContactDetailsExportDTO ContactDetails { get; set; }
     
        public IList<OtherNameExportDTO> OtherNames { get; set; }  

        public bool ECApplicable { get; set; }

        public bool EPApplicable { get; set; }

        public string OrderText { get; set; }
    }  
}