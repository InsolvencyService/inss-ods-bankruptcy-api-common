using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.DRO.Model.OfficialReceiverExport
{
    [TestClass]
    public class ApplicationTests
    {
        [TestMethod]
        public void Application_CaseDescription_Empty()
        {
            var model = new Application();

            var result = model.CaseDescription;

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void Application_CaseDescription_Unemployed()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Unemployed" }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Unemployed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_Employed()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Employed" },
                    Employer = new List<Employer>()
                    {
                        new Employer()
                        {
                            EmployerName = "Employer",
                            JobTitle = "A Job",
                            Address = new Address()
                            {
                                Line1 = "34 A Road",
                                Line2 = "Line 2",
                                Line3 = "Line 3",
                                Town = "Town",
                                County = "County",
                                Postcode = "Postcode",
                                Country = "Country"
                            },
                            EmploymentStartDate = new DateTime(2010, 1, 1)
                        }
                    }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Employed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_UnemployedAndAddressWithheld()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Unemployed" }
                },
                AddressWithheld = true
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Unemployed", result);
        }

        [TestMethod]
        public void Application_CaseDescription_FivePreviousAddresses()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    },
                    PreviousAddresses = new List<Address>()
                    {
                        new Address()
                        {
                            Line1 = "1 Old Road",
                            Town = "Old Town",
                            County = "County",
                            Postcode = "Postcode",
                            Country = "Country"
                        },
                        new Address()
                        {
                            Line1 = "2 Older Road",
                            Town = "Older Town",
                            County = "County",
                            Postcode = "Postcode",
                            Country = "Country"
                        },
                        new Address()
                        {
                            Line1 = "3 Older Road",
                            Town = "Older Town",
                            County = "County",
                            Postcode = "Postcode",
                            Country = "Country"
                        },
                        new Address()
                        {
                            Line1 = "4 Older Road",
                            Town = "Older Town",
                            County = "County",
                            Postcode = "Postcode",
                            Country = "Country"
                        },
                        new Address()
                        {
                            Line1 = "5 Older Road",
                            Town = "Older Town",
                            County = "County",
                            Postcode = "Postcode",
                            Country = "Country"
                        }
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Unemployed" }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Unemployed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country formerly of 1 Old Road, Old Town, County, Postcode, Country formerly of 2 Older Road, Older Town, County, Postcode, Country formerly of 3 Older Road, Older Town, County, Postcode, Country formerly of 4 Older Road, Older Town, County, Postcode, Country formerly of 5 Older Road, Older Town, County, Postcode, Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_SelfEmployed()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Self Employed" },
                    BusinessDetail = new List<BusinessDetail>()
                    {
                        new BusinessDetail()
                        {
                            TypeOfBusiness = "Shop",
                            TradingInformation = "We Sell Things",
                            Address = new Address()
                            {
                                Line1 = "BD1 L1",
                                Line2 = "BD1 L2",
                                Line3 = "BD1 L3",
                                Town = "BD1 Town",
                                County = "BD1 County",
                                Postcode = "B01 DL0",
                                Country = "BD Country"
                            },
                            BusinessOnOwn = true,
                            //Not used anymore
                            MainCentreUk = null,
                            InsuranceUndertaking = null,
                            OutsideEc = null,
                        }
                    }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Self Employed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country carrying on business as We Sell Things, BD1 L1, BD1 L2, BD1 L3, BD1 Town, BD1 County, B01 DL0, BD Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_SelfEmployedWithOthers()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Self Employed" },
                    BusinessDetail = new List<BusinessDetail>()
                    {
                        new BusinessDetail()
                        {
                            TypeOfBusiness = "Shop",
                            TradingInformation = "We Sell Things",
                            Address = new Address()
                            {
                                Line1 = "BD1 L1",
                                Line2 = "BD1 L2",
                                Line3 = "BD1 L3",
                                Town = "BD1 Town",
                                County = "BD1 County",
                                Postcode = "B01 DL0",
                                Country = "BD Country"
                            },
                            BusinessOnOwn = false,
                            //Not used anymore
                            MainCentreUk = null,
                            InsuranceUndertaking = null,
                            OutsideEc = null,
                        }
                    }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Self Employed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country carrying on business as We Sell Things with others, BD1 L1, BD1 L2, BD1 L3, BD1 Town, BD1 County, B01 DL0, BD Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_SelfEmployedMultipleJobs()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Self Employed" },
                    BusinessDetail = new List<BusinessDetail>()
                    {
                        new BusinessDetail()
                        {
                            TypeOfBusiness = "Shop",
                            TradingInformation = "We Sell Things",
                            Address = new Address()
                            {
                                Line1 = "BD1 L1",
                                Line2 = "BD1 L2",
                                Line3 = "BD1 L3",
                                Town = "BD1 Town",
                                County = "BD1 County",
                                Postcode = "B01 DL0",
                                Country = "BD1 Country"
                            },
                            BusinessOnOwn = true,
                            //Not used anymore
                            MainCentreUk = null,
                            InsuranceUndertaking = null,
                            OutsideEc = null,
                        },
                        new BusinessDetail()
                        {
                            TypeOfBusiness = "Shop",
                            TradingInformation = "Also Sells Things",
                            Address = new Address()
                            {
                                Line1 = "BD2 L1",
                                Line2 = "BD2 L2",
                                Line3 = "BD2 L3",
                                Town = "BD2 Town",
                                County = "BD2 County",
                                Postcode = "B02 DL0",
                                Country = "BD2 Country"
                            },
                            BusinessOnOwn = true,
                            //Not used anymore
                            MainCentreUk = null,
                            InsuranceUndertaking = null,
                            OutsideEc = null,
                        }
                    }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Self Employed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country carrying on business as We Sell Things, BD1 L1, BD1 L2, BD1 L3, BD1 Town, BD1 County, B01 DL0, BD1 Country carrying on business as Also Sells Things, BD2 L1, BD2 L2, BD2 L3, BD2 Town, BD2 County, B02 DL0, BD2 Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_PreviousTrading()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Self Employed" },
                    PreviousTradingDetails = new List<PreviousTrading>()
                    {
                        new PreviousTrading()
                        {
                            DateCeased = new DateTime(1999, 1, 1),
                            PreviousTradingName = "Prev Trading",
                            TradingAddress = new Address()
                            {
                                Line1 = "PT1 L1",
                                Line2 = "PT1 L2",
                                Line3 = "PT1 L3",
                                Town = "PT1 Town",
                                County = "PT1 County",
                                Postcode = "PT1 DL0",
                                Country = "PT1 Country"
                            },
                            PreviousOnOwn = true,
                        }
                    }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Self Employed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country formerly carrying on business as Prev Trading, PT1 L1, PT1 L2, PT1 L3, PT1 Town, PT1 County, PT1 DL0, PT1 Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_PreviousTradingWithOthers()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Self Employed" },
                    PreviousTradingDetails = new List<PreviousTrading>()
                    {
                        new PreviousTrading()
                        {
                            DateCeased = new DateTime(1999, 1, 1),
                            PreviousTradingName = "Prev Trading",
                            TradingAddress = new Address()
                            {
                                Line1 = "PT1 L1",
                                Line2 = "PT1 L2",
                                Line3 = "PT1 L3",
                                Town = "PT1 Town",
                                County = "PT1 County",
                                Postcode = "PT1 DL0",
                                Country = "PT1 Country"
                            },
                            PreviousOnOwn = false,
                        }
                    }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Self Employed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country formerly carrying on business as Prev Trading with others, PT1 L1, PT1 L2, PT1 L3, PT1 Town, PT1 County, PT1 DL0, PT1 Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_PreviousTradingMultipleDetails()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Self Employed" },
                    PreviousTradingDetails = new List<PreviousTrading>()
                    {
                        new PreviousTrading()
                        {
                            DateCeased = new DateTime(1999, 1, 1),
                            PreviousTradingName = "Prev Trading 1",
                            TradingAddress = new Address()
                            {
                                Line1 = "PT1 L1",
                                Line2 = "PT1 L2",
                                Line3 = "PT1 L3",
                                Town = "PT1 Town",
                                County = "PT1 County",
                                Postcode = "PT1 DL0",
                                Country = "PT1 Country"
                            },
                            PreviousOnOwn = true,
                        },
                        new PreviousTrading()
                        {
                            DateCeased = new DateTime(1999, 1, 1),
                            PreviousTradingName = "Also Prev Trading",
                            TradingAddress = new Address()
                            {
                                Line1 = "PT2 L1",
                                Line2 = "PT2 L2",
                                Line3 = "PT2 L3",
                                Town = "PT2 Town",
                                County = "PT2 County",
                                Postcode = "PT2 DL0",
                                Country = "PT2 Country"
                            },
                            PreviousOnOwn = true,
                        }
                    }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Self Employed of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country formerly carrying on business as Prev Trading 1, PT1 L1, PT1 L2, PT1 L3, PT1 Town, PT1 County, PT1 DL0, PT1 Country formerly carrying on business as Also Prev Trading, PT2 L1, PT2 L2, PT2 L3, PT2 Town, PT2 County, PT2 DL0, PT2 Country", result);
        }

        [TestMethod]
        public void Application_CaseDescription_InformationOrdering()
        {
            var model = new Application()
            {
                PersonalDetails = new PersonalDetail()
                {
                    Forename = "Bill",
                    Surname = "Billson",
                    CurrentAddress = new Address()
                    {
                        Line1 = "34 A Road",
                        Line2 = "Line 2",
                        Line3 = "Line 3",
                        Town = "Town",
                        County = "County",
                        Postcode = "Postcode",
                        Country = "Country"
                    },
                    PreviousAddresses = new List<Address>()
                    {
                        new Address()
                        {
                            Line1 = "1 Old Road",
                            Line2 = "O2",
                            Line3 = "O3",
                            Town = "Old Town",
                            County = "County",
                            Postcode = "Postcode",
                            Country = "Country"
                        }
                    }
                },
                EmploymentDetails = new EmploymentDetail()
                {
                    OccupationType = new List<string> { "Student" },
                    PreviousTradingDetails = new List<PreviousTrading>()
                    {
                        new PreviousTrading()
                        {
                            DateCeased = new DateTime(1999, 1, 1),
                            PreviousTradingName = "Prev Trading",
                            TradingAddress = new Address()
                            {
                                Line1 = "PT1 L1",
                                Line2 = "PT1 L2",
                                Line3 = "PT1 L3",
                                Town = "PT1 Town",
                                County = "PT1 County",
                                Postcode = "PT1 DL0",
                                Country = "PT1 Country"
                            },
                            PreviousOnOwn = false,
                        }
                    },
                    BusinessDetail = new List<BusinessDetail>()
                    {
                        new BusinessDetail()
                        {
                            TypeOfBusiness = "Shop",
                            TradingInformation = "We Sell Things",
                            Address = new Address()
                            {
                                Line1 = "BD1 L1",
                                Line2 = "BD1 L2",
                                Line3 = "BD1 L3",
                                Town = "BD1 Town",
                                County = "BD1 County",
                                Postcode = "B01 DL0",
                                Country = "BD1 Country"
                            },
                            BusinessOnOwn = false,
                            //Not used anymore
                            MainCentreUk = null,
                            InsuranceUndertaking = null,
                            OutsideEc = null,
                        }
                    }
                }
            };

            var result = model.CaseDescription;

            Assert.AreEqual("Bill Billson, Student of 34 A Road, Line 2, Line 3, Town, County, Postcode, Country formerly of 1 Old Road, O2, O3, Old Town, County, Postcode, Country carrying on business as We Sell Things with others, BD1 L1, BD1 L2, BD1 L3, BD1 Town, BD1 County, B01 DL0, BD1 Country formerly carrying on business as Prev Trading with others, PT1 L1, PT1 L2, PT1 L3, PT1 Town, PT1 County, PT1 DL0, PT1 Country", result);
        }
    }
}
