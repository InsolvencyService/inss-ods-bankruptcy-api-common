using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.IncomeAndExpenses
{
    [TestClass]
    public class SelfEmploymentIncomeTests
    {
        private SelfEmploymentIncomeValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new SelfEmploymentIncomeValidator();
        }

        [TestMethod]
        [TestCategory("Self Employment Income")]
        public void SelfEmploymentIncomeValidModel()
        {
            var selfEmploymentIncome = new SelfEmploymentIncome();

            selfEmploymentIncome.Profit = 1;
            selfEmploymentIncome.Profit_Frequency = "Weekly";
            selfEmploymentIncome.AccountingPeriodStart = DateTime.Now.AddDays(-10);
            selfEmploymentIncome.AccountingPeriodEnd = DateTime.Now.AddDays(-1);

            validator.ShouldNotHaveValidationErrorFor(x => x.Profit, selfEmploymentIncome);
            validator.ShouldNotHaveValidationErrorFor(x => x.AccountingPeriodStart, selfEmploymentIncome);
            validator.ShouldNotHaveValidationErrorFor(x => x.AccountingPeriodEnd, selfEmploymentIncome);

        }

      

        [TestMethod]
        [TestCategory("Self Employment Income")]
        public void SelfEmploymentIncomeInValidModelWithProfitGreaterThanZero()
        {
            var selfEmploymentIncome = new SelfEmploymentIncome();
            selfEmploymentIncome.Profit = 10;
            selfEmploymentIncome.Profit_Frequency = "Weekly";

            validator.ShouldHaveValidationErrorFor(x => x.AccountingPeriodStart, selfEmploymentIncome);
            validator.ShouldHaveValidationErrorFor(x => x.AccountingPeriodEnd, selfEmploymentIncome);

        }



    }
}
