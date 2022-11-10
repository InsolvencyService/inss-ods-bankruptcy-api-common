using System;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class EnforcementVisitTests
    {
        [TestMethod]
        public void EnforcementVisitInvalid()
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
                EnforcementVisit = new EnforcementVisit
                {

                },
                CreditorAddress = new Address()
                {
                    Address_1 = "AA",
                    PostCode = "BB",
                    Country = "CC"
                }
            };
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);

            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState.ContainsKey("EnforcementVisit.VisitDate"));
            Assert.IsTrue(modelState.ContainsKey("EnforcementVisit.ItemsSeizedOrSold"));

        }

        [TestMethod]
        public void EnforcementVisitValid()
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
                EnforcementVisit = new EnforcementVisit
                {
                    ItemsSeizedOrSold = true,
                    VisitDate = DateTime.Today
                },
                CreditorAddress = new Address()
                {
                    Address_1 = "AA",
                    PostCode = "BB",
                    Country = "CC",
                    TownCity = "test"
                }
            };
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);
            Assert.IsTrue(modelState.IsValid);
        }



    }
}
