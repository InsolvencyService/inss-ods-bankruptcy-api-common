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
    public class CreditorSearchResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CreditorSearchResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Creditors.CreditorSearchResources", typeof(CreditorSearchResources).Assembly);
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
        public static string Creditor_Search_ContinueButton_Label {
            get {
                return ResourceManager.GetString("Creditor_Search_ContinueButton_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creditors name should be between 3 and 50 characters.
        /// </summary>
        public static string Creditor_Search_CreditorName_Error_Length {
            get {
                return ResourceManager.GetString("Creditor_Search_CreditorName_Error_Length", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your creditor&apos;s name.
        /// </summary>
        public static string Creditor_Search_CreditorName_Error_Mandatory {
            get {
                return ResourceManager.GetString("Creditor_Search_CreditorName_Error_Mandatory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For example, ABC Bank Ltd or John Smith. You can add more creditors later..
        /// </summary>
        public static string Creditor_Search_CreditorName_Hint {
            get {
                return ResourceManager.GetString("Creditor_Search_CreditorName_Hint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter the creditor&apos;s name.
        /// </summary>
        public static string Creditor_Search_CreditorName_Label {
            get {
                return ResourceManager.GetString("Creditor_Search_CreditorName_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div id=&quot;firsttime&quot;&gt;&lt;p&gt;If a debt collection agency is involved:&lt;ul class=&quot;rowbottom help list-bullet&quot; id=&quot;deatils&quot;&gt;&lt;li&gt;for sold debts, we only need to know about the debt collection agency&lt;/li&gt;&lt;li&gt;for all other debts, we only need to know about your original creditor&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;&lt;/div&gt;.
        /// </summary>
        public static string Creditor_Search_Page_Content {
            get {
                return ResourceManager.GetString("Creditor_Search_Page_Content", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creditor&apos;s name.
        /// </summary>
        public static string Creditor_Search_Page_Title {
            get {
                return ResourceManager.GetString("Creditor_Search_Page_Title", resourceCulture);
            }
        }
    }
}
