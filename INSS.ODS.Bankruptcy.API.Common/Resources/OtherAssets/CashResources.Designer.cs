﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.OtherAssets {
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
    public class CashResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CashResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.OtherAssets.CashResources", typeof(CashResources).Assembly);
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
        ///   Looks up a localized string similar to Please use the correct format, eg £120.50.
        /// </summary>
        public static string OtherAssets_Cash_Amount_Error_Format {
            get {
                return ResourceManager.GetString("OtherAssets_Cash_Amount_Error_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Amount must be greater than £0.
        /// </summary>
        public static string OtherAssets_Cash_Amount_Error_Minimum {
            get {
                return ResourceManager.GetString("OtherAssets_Cash_Amount_Error_Minimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How much money do you currently have in cash?.
        /// </summary>
        public static string OtherAssets_Cash_Amount_Label {
            get {
                return ResourceManager.GetString("OtherAssets_Cash_Amount_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Back.
        /// </summary>
        public static string OtherAssets_Cash_Back_Label {
            get {
                return ResourceManager.GetString("OtherAssets_Cash_Back_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue.
        /// </summary>
        public static string OtherAssets_Cash_Continue_Label {
            get {
                return ResourceManager.GetString("OtherAssets_Cash_Continue_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cash.
        /// </summary>
        public static string OtherAssets_Cash_PageTitle {
            get {
                return ResourceManager.GetString("OtherAssets_Cash_PageTitle", resourceCulture);
            }
        }
    }
}