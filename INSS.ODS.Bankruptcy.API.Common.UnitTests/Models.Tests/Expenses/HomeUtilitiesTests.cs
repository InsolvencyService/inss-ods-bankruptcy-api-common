using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.Linq;


namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Expenses
{
    [TestClass]
    public class HomeUtilitiesTests
    {
        [TestMethod]
        public void PersonalDetailsValidModel()
        {
            var homeUtilities = new HomeUtilities();

            homeUtilities.Rent = 12.12m;
            homeUtilities.Mortgage = 13.13m;
            homeUtilities.SecuredLoans = 14.14m;
            homeUtilities.GroundRentServiceCharges = 15.15m;
            homeUtilities.BuildingContentInsurance = 16.16m;
            homeUtilities.ApplicanceFurnitureRental = 17.17m;
            homeUtilities.TVLicence = 18.18m;
            homeUtilities.CouncilTax = 19.19m;
            homeUtilities.Gas = 20.20m;
            homeUtilities.Electricity = 21.21m;
            homeUtilities.Water = 22.22m;

            var context = new ValidationContext(homeUtilities, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(homeUtilities, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        public void HomeUtilitiesTotallingTest()
        {
            var utilities = new HomeUtilities();

            Assert.IsTrue(utilities.IsNotStarted);

            utilities.ApplicanceFurnitureRental = 100;
            utilities.ApplicanceFurnitureRental_Frequency = "per week";
            utilities.BuildingContentInsurance = 100;
            utilities.BuildingContentInsurance_Frequency = "per week";
            utilities.CouncilTax = 100;
            utilities.CouncilTax_Frequency = "per week";
            utilities.Electricity = 100;
            utilities.Electricity_Frequency = "per week";
            utilities.Gas = 100;
            utilities.Gas_Frequency = "per week";
            utilities.GroundRentServiceCharges = 100;
            utilities.GroundRentServiceCharges_Frequency = "per week";
            utilities.Mortgage = 100;
            utilities.Mortgage_Frequency = "per week";
            utilities.Rent = 100;
            utilities.Rent_Frequency = "per week";
            utilities.SecuredLoans = 100;
            utilities.SecuredLoans_Frequency = "per week";
            utilities.TVLicence = 100;
            utilities.TVLicence_Frequency = "per week";
            utilities.Water = 100;
            utilities.Water_Frequency = "per week";

            Assert.AreEqual(4766.63m, utilities.Total);
            Assert.IsFalse(utilities.IsNotStarted);

        }

    }
}
