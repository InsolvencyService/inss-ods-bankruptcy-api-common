using System;
using INSS.ODS.Bankruptcy.API.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Income
{
    [TestClass]
    public class WagesTests
    {
        [TestMethod]
        public void WagesTotallingTest()
        {
            var wages = new Wages();
            Assert.IsTrue(wages.IsNotStarted);

            wages = new Wages
            {
                NetIncome = 1000,
                NetIncome_Frequency = "per week",
                IncomeTax = 100,
                IncomeTax_Frequency = "per week",
                OverTime = 30,
                OverTime_Frequency = "per week",
                Bonus = 20,
                Bonus_Frequency = "per week",
                OtherPayments = 10,
                OtherPayments_Frequency = "per week"
            };

            Assert.IsFalse(wages.IsNotStarted);

            var total = 4333.33m + 130m + 86.67m + 43.33m;
            Assert.AreEqual(total, wages.Total);

        }
    }
}
