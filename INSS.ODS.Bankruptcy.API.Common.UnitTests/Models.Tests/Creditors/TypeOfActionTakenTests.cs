﻿using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class TypeOfActionTakenTests
    {
        [TestMethod]
        public void TestTypeOfActionTakenInvalid()
        {
            var creditor = new Creditor()
            {
                CreditorName = "AA",
                CreditorAction = new CreditorAction()
                {
                    ActionValue = true
                   
                },
                TypeOfActionTaken = new TypeOfActionTaken
                {

                },
                CreditorAddress = new Address()
                {
                    Address_1 = "AA",
                    PostCode = "BB",
                    Country = "CC",
                    TownCity = "DD"
                }
            };
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);

            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState.ContainsKey("TypeOfActionTaken.TypeOfAction"));

        }

        [TestMethod]
        public void TestTypeOfActionTakenValid()
        {
            var creditor = new Creditor()
            {
                CreditorName = "AA",
                CreditorAction = new CreditorAction()
                {
                    ActionValue = true
                   
                },
                TypeOfActionTaken = new TypeOfActionTaken
                {
                    TypeOfAction = "Test"
                },
                CreditorAddress = new Address()
                {
                    Address_1 = "AA",
                    PostCode = "BB",
                    Country = "CC",
                    TownCity ="DD"

                }
            };
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);
            Assert.IsTrue(modelState.IsValid);
        }



    }
}
