using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Shared
{
    public class CreationDateDto
    {
        public string Reference { get; set; }
        public DateTime? ApplicationCreatedDate { get; set; }
    }
}
