﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.Creditors {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CreditorActionResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CreditorActionResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Creditors.CreditorActionResources", typeof(CreditorActionResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No.
        /// </summary>
        public static string Creditors_CreditorAction_Action_No_Label {
            get {
                return ResourceManager.GetString("Creditors_CreditorAction_Action_No_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yes.
        /// </summary>
        public static string Creditors_CreditorAction_Action_Yes_Label {
            get {
                return ResourceManager.GetString("Creditors_CreditorAction_Action_Yes_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue.
        /// </summary>
        public static string Creditors_CreditorAction_Continue_Button1_Text {
            get {
                return ResourceManager.GetString("Creditors_CreditorAction_Continue_Button1_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actions taken.
        /// </summary>
        public static string Creditors_CreditorAction_PageTitle {
            get {
                return ResourceManager.GetString("Creditors_CreditorAction_PageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div&gt;
        ///	&lt;p&gt;We need to know if any of your creditors have recently taken formal action against you.&lt;/p&gt;
        ///	&lt;p&gt;Formal action means that they: 
        ///	&lt;/p&gt;&lt;ul class=&quot;list-bullet&quot;&gt;
        ///	&lt;li&gt;currently have an attachment of earnings order against you&lt;/li&gt;
        ///	&lt;li&gt;have taken control of any of your assets in the last 6 months (including via a bailiff or enforcement officer)&lt;/li&gt;
        ///	&lt;/ul&gt;
        ///	&lt;/div&gt;.
        /// </summary>
        public static string Creditors_CreditorAction_PageTitle1 {
            get {
                return ResourceManager.GetString("Creditors_CreditorAction_PageTitle1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select if a creditor has taken an action against you.
        /// </summary>
        public static string Creditors_CreditorAction_Required_Error {
            get {
                return ResourceManager.GetString("Creditors_CreditorAction_Required_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Have they taken formal action against you?.
        /// </summary>
        public static string Creditors_CreditorAction_TableHeader_ActionValue_Label {
            get {
                return ResourceManager.GetString("Creditors_CreditorAction_TableHeader_ActionValue_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creditor.
        /// </summary>
        public static string Creditors_CreditorAction_TableHeader_Name_Label {
            get {
                return ResourceManager.GetString("Creditors_CreditorAction_TableHeader_Name_Label", resourceCulture);
            }
        }
    }
}
