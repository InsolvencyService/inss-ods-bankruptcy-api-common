﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Payments
{
    public class RefundQueryResultDto
    {
        public string AdjReference { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Reason { get; set; }
        public string PaymentType { get; set; }
        public decimal RefundAmount { get; set; }
        public string BankName { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
    }
}
