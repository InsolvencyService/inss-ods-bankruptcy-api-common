﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance {
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
    public class PolicyValueResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PolicyValueResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance.PolicyValueResources", typeof(PolicyValueResources).Assembly);
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
        ///   Looks up a localized string similar to Please select whether you receive any payments from this policy..
        /// </summary>
        public static string PensionAndInsurance_PolicyValue_CurrentlyReceivingPayment_Error_Empty {
            get {
                return ResourceManager.GetString("PensionAndInsurance_PolicyValue_CurrentlyReceivingPayment_Error_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you currently receiving any payments from this policy?.
        /// </summary>
        public static string PensionAndInsurance_PolicyValue_CurrentlyReceivingPayment_Label {
            get {
                return ResourceManager.GetString("PensionAndInsurance_PolicyValue_CurrentlyReceivingPayment_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the correct format, eg £120.50..
        /// </summary>
        public static string PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_Format {
            get {
                return ResourceManager.GetString("PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter how much the policy is currently worth.
        /// </summary>
        public static string PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_Mandatory {
            get {
                return ResourceManager.GetString("PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_Mandatory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a value greater than or equal to zero for how much this policy is currently worth..
        /// </summary>
        public static string PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_NegativeValue {
            get {
                return ResourceManager.GetString("PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_NegativeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p class=&quot;policy&quot;&gt;&lt;span class=&quot;form-hint&quot;&gt;You can find this on your annual statement under &apos;cash surrender value&apos;&lt;/span&gt;&lt;/p&gt; 
        ///&lt;p class=&quot;form-hint&quot;&gt;Leave blank if you&apos;re currently receiving any payments from this policy&lt;span class=&quot;policy&quot;&gt;or if it doesn&apos;t have a cash surrender value.&lt;/span&gt;&lt;/p&gt;.
        /// </summary>
        public static string PensionAndInsurance_PolicyValue_CurrentlyWorth_Hint {
            get {
                return ResourceManager.GetString("PensionAndInsurance_PolicyValue_CurrentlyWorth_Hint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How much is the policy currently worth?.
        /// </summary>
        public static string PensionAndInsurance_PolicyValue_CurrentlyWorth_Label {
            get {
                return ResourceManager.GetString("PensionAndInsurance_PolicyValue_CurrentlyWorth_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Policy Value.
        /// </summary>
        public static string PensionAndInsurance_PolicyValue_PageTitle {
            get {
                return ResourceManager.GetString("PensionAndInsurance_PolicyValue_PageTitle", resourceCulture);
            }
        }
    }
}
