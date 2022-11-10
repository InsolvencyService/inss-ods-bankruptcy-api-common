using INSS.ODS.Bankruptcy.API.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Income
{
    [TestClass]
    public class BenefitsTests
    {
        [TestMethod]
        public void BenefitsTotallingTest()
        {
            var benefits = new Benefits();
            Assert.IsTrue(benefits.IsNotStarted);

            benefits.ChildTaxCredit = 100;
            benefits.ChildTaxCredit_Frequency = "per week";
            benefits.ChildBenefit = 100;
            benefits.ChildBenefit_Frequency = "per week";
            benefits.ChildSupport = 100;
            benefits.ChildSupport_Frequency = "per week";
            benefits.Universal_Credit = 100;
            benefits.Universal_Credit_Frequency = "per week";
            benefits.JobSeekers = 100;
            benefits.JobSeekers_Frequency = "per week";
            benefits.Income_Support = 100;
            benefits.Income_Support_Frequency = "per week";
            benefits.Working_Tax_Credit = 100;
            benefits.Working_Tax_Credit_Frequency = "per week";
            benefits.Sick_Pay = 100;
            benefits.Sick_Pay_Frequency = "per week";
            benefits.Disability = 100;
            benefits.Disability_Frequency = "per week";
            benefits.Carers_Allowance = 100;
            benefits.Carers_Allowance_Frequency = "per week";
            benefits.Housing_Benefit = 100;
            benefits.Housing_Benefit_Frequency = "per week";
            benefits.Council_Tax_Support = 100;
            benefits.Council_Tax_Support_Frequency = "per week";
            benefits.Other_Value = 100;
            benefits.Other_Text = "test";
            benefits.Other_Frequency = "per week";

            Assert.IsFalse(benefits.IsNotStarted);
            Assert.AreEqual(5633.29m,  benefits.Total);

        }
    }
}
