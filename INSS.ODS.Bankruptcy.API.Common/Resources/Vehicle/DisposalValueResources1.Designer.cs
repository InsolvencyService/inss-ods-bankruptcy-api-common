﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle {
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
    public class DisposalValueResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DisposalValueResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle.DisposalValueResources", typeof(DisposalValueResources).Assembly);
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
        public static string Vehicle_DisposalValue_Amount_Error_Scale {
            get {
                return ResourceManager.GetString("Vehicle_DisposalValue_Amount_Error_Scale", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Back.
        /// </summary>
        public static string Vehicle_DisposalValue_BackButton_Label {
            get {
                return ResourceManager.GetString("Vehicle_DisposalValue_BackButton_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue.
        /// </summary>
        public static string Vehicle_DisposalValue_Continue_ButtonText {
            get {
                return ResourceManager.GetString("Vehicle_DisposalValue_Continue_ButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vehicle disposal.
        /// </summary>
        public static string Vehicle_DisposalValue_Page_Title {
            get {
                return ResourceManager.GetString("Vehicle_DisposalValue_Page_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter positive value  for the amount you received for the sale or transfer of the vehicle.
        /// </summary>
        public static string Vehicle_DisposalValue_VehicleValue_Error_PositiveValue {
            get {
                return ResourceManager.GetString("Vehicle_DisposalValue_VehicleValue_Error_PositiveValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter how much you received for the sale or transfer of the vehicle.
        /// </summary>
        public static string Vehicle_DisposalValue_VehicleValue_Error_Required {
            get {
                return ResourceManager.GetString("Vehicle_DisposalValue_VehicleValue_Error_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Leave blank if you didn&apos;t receive any money.
        /// </summary>
        public static string Vehicle_DisposalValue_VehicleValue_Hint {
            get {
                return ResourceManager.GetString("Vehicle_DisposalValue_VehicleValue_Hint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How much did you receive for the sale or transfer of the vehicle?.
        /// </summary>
        public static string Vehicle_DisposalValue_VehicleValue_Label {
            get {
                return ResourceManager.GetString("Vehicle_DisposalValue_VehicleValue_Label", resourceCulture);
            }
        }
    }
}
