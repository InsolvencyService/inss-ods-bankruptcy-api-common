using System;
using System.Diagnostics.Contracts;
using INSS.ODS.Bankruptcy.API.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Income
{
    [TestClass]
    public class ContributionsFromOthersTests
    {
        [TestMethod]
        public void ContributionsFromOthersTestTotalling()
        {
            var contributions = new ContributionsFromOthers();

            Assert.IsTrue(contributions.IsNotStarted);

            contributions.HouseholdPersonContribution = 100;
            contributions.HouseholdPersonContribution_Frequency = "per week";

            Assert.IsFalse(contributions.IsNotStarted);
            Assert.AreEqual(433.33m, contributions.Total);

        }
    }
}
