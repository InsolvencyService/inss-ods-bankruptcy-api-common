// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.15
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#pragma warning disable
namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Export
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[Serializable()]
[DebuggerStepThrough()]
[DesignerCategory("code")]
[XmlType(AnonymousType=true, Namespace="http://tempuri.org/DROApplication.xs")]
public partial class DROApplicationFinancialStatement
{
    
    private System.Nullable<decimal> _salary;
    
    private System.Nullable<decimal> _benefitsClaimable;
    
    private System.Nullable<decimal> _pensions;
    
    private System.Nullable<decimal> _otherIncome;
    
    private System.Nullable<decimal> _rent;
    
    private System.Nullable<decimal> _mortgage;
    
    private System.Nullable<decimal> _otherSecuredLoans;
    
    private System.Nullable<decimal> _groundRentandServiceCharges;
    
    private System.Nullable<decimal> _otherUtilities;
    
    private System.Nullable<decimal> _courtFines;
    
    private System.Nullable<decimal> _childSupport;
    
    private System.Nullable<decimal> _aVCPayment;
    
    private System.Nullable<decimal> _lifeInsurance;
    
    private System.Nullable<decimal> _conditionalSale;
    
    private System.Nullable<decimal> _tVLicense;
    
    private System.Nullable<decimal> _telephone;
    
    private System.Nullable<decimal> _travelCost;
    
    private System.Nullable<decimal> _houseKeeping;
    
    private System.Nullable<decimal> _children;
    
    private string _additionalCommentary;
    
    private System.Nullable<decimal> _gas;
    
    private System.Nullable<decimal> _electricity;
    
    private System.Nullable<decimal> _water;
    
    private System.Nullable<decimal> _councilTax;
    
    private System.Nullable<decimal> _monthlyOtherExpenses;
    
    private System.Nullable<decimal> _mortgageEndowmentsandMPPI;
    
    private System.Nullable<decimal> _buildingandContentsInsurance;
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Salary
    {
        get
        {
            return this._salary;
        }
        set
        {
            this._salary = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> BenefitsClaimable
    {
        get
        {
            return this._benefitsClaimable;
        }
        set
        {
            this._benefitsClaimable = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Pensions
    {
        get
        {
            return this._pensions;
        }
        set
        {
            this._pensions = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> OtherIncome
    {
        get
        {
            return this._otherIncome;
        }
        set
        {
            this._otherIncome = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Rent
    {
        get
        {
            return this._rent;
        }
        set
        {
            this._rent = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Mortgage
    {
        get
        {
            return this._mortgage;
        }
        set
        {
            this._mortgage = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> OtherSecuredLoans
    {
        get
        {
            return this._otherSecuredLoans;
        }
        set
        {
            this._otherSecuredLoans = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> GroundRentandServiceCharges
    {
        get
        {
            return this._groundRentandServiceCharges;
        }
        set
        {
            this._groundRentandServiceCharges = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> OtherUtilities
    {
        get
        {
            return this._otherUtilities;
        }
        set
        {
            this._otherUtilities = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> CourtFines
    {
        get
        {
            return this._courtFines;
        }
        set
        {
            this._courtFines = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> ChildSupport
    {
        get
        {
            return this._childSupport;
        }
        set
        {
            this._childSupport = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> AVCPayment
    {
        get
        {
            return this._aVCPayment;
        }
        set
        {
            this._aVCPayment = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> LifeInsurance
    {
        get
        {
            return this._lifeInsurance;
        }
        set
        {
            this._lifeInsurance = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> ConditionalSale
    {
        get
        {
            return this._conditionalSale;
        }
        set
        {
            this._conditionalSale = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> TVLicense
    {
        get
        {
            return this._tVLicense;
        }
        set
        {
            this._tVLicense = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Telephone
    {
        get
        {
            return this._telephone;
        }
        set
        {
            this._telephone = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> TravelCost
    {
        get
        {
            return this._travelCost;
        }
        set
        {
            this._travelCost = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> HouseKeeping
    {
        get
        {
            return this._houseKeeping;
        }
        set
        {
            this._houseKeeping = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Children
    {
        get
        {
            return this._children;
        }
        set
        {
            this._children = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public string AdditionalCommentary
    {
        get
        {
            return this._additionalCommentary;
        }
        set
        {
            this._additionalCommentary = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Gas
    {
        get
        {
            return this._gas;
        }
        set
        {
            this._gas = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Electricity
    {
        get
        {
            return this._electricity;
        }
        set
        {
            this._electricity = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Water
    {
        get
        {
            return this._water;
        }
        set
        {
            this._water = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> CouncilTax
    {
        get
        {
            return this._councilTax;
        }
        set
        {
            this._councilTax = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> MonthlyOtherExpenses
    {
        get
        {
            return this._monthlyOtherExpenses;
        }
        set
        {
            this._monthlyOtherExpenses = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> MortgageEndowmentsandMPPI
    {
        get
        {
            return this._mortgageEndowmentsandMPPI;
        }
        set
        {
            this._mortgageEndowmentsandMPPI = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> BuildingandContentsInsurance
    {
        get
        {
            return this._buildingandContentsInsurance;
        }
        set
        {
            this._buildingandContentsInsurance = value;
        }
    }
}
}
#pragma warning restore
