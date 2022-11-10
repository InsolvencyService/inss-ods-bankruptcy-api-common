using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(BenefitsValidator))]
    [DataContract]
    public class Benefits : ITableBase, IBenefits
    {
        public int Id { get; set; }
        public decimal? ChildTaxCredit { get; set; }
        public string ChildTaxCredit_Frequency { get; set; }
        public decimal? ChildBenefit { get; set; }
        public string ChildBenefit_Frequency { get; set; }
        public decimal? ChildSupport { get; set; }
        public string ChildSupport_Frequency { get; set; }
        public decimal? Universal_Credit { get; set; }
        public string Universal_Credit_Frequency { get; set; }
        public decimal? JobSeekers { get; set; }
        public string JobSeekers_Frequency { get; set; }
        public decimal? Income_Support { get; set; }
        public string Income_Support_Frequency { get; set; }
        public decimal? Working_Tax_Credit { get; set; }
        public string Working_Tax_Credit_Frequency { get; set; }
        public decimal? Sick_Pay { get; set; }
        public string Sick_Pay_Frequency { get; set; }
        public decimal? Disability { get; set; }
        public string Disability_Frequency { get; set; }
        public decimal? Carers_Allowance { get; set; }
        public string Carers_Allowance_Frequency { get; set; }
        public decimal? Housing_Benefit { get; set; }
        public string Housing_Benefit_Frequency { get; set; }
        public decimal? Council_Tax_Support { get; set; }
        public string Council_Tax_Support_Frequency { get; set; }
        public string Other_Text { get; set; }
        public decimal? Other_Value { get; set; }
        public string Other_Frequency { get; set; }

        [NotMapped]
        public decimal? Total
        {
            get
            {
                if (IsNotStarted) { return null;}

                return
                    ValueFrequencyNormalisation.Normalise(ChildTaxCredit, ChildTaxCredit_Frequency)
                    + ValueFrequencyNormalisation.Normalise(ChildBenefit, ChildBenefit_Frequency)
                    + ValueFrequencyNormalisation.Normalise(ChildSupport, ChildSupport_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Universal_Credit, Universal_Credit_Frequency)
                    + ValueFrequencyNormalisation.Normalise(JobSeekers, JobSeekers_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Income_Support, Income_Support_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Working_Tax_Credit, Working_Tax_Credit_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Sick_Pay, Sick_Pay_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Disability, Disability_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Carers_Allowance, Carers_Allowance_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Housing_Benefit, Housing_Benefit_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Council_Tax_Support, Council_Tax_Support_Frequency)
                    + ValueFrequencyNormalisation.Normalise(Other_Value, Other_Frequency);
            }
        }

        [NotMapped]
        public bool IsNotStarted
        {
            get
            {
                return
                    ChildTaxCredit == null
                     && ChildBenefit == null
                     && ChildSupport == null
                     && Universal_Credit == null
                     && JobSeekers == null
                     && Income_Support == null
                     && Working_Tax_Credit == null
                     && Sick_Pay == null
                     && Disability == null
                     && Carers_Allowance == null
                     && Housing_Benefit == null
                     && Council_Tax_Support == null
                     && Other_Value == null;
            }
        }

        /// <summary>
        /// Provides access to benefits as a list, with frequency-normalised values
        /// </summary>
        /// <returns></returns>
        public List<Tuple<String, Decimal>> AsList()
        {
            var result = new List<Tuple<String, Decimal>>();

            if (ChildTaxCredit.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Child_Tax_Credit, ValueFrequencyNormalisation.Normalise(ChildTaxCredit, ChildTaxCredit_Frequency)));
            }

            if (ChildBenefit.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Child_Benefit, ValueFrequencyNormalisation.Normalise(ChildBenefit, ChildBenefit_Frequency)));
            }

            if (ChildSupport.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Child_Support, ValueFrequencyNormalisation.Normalise(ChildSupport, ChildSupport_Frequency)));
            }

            if (Universal_Credit.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Universal_Credit, ValueFrequencyNormalisation.Normalise(Universal_Credit, Universal_Credit_Frequency)));
            }

            if (JobSeekers.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Jobseekers, ValueFrequencyNormalisation.Normalise(JobSeekers, JobSeekers_Frequency)));
            }
            if (Income_Support.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Income_Support, ValueFrequencyNormalisation.Normalise(Income_Support, Income_Support_Frequency)));
            }
            if (Working_Tax_Credit.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Working_Tax_Credit, ValueFrequencyNormalisation.Normalise(Working_Tax_Credit, Working_Tax_Credit_Frequency)));
            }
            if (Sick_Pay.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Sick_Pay, ValueFrequencyNormalisation.Normalise(Sick_Pay, Sick_Pay_Frequency)));
            }
            if (Disability.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Disability, ValueFrequencyNormalisation.Normalise(Disability, Disability_Frequency)));
            }
            if (Carers_Allowance.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Carers, ValueFrequencyNormalisation.Normalise(Carers_Allowance, Carers_Allowance_Frequency)));
            }
            if (Housing_Benefit.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Housing_Benefit, ValueFrequencyNormalisation.Normalise(Housing_Benefit, Housing_Benefit_Frequency)));
            }
            if (Council_Tax_Support.HasValue)
            {
                result.Add(new Tuple<string, decimal>(BenefitsResources.Label_Council_Tax_Support, ValueFrequencyNormalisation.Normalise(Council_Tax_Support, Council_Tax_Support_Frequency)));
            }
            if (Other_Value.HasValue)
            {
                result.Add(new Tuple<string, decimal>(Other_Text, ValueFrequencyNormalisation.Normalise(Other_Value, Other_Frequency)));
            }

            return result;
        }
    }

}