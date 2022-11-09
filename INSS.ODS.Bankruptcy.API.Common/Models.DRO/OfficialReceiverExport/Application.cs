using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class Application
    {
        /// <summary>
        /// This is the DRO units ISCIS reference, it will only be populated after case creation
        /// </summary>
        public int? ApplicationId { get; set; }
        public int? IntermediaryId { get; set; }
        public string CaseDescription {
            get
            {
                StringBuilder description = new StringBuilder();
                if (PersonalDetails != null) { description.Append(PersonalDetails.FullName); }

                //Add occupation type
                if (EmploymentDetails != null && EmploymentDetails.OccupationType.Count > 0)
                {
                    if (description.Length > 0) { description.Append(", "); }
                    description.Append(EmploymentDetails.OccupationType[0]);
                }

                if (PersonalDetails != null)
                {
                    //Add current address unless withheld
                    if (!AddressWithheld && PersonalDetails.CurrentAddress != null)
                    {
                        description.Append(" of ");
                        description.Append(PersonalDetails.CurrentAddress.SingleLineAddress);
                    }

                    if (PersonalDetails.PreviousAddresses != null)
                    {
                        foreach (var previousAddress in PersonalDetails.PreviousAddresses)
                        {
                            description.AppendFormat(" formerly of {0}", previousAddress.SingleLineAddress);
                        }
                    }
                }

                if (EmploymentDetails != null)
                {
                    if (EmploymentDetails.BusinessDetail != null)
                    {
                        foreach (var businessDetail in EmploymentDetails.BusinessDetail)
                        {
                            description.AppendFormat(" carrying on business as {0}", businessDetail.TradingInformation);

                            if (businessDetail.BusinessOnOwn.HasValue)
                            {
                                if (!businessDetail.BusinessOnOwn.Value)
                                {
                                    description.AppendFormat(" with others, ");
                                }
                                else
                                {
                                    description.AppendFormat(", ");
                                }
                            }

                            description.Append(businessDetail.Address.SingleLineAddress);
                        }
                    }

                    // Add formerly carrying on as
                    if (EmploymentDetails.PreviousTradingDetails != null)
                    {
                        foreach (var previousTrading in EmploymentDetails.PreviousTradingDetails)
                        {
                            description.AppendFormat(" formerly carrying on business as {0}", previousTrading.PreviousTradingName);

                            if (previousTrading.PreviousOnOwn.HasValue)
                            {
                                if (!previousTrading.PreviousOnOwn.Value)
                                {
                                    description.Append(" with others, ");
                                }
                                else
                                {
                                    description.Append(", ");
                                }
                            }

                            description.Append(previousTrading.TradingAddress.SingleLineAddress);
                        }
                    }
                }

                    return description.ToString();
            }
            set { }
        }

        public List<ApplicationCreditor> Creditors { get; set; }
        public InsolvencyHistory InsolvencyHistory { get; set; }
        public EmploymentDetail EmploymentDetails { get; set; }
        public Asset Assets { get; set; }
        public List<PensionDetail> PensionDetails { get; set; }
        public PropertyOrCreditor PropertyOrCreditorDetails { get; set; }
        public FinancialStatement FinancialStatement { get; set; }
        public PersonalDetail PersonalDetails { get; set; }
        public string DebtorSubmissionDetail { get; set; }
        public string IntermediarySubmissionDetail { get; set; }
        public bool? DebtorNotPresent { get; set; }
        public string IntermediaryCommentary { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime StartDate { get; set; }
        public string IntermediaryCompany { get; set; }
        public bool AddressWithheld { get; set; }
    }
}
