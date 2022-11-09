using System;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class SeizedOrSoldAssetsTests
    {
        [TestMethod]
        public void SeizedOrSoldAssetsInvalid()
        {

            var SeizedAndSoldAssetsList = new List<SeizedAndSoldAssets>();

            SeizedAndSoldAssetsList.Add(new SeizedAndSoldAssets { ItemName = ""});

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
                AttachmentOfEarnings = new AttachmentOfEarnings
                {

                },
                CreditorAddress = new Address()
                {
                    Address_1 = "AA",
                    PostCode = "BB",
                    Country = "CC"
                },
                SeizedAndSoldAssets = SeizedAndSoldAssetsList

            };
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);

            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState.ContainsKey("SeizedAndSOldAssets[0].ItemName"));
            Assert.IsTrue(modelState.ContainsKey("SeizedAndSOldAssets[0].ItemSold"));
            Assert.IsTrue(modelState.ContainsKey("SeizedAndSOldAssets[0].ItemValue"));


        }

        [TestMethod]
        public void SeizedOrSoldAssetsValid()
        {
            var SeizedAndSoldAssetsList = new List<SeizedAndSoldAssets>();

            SeizedAndSoldAssetsList.Add(new SeizedAndSoldAssets { ItemName = "Test", ItemSold = true, ItemValue = 5 });
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
                AttachmentOfEarnings = new AttachmentOfEarnings
                {
                    AmountTaken=5,
                    HowOftenTaken="Weekly"
                },
                CreditorAddress = new Address()
                {
                    Address_1 = "AA",
                    PostCode = "BB",
                    Country = "CC",
                    TownCity = "DD"
                },
                SeizedAndSoldAssets = SeizedAndSoldAssetsList
            };
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);
            Assert.IsTrue(modelState.IsValid);
        }



    }
}
