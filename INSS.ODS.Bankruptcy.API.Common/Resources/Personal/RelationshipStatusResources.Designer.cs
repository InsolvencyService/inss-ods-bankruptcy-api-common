﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.Personal {
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
    public class RelationshipStatusResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RelationshipStatusResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Personal.RelationshipStatusResources", typeof(RelationshipStatusResources).Assembly);
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
        ///   Looks up a localized string similar to Co-habiting.
        /// </summary>
        public static string Personal_RelationshipStatus_Cohabiting {
            get {
                return ResourceManager.GetString("Personal_RelationshipStatus_Cohabiting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Divorced/former civil partner.
        /// </summary>
        public static string Personal_RelationshipStatus_Divorced {
            get {
                return ResourceManager.GetString("Personal_RelationshipStatus_Divorced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Married/civil partnership.
        /// </summary>
        public static string Personal_RelationshipStatus_Married {
            get {
                return ResourceManager.GetString("Personal_RelationshipStatus_Married", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Single.
        /// </summary>
        public static string Personal_RelationshipStatus_Single {
            get {
                return ResourceManager.GetString("Personal_RelationshipStatus_Single", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Widowed/surviving civil-partner.
        /// </summary>
        public static string Personal_RelationshipStatus_Widowed {
            get {
                return ResourceManager.GetString("Personal_RelationshipStatus_Widowed", resourceCulture);
            }
        }
    }
}
