﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.Verify {
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
    public class VerifyExplanationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal VerifyExplanationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Verify.VerifyExplanationResources", typeof(VerifyExplanationResources).Assembly);
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
        ///   Looks up a localized string similar to Continue to GOV.UK Verify.
        /// </summary>
        public static string Verify_Explanation_Continue_Label {
            get {
                return ResourceManager.GetString("Verify_Explanation_Continue_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm your identity.
        /// </summary>
        public static string Verify_Explanation_PageTitle {
            get {
                return ResourceManager.GetString("Verify_Explanation_PageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;&amp;nbsp;&lt;/p&gt;
        ///            &lt;p&gt;GOV.UK Verify takes around 10 minutes to complete and uses certified companies to make sure you&apos;re the person whose name appears on this application.&lt;/p&gt;
        ///
        ///            &lt;div class=&quot;panel-indent&quot;&gt;To use GOV.UK Verify you&apos;ll need at least two forms of ID such as UK passport, photocard driving license or a credit/debit card.&lt;/div&gt;.
        /// </summary>
        public static string Verify_Explanation_PostLogoText_Text {
            get {
                return ResourceManager.GetString("Verify_Explanation_PostLogoText_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;
        ///                Before you submit, we need to confirm your identity. We do this for your own security to make sure
        ///                you are the person named in this application.
        ///                &lt;br&gt;
        ///            &lt;/p&gt;
        ///            &lt;p&gt;To do this we use another GOV.UK service called GOV.UK Verify.&lt;/p&gt;.
        /// </summary>
        public static string Verify_Explanation_PreLogoText_Text {
            get {
                return ResourceManager.GetString("Verify_Explanation_PreLogoText_Text", resourceCulture);
            }
        }
    }
}
