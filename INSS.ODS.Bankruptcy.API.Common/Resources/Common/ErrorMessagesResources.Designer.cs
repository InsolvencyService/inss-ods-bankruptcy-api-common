﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.Common {
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
    public class ErrorMessagesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessagesResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Common.ErrorMessagesResources", typeof(ErrorMessagesResources).Assembly);
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
        ///   Looks up a localized string similar to An error ocurred while trying to process your request.
        /// </summary>
        public static string Bad_Request_Error_Message {
            get {
                return ResourceManager.GetString("Bad_Request_Error_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the correct format for {1}, eg £120.50.
        /// </summary>
        public static string CurrencyPropertyBinder_Invalid_Format {
            get {
                return ResourceManager.GetString("CurrencyPropertyBinder_Invalid_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a value for {1}.
        /// </summary>
        public static string CurrencyPropertyBinder_Invalid_NullValue {
            get {
                return ResourceManager.GetString("CurrencyPropertyBinder_Invalid_NullValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please check the amount you entered. Your answer can only use &apos;£&apos;, &apos;,&apos; ,&apos;.&apos; and numbers..
        /// </summary>
        public static string CurrencyPropertyBinder_Invalid_Value {
            get {
                return ResourceManager.GetString("CurrencyPropertyBinder_Invalid_Value", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please try again.
        /// </summary>
        public static string SystemError_Description {
            get {
                return ResourceManager.GetString("SystemError_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A system error occurred.
        /// </summary>
        public static string SystemError_Header {
            get {
                return ResourceManager.GetString("SystemError_Header", resourceCulture);
            }
        }
    }
}
