﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.Application {
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
    public class HomeAddressResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HomeAddressResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Application.HomeAddressResources", typeof(HomeAddressResources).Assembly);
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
        ///   Looks up a localized string similar to Continue.
        /// </summary>
        public static string HomeAddress_Continue_Button_Label {
            get {
                return ResourceManager.GetString("HomeAddress_Continue_Button_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide your details.
        /// </summary>
        public static string HomeAddress_Page_Title {
            get {
                return ResourceManager.GetString("HomeAddress_Page_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Whats your home address?.
        /// </summary>
        public static string HomeAddress_Page_Title2 {
            get {
                return ResourceManager.GetString("HomeAddress_Page_Title2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search address.
        /// </summary>
        public static string HomeAddress_Search_Address_Label {
            get {
                return ResourceManager.GetString("HomeAddress_Search_Address_Label", resourceCulture);
            }
        }
    }
}
