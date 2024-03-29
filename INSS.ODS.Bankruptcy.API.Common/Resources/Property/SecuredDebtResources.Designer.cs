﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.Property {
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
    public class SecuredDebtResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SecuredDebtResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Property.SecuredDebtResources", typeof(SecuredDebtResources).Assembly);
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
        ///   Looks up a localized string similar to For &lt;b&gt;mortgages and secured loans&lt;/b&gt;, this is the bank or building society the mortgage/loan is with&lt;br/&gt;&lt;br/&gt; For &lt;b&gt;charges&lt;/b&gt;, this is the creditor who will be repaid if you sell your property.
        /// </summary>
        public static string Property_SecuredDebt_AddCreditor_Hint1 {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_AddCreditor_Hint1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter the creditor&apos;s name.
        /// </summary>
        public static string Property_SecuredDebt_AddCreditor_Label {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_AddCreditor_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Creditor.
        /// </summary>
        public static string Property_SecuredDebt_AddCreditorButton_Text {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_AddCreditorButton_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Back.
        /// </summary>
        public static string Property_SecuredDebt_BackButton_Text {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_BackButton_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue - I don&apos;t have any secured debts.
        /// </summary>
        public static string Property_SecuredDebt_ContinueButton_Text {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_ContinueButton_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Address.
        /// </summary>
        public static string Property_SecuredDebt_CreditorAddress_Label {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_CreditorAddress_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the name of creditor.
        /// </summary>
        public static string Property_SecuredDebt_CreditorName_Error_Empty {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_CreditorName_Error_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The creditor name must be between 3 and 50 characters long..
        /// </summary>
        public static string Property_SecuredDebt_CreditorName_Error_InvalidLength {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_CreditorName_Error_InvalidLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to add the creditor you typed in below? To add this creditor, please select the green &apos;Add creditor&apos; button..
        /// </summary>
        public static string Property_SecuredDebt_CreditorName_Error_WrongButtonPressed {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_CreditorName_Error_WrongButtonPressed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We need to know about all debts secured against {0}.&lt;br/&gt;&lt;br/&gt;This includes your mortgage, secured loans and any charges (eg a charging order from the court) against the property..
        /// </summary>
        public static string Property_SecuredDebt_Page_Hint1 {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_Page_Hint1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mortgages and secured debts.
        /// </summary>
        public static string Property_SecuredDebt_Page_Title {
            get {
                return ResourceManager.GetString("Property_SecuredDebt_Page_Title", resourceCulture);
            }
        }
    }
}
