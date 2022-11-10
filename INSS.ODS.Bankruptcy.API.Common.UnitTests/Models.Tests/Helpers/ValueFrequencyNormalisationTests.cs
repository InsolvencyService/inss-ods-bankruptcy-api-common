using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Helpers
{
    [TestClass]
    public class ValueFrequencyNormalisationTests
    {
        [TestMethod]
        public void NormalisationNullValueTests()
        {
            Assert.AreEqual(0, ValueFrequencyNormalisation.Normalise(null, "per month"));
            Assert.AreEqual(0, ValueFrequencyNormalisation.Normalise(null, "per year"));
            Assert.AreEqual(0, ValueFrequencyNormalisation.Normalise(null, "per week"));
        }

        [TestMethod]
        public void NormalisationZeroValueTests()
        {
            Assert.AreEqual(0, ValueFrequencyNormalisation.Normalise(0, "per month"));
            Assert.AreEqual(0, ValueFrequencyNormalisation.Normalise(0, "per year"));
            Assert.AreEqual(0, ValueFrequencyNormalisation.Normalise(0, "per week"));
        }

        [TestMethod]
        public void NormalisationWeeklyTests()
        {
            Assert.AreEqual(433.33m, ValueFrequencyNormalisation.Normalise(100, "per week"));
            Assert.AreEqual(216.67m, ValueFrequencyNormalisation.Normalise(100, "per fortnight"));
            Assert.AreEqual(108.33m, ValueFrequencyNormalisation.Normalise(100, "per 4 weeks"));
            Assert.AreEqual(8.33m, ValueFrequencyNormalisation.Normalise(100, "per year"));
            Assert.AreEqual(100m, ValueFrequencyNormalisation.Normalise(100, "per month"));
            Assert.AreEqual(33.33m, ValueFrequencyNormalisation.Normalise(100, "per quarter"));
        }
    }
}
