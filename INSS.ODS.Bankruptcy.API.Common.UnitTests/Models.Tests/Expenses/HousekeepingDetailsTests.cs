using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.Linq;


namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class HousekeepingDetailsTests
    {
        [TestMethod]
        [TestCategory("Housekeeping Details Tests")]
        public void HousekeepingDetailsValidModel()
        { 
            var housekeepingDetails = new HousekeepingDetails();

            housekeepingDetails.Groceries = 10M;
            housekeepingDetails.Groceries_Frequency = "per week";

            var context = new ValidationContext(housekeepingDetails, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(housekeepingDetails, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        public void HousekeepingTotallingTest()
        { 
            var housekeeping = new HousekeepingDetails();
            
            Assert.IsTrue(housekeeping.IsNotStarted);

            housekeeping. Groceries = 100m;
            housekeeping.Groceries_Frequency = "per week";
            housekeeping.Toiletries = 100m;
            housekeeping.Toiletries_Frequency = "per week";
            housekeeping.Alcohol = 100m;
            housekeeping.Alcohol_Frequency = "per week";
            housekeeping.MealsAtWork = 100m;
            housekeeping.MealsAtWork_Frequency = "per week";

            Assert.IsFalse(housekeeping.IsNotStarted);
            Assert.AreEqual(1733.32m, housekeeping.Total);
        }

    }
}