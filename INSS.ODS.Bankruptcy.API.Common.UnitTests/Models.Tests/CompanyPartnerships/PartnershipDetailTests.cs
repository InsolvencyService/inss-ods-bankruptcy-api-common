using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation.TestHelper;


namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

[TestClass]
public class PartnershipDetailTests
{
    private PartnershipDetailValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new PartnershipDetailValidator();
    }

    [TestMethod]
    [TestCategory("Partnership Detail")]
    public void PartnershipDetailNoOtherNamesValidModel()
    {
        var partnershipDetail = new PartnershipDetail();

        partnershipDetail.BusinessName = "AA";
        partnershipDetail.BusinessType = "BB";
        partnershipDetail.TradingStartedDate = DateTime.Now.AddDays(-1);

        var validationResult = validator.TestValidate(partnershipDetail);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.BusinessName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.BusinessType);
    }

    [TestMethod]
    [TestCategory("Partnership Detail")]
    public void PartnershipDetailWithOtherNamesValidModel()
    {
        var partnershipDetail = new PartnershipDetail();
        List<PartnershipBusinessName> businessNamesList = new List<PartnershipBusinessName>();

        partnershipDetail.BusinessName = "AA";
        partnershipDetail.BusinessType = "BB";
        partnershipDetail.TradingStartedDate = DateTime.Now.AddDays(-1);

        var businessName = new PartnershipBusinessName();
        businessName.BusinessName = "Test";

        businessNamesList.Add(businessName);

        partnershipDetail.BusinessNames = businessNamesList;

        var validationResult = validator.TestValidate(partnershipDetail);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.BusinessName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate);

        var context = new ValidationContext(partnershipDetail, null, null);
        var results = new List<ValidationResult>();
        var isModelStateValid = Validator.TryValidateObject(partnershipDetail, context, results, true);

        Assert.IsTrue(isModelStateValid);
    }

    [TestMethod]
    [TestCategory("Partnership Detail")]
    public void PartnershipDetailNoOtherNamesInValidModel()
    {
        var partnershipDetail = new PartnershipDetail();

        partnershipDetail.BusinessName = "AA";
        partnershipDetail.TradingStartedDate = DateTime.Now.AddDays(-1);

        var validationResult = validator.TestValidate(partnershipDetail);

        validationResult.ShouldHaveValidationErrorFor(x => x.BusinessType);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.BusinessName);
    }

    [TestMethod]
    [TestCategory("Partnership Detail")]
    public void SelfEmployedBusinessDetailWithOtherNamesInValidModel()
    {
        var partnershipDetail = new PartnershipDetail();
        List<PartnershipBusinessName> businessNamesList = new List<PartnershipBusinessName>();



        partnershipDetail.BusinessName = "AA";
        partnershipDetail.BusinessType = "BB";
        partnershipDetail.TradingStartedDate = DateTime.Now.AddDays(-1);

        var businessName = new PartnershipBusinessName();

        businessNamesList.Add(businessName);

        partnershipDetail.BusinessNames = businessNamesList;

        var validationResult = validator.TestValidate(partnershipDetail);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.BusinessName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate);

        var context = new ValidationContext(partnershipDetail, null, null);
        var results = new List<ValidationResult>();
        var isModelStateValid = Validator.TryValidateObject(partnershipDetail, context, results, true);

        Assert.IsTrue(isModelStateValid);
    }

}
