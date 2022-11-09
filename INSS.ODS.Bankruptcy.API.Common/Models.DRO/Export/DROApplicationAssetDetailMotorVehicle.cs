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
public partial class DROApplicationAssetDetailMotorVehicle
{
    
    private string _make;
    
    private string _model;
    
    private System.Nullable<int> _yearofFirstRegistration;
    
    private string _registrationNumber;
    
    private string _condition;
    
    private System.Nullable<decimal> _value;
    
    [XmlElement(IsNullable=true)]
    public string Make
    {
        get
        {
            return this._make;
        }
        set
        {
            this._make = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public string Model
    {
        get
        {
            return this._model;
        }
        set
        {
            this._model = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<int> YearofFirstRegistration
    {
        get
        {
            return this._yearofFirstRegistration;
        }
        set
        {
            this._yearofFirstRegistration = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public string RegistrationNumber
    {
        get
        {
            return this._registrationNumber;
        }
        set
        {
            this._registrationNumber = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public string Condition
    {
        get
        {
            return this._condition;
        }
        set
        {
            this._condition = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> Value
    {
        get
        {
            return this._value;
        }
        set
        {
            this._value = value;
        }
    }
}
}
#pragma warning restore
