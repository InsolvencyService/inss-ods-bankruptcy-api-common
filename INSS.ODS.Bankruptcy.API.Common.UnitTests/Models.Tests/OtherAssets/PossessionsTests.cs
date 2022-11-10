using System;
using FluentValidation.Results;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Resources.OtherAssets;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.OtherAssets
{
    [TestClass]
    public class PossessionTests
    {
        [TestMethod]
        public void PossessionsValidTest()
        {
            var model = new OtherAssetsPossession();
            var validator = new OtherAssetsPossessionValidator();
            ValidationResult result = null;

            //acceptable for both values to be missing
            model.Amount = null;
            model.Description = String.Empty;
            result = validator.Validate(model);
            Assert.IsTrue(result.IsValid, "Both values can be empty");

            //both values provided
            model.Amount = 1000;
            model.Description = "Test";
            result = validator.Validate(model);
            Assert.IsTrue(result.IsValid, "Valid if both values provided");
        }

        [TestMethod]
        public void PossessionsInvalidTest()
        {
            var model = new OtherAssetsPossession();
            var validator = new OtherAssetsPossessionValidator();
            ValidationResult result = null;

            //Amount must be provided (if description is)
            model.Amount = null;
            model.Description = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Amount must be provided");
            Assert.IsTrue(result.HasError("Amount", PossessionsResources.OtherAssets_Possessions_Amount_Error_Required));

            //Amount must be greater than or equal to 500
            model.Amount = 100;
            model.Description = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Amount must be equal to or greather than 500");
            Assert.IsTrue(result.HasError("Amount", PossessionsResources.OtherAssets_Possessions_Amount_Error_Minimum));

            //Description must be provided (if amount is)
            model.Amount = 100;
            model.Description = String.Empty;
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Description must be provided");
            Assert.IsTrue(result.HasError("Description", PossessionsResources.OtherAssets_Possessions_Description_Error_Required));

        }

    }
}
