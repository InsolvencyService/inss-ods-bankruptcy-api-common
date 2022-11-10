using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Adjudicator.Constants
{
    /// <summary>
    /// Application status constants
    /// </summary>
    public class StatusConstants
    {
        public const string APPEALED = "Appealed";
        public const string APPEAL_DISMISSED = "Appeal Dismissed";
        public const string APPROVE = "Approve";
        public const string AWAITING_INFORMATION = "Awaiting information";
        public const string INFORMATION_RECEIVED = "Information received";
        public const string ORDER_MADE = "Order Made";
        public const string ORDER_MADE_BY_COURT = "Order Made by Court";
        public const string MANUAL_REFER = "Manual Refer";
        public const string REFER = "Refer";
        public const string REJECTED = "Rejected";
        public const string REJECTED_AFTER_REVIEW = "Rejected after review";
        public const string REVIEW_REQUESTED = "Review Requested";
    }
}