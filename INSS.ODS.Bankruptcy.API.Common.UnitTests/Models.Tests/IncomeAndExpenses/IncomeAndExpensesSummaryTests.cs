using INSS.ODS.Bankruptcy.API.Common.Models.Dto.IncomeAndExpenses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.IncomeAndExpenses
{
    [TestClass]
    public class IncomeAndExpensesSummaryTests
    {
        [TestMethod]
        public void TestIncomeAndExpensesSummaryTotalling()
        {
            var summary = new IncomeAndExpensesSummaryDto
            {
                Wages = 1,
                Benefits = 2,
                Pensions = 3,
                ContributionsFromOthers = 4,
                OtherIncome = 5,
                HomeUtilities = 1,
                PensionInsuranceHealthcare = 2,
                Housekeeping = 3,
                Transport = 4,
                ChildcareAndMaintenance = 5,
                PersonalLeisureExpenses = 6,
                SavingsFinesOtherCosts = 7
            };

            Assert.AreEqual(11, summary.TotalIncome);
            Assert.AreEqual(15, summary.GrandTotalIncome);
            Assert.AreEqual(28, summary.TotalExpenses);

        }
    }
}
