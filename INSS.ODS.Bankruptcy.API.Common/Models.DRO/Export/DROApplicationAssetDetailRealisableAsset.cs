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
public partial class DROApplicationAssetDetailRealisableAsset
{
    
    private string _assetDescription;
    
    private System.Nullable<decimal> _assetValue;
    
    public string AssetDescription
    {
        get
        {
            return this._assetDescription;
        }
        set
        {
            this._assetDescription = value;
        }
    }
    
    [XmlElement(IsNullable=true)]
    public System.Nullable<decimal> AssetValue
    {
        get
        {
            return this._assetValue;
        }
        set
        {
            this._assetValue = value;
        }
    }
}
}
#pragma warning restore