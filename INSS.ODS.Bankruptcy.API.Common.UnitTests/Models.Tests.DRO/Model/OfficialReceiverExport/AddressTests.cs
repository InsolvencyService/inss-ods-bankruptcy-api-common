using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.DRO.Model.OfficialReceiverExport
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void Address_SingleLine_Empty()
        {
            var model = new Address();

            var result = model.SingleLineAddress;

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void Address_SingleLine_Complete()
        {
            var model = new Address()
            {
                Line1 = "Line 1",
                Line2 = "Line 2",
                Line3 = "Line 3",
                Town = "Town",
                County = "County",
                Postcode = "Postcode",
                Country = "Country"
            };

            var result = model.SingleLineAddress;

            Assert.AreEqual("Line 1, Line 2, Line 3, Town, County, Postcode, Country", result);
        }
    }
}
