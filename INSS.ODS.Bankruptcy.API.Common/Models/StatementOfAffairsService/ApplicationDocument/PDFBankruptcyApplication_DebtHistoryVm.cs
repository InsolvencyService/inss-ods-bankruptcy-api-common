using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService
{
    public class PDFBankruptcyApplication_DebtHistoryVm
    {
        public PDFBankruptcyApplication_DebtHistoryVm()
        {
            BankruptcyHistory = new List<BankruptcyHistoryVm>();
            IndividualVoluntaryAgreementHistory = new List<IndividualVoluntaryAgreementHistoryVm>();
            PreferentialPaymentHistory = new List<PreferentialPaymentHistoryVm>();

            DebtDetails = new DebtDetailsVm();
        }

        public PDFBankruptcyApplication_DebtHistoryVm(ApplicantIdentity applicantIdentity)
        {
            BankruptcyHistory = new List<BankruptcyHistoryVm>();
            IndividualVoluntaryAgreementHistory = new List<IndividualVoluntaryAgreementHistoryVm>();
            PreferentialPaymentHistory = new List<PreferentialPaymentHistoryVm>();

            DebtDetails = new DebtDetailsVm();

            if (applicantIdentity.DebtReliefOptionsUsed != null)
            {
                var bankruptcyOptionsUsed = applicantIdentity.DebtReliefOptionsUsed.Where(x => (x.DebtReliefOptionType.ToLower() == DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_Bankruptcy_Label.ToLower())
                    && (x.DebtReliefOptionStartDate.Date >= DateTime.Now.AddYears(-2).Date))
                    .ToList();

                if (bankruptcyOptionsUsed.Any())
                {
                    foreach (var debtReliefOptionUsed in bankruptcyOptionsUsed)
                    {
                        BankruptcyHistory.Add(new BankruptcyHistoryVm()
                        {
                            Date = debtReliefOptionUsed.DebtReliefOptionStartDate,
                            ReferenceNumber = debtReliefOptionUsed.DebtReliefOptionReferenceNumber.ToUpper(),
                            OptionType = debtReliefOptionUsed.DebtReliefOptionType
                        });
                    }
                }

                var voluntaryInsolvencyAgreementOptionsUsed = applicantIdentity.DebtReliefOptionsUsed.Where(x => (x.DebtReliefOptionType.ToLower() == DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_IndividualVoluntaryArrangement_Label.ToLower())
                    && (x.DebtReliefOptionStartDate.Date >= DateTime.Now.AddYears(-2).Date))
                    .ToList();

                if (voluntaryInsolvencyAgreementOptionsUsed.Any())
                {
                    foreach (var debtReliefOptionUsed in voluntaryInsolvencyAgreementOptionsUsed)
                    {
                        IndividualVoluntaryAgreementHistory.Add(new IndividualVoluntaryAgreementHistoryVm()
                        {
                            Date = debtReliefOptionUsed.DebtReliefOptionStartDate
                        });
                    }
                }
            }

            if (applicantIdentity.DebtHistory != null && applicantIdentity.PreferentialPayments != null)
            {
                if (applicantIdentity.DebtHistory.HasAnsweredDebtExtraPaymentsMadeQuestion.HasValue)
                {
                    if (applicantIdentity.DebtHistory.HasAnsweredDebtExtraPaymentsMadeQuestion.Value)
                    {
                        var preferentialPaymentsMade = applicantIdentity.PreferentialPayments.Where(x => (x.PreferentialPaymentDetail != null)
                            && (x.PreferentialPaymentDetail.PaymentDate.HasValue)
                            && (x.PreferentialPaymentDetail.PaymentDate.Value >= DateTime.Now.AddYears(-2).Date))
                            .ToList();

                        if (preferentialPaymentsMade.Any())
                        {
                            foreach (var preferentialPayment in preferentialPaymentsMade)
                            {
                                PreferentialPaymentHistory.Add(new PreferentialPaymentHistoryVm()
                                {
                                    CreditorName = preferentialPayment.PreferredCreditor.CreditorName.ToUpper(),
                                    Date = preferentialPayment.PreferentialPaymentDetail.PaymentDate.Value,
                                    Amount = Convert.ToInt32(preferentialPayment.PreferentialPaymentDetail.PaymentAmount.Value)
                                });
                            }
                        }

                        HasApplicantMadePreferentialPayments = true;
                    }
                    else
                    {
                        HasApplicantMadePreferentialPayments = false;
                    }
                }
            }

            if (applicantIdentity.DebtIncurredDetail != null && applicantIdentity.DebtHistory != null)
            {

                HasDebtReasonsBeenCompleted = applicantIdentity.DebtHistory.HasEnteredDebtIncurredDetails.HasValue
                    ? applicantIdentity.DebtHistory.HasEnteredDebtIncurredDetails.Value
                    : false;

                DebtDetails.DateRealised = applicantIdentity.DebtIncurredDetail.StartDate;
                DebtDetails.GamblingAmount = Convert.ToInt32(applicantIdentity.DebtIncurredDetail.GamblingAmount ?? 0);
                DebtDetails.WasDueToGambling = applicantIdentity.DebtIncurredDetail.PersonalGambling;

                var reasons = new StringBuilder();

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalRelationshipBreakdown ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalRelationshipBreakdown_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalRelationshipBreakdown ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalRelationshipBreakdown_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalSpendingMoreThanEarning ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalSpendingMoreThanEarning_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalSpendingMoreThanEarning ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalSpendingMoreThanEarning_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalIllnessOrAccident ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalIllnessOrAccident_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalIllnessOrAccident ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalIllnessOrAccident_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalRedundancyOrLostJob ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalRedundancyOrLostJob_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalRedundancyOrLostJob ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalRedundancyOrLostJob_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalReducedEmployment ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalReducedEmployment_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalReducedEmployment ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalReducedEmployment_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalReductionInIncome ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalReductionInIncome_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalReductionInIncome ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalReductionInIncome_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalReductionInHouseholdIncome ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalReductionInHouseholdIncome_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalReductionInHouseholdIncome ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalReductionInHouseholdIncome_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalIncreasedInterestRates ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalIncreasedInterestRates_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalIncreasedInterestRates ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalIncreasedInterestRates_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalGambling ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalGambling_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalGambling ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalGambling_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalVictimOfFraud ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalVictimOfFraud_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalVictimOfFraud ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalVictimOfFraud_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalDrugsAndOrAlchohol ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalDrugsAndOrAlchohol_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalDrugsAndOrAlchohol ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalDrugsAndOrAlchohol_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalOther ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalOther_Reason_Label + applicantIdentity.DebtIncurredDetail.PersonalOtherText : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.PersonalOther ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_PersonalOther_Reason_Label + applicantIdentity.DebtIncurredDetail.PersonalOtherText : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessLossOfCustomerOrMarket ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessLossOfCustomerOrMarket_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessLossOfCustomerOrMarket ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessLossOfCustomerOrMarket_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessCustomersFailedToPay ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessCustomersFailedToPay_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessCustomersFailedToPay ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessCustomersFailedToPay_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessLossOfFinancialBacking ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessLossOfFinancialBacking_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessLossOfFinancialBacking ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessLossOfFinancialBacking_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessFailedToDealWithTaxes ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessFailedToDealWithTaxes_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessFailedToDealWithTaxes ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessFailedToDealWithTaxes_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessTooHighOverheads ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessTooHighOverheads_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessTooHighOverheads ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessTooHighOverheads_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessVictimOfBusinessFraud ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessVictimOfBusinessFraud_Reason_Label : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessVictimOfBusinessFraud ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessVictimOfBusinessFraud_Reason_Label : "");
                }

                if (reasons.Length == 0)
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessOther ? DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessOther_Reason_Label + applicantIdentity.DebtIncurredDetail.BusinessOtherText : "");
                }
                else
                {
                    reasons.Append(applicantIdentity.DebtIncurredDetail.BusinessOther ? ", " + DebtIncurredDetailResources.Debt_DebtIncurredDetail_BusinessOther_Reason_Label + applicantIdentity.DebtIncurredDetail.BusinessOtherText : "");
                }

                DebtDetails.Reasons = reasons.ToString().ToUpper();
            }
        }


        public bool HasApplicantBeenBankruptBefore { get { return BankruptcyHistory.Count > 0; } }

        public List<BankruptcyHistoryVm> BankruptcyHistory { get; set; }

        public bool HasApplicantUsedIndividualVoluntaryAgreementBefore { get { return IndividualVoluntaryAgreementHistory.Count > 0; } }

        public List<IndividualVoluntaryAgreementHistoryVm> IndividualVoluntaryAgreementHistory { get; set; }

        public bool? HasApplicantMadePreferentialPayments { get; set; }

        public List<PreferentialPaymentHistoryVm> PreferentialPaymentHistory { get; set; }

        public bool HasDebtReasonsBeenCompleted { get; set; }

        public DebtDetailsVm DebtDetails { get; set; }
    }
}