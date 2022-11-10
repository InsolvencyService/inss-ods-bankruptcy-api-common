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
public partial class DROApplicationEmploymentDetailEmployer
{
    
    private string _employerName;

    private string _payrollNumber;
    
    private string _jobTitle;
    
    private System.Nullable<System.DateTime> _dateEmploymentStarted;
    
    private System.Nullable<DROApplicationEmploymentDetailEmployerOccupationSubType> _occupationSubType;
    
    private DROAddress _employerAddress;
    
    public DROApplicationEmploymentDetailEmployer()
    {
        this._employerAddress = new DROAddress();
    }
    
    [XmlElement(IsNullable=true)]
    public string EmployerName
    {
        get
        {
            return this._employerName;
        }
        set
        {
            this._employerName = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public string JobTitle
    {
        get
        {
            return this._jobTitle;
        }
        set
        {
            this._jobTitle = value;
        }
    }

    [XmlElement(IsNullable = true)]
    public string PayrollNumber
     {
            get
            {
                return this._payrollNumber;
            }
            set
            {
                this._payrollNumber = value;
            }
      }

        [XmlElement(DataType="date", IsNullable=true)]
    public System.Nullable<System.DateTime> DateEmploymentStarted
    {
        get
        {
            return this._dateEmploymentStarted;
        }
        set
        {
            this._dateEmploymentStarted = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<DROApplicationEmploymentDetailEmployerOccupationSubType> OccupationSubType
    {
        get
        {
            return this._occupationSubType;
        }
        set
        {
            this._occupationSubType = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public DROAddress EmployerAddress
    {
        get
        {
            return this._employerAddress;
        }
        set
        {
            this._employerAddress = value;
        }
    }
}
}
#pragma warning restore
