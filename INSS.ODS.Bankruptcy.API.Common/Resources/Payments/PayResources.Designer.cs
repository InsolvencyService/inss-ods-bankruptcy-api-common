﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.Payments {
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
    public class PayResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PayResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.Payments.PayResources", typeof(PayResources).Assembly);
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
        ///   Looks up a localized string similar to You cannot pay more than the remaining amount.
        /// </summary>
        public static string Payments_Pay_Amount_Error_MaxValue {
            get {
                return ResourceManager.GetString("Payments_Pay_Amount_Error_MaxValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must pay at least £5.
        /// </summary>
        public static string Payments_Pay_Amount_Error_MinValue {
            get {
                return ResourceManager.GetString("Payments_Pay_Amount_Error_MinValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot pay an amount that leaves less than £5 outstanding.
        /// </summary>
        public static string Payments_Pay_Amount_Error_RemainderBelowMinimum {
            get {
                return ResourceManager.GetString("Payments_Pay_Amount_Error_RemainderBelowMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the amount you&apos;d like to pay.
        /// </summary>
        public static string Payments_Pay_Amount_Error_Required {
            get {
                return ResourceManager.GetString("Payments_Pay_Amount_Error_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum card payment is &lt;strong&gt;£5&lt;/strong&gt;.
        /// </summary>
        public static string Payments_Pay_Amount_HintText {
            get {
                return ResourceManager.GetString("Payments_Pay_Amount_HintText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How much would you like to pay?.
        /// </summary>
        public static string Payments_Pay_Amount_Label {
            get {
                return ResourceManager.GetString("Payments_Pay_Amount_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I can&apos;t pay by card.
        /// </summary>
        public static string Payments_Pay_CannotMakeCardPayment_LinkText {
            get {
                return ResourceManager.GetString("Payments_Pay_CannotMakeCardPayment_LinkText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make a card payment.
        /// </summary>
        public static string Payments_Pay_MakePayment_Label {
            get {
                return ResourceManager.GetString("Payments_Pay_MakePayment_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string Payments_Pay_Name_Label {
            get {
                return ResourceManager.GetString("Payments_Pay_Name_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Other payment options.
        /// </summary>
        public static string Payments_Pay_OtherPaymentOptions_Header {
            get {
                return ResourceManager.GetString("Payments_Pay_OtherPaymentOptions_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Left to pay.
        /// </summary>
        public static string Payments_Pay_OutstandingAmount_Label {
            get {
                return ResourceManager.GetString("Payments_Pay_OutstandingAmount_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;You must pay the remaining {0} before you can submit your application.&lt;/strong&gt;.
        /// </summary>
        public static string Payments_Pay_OutstandingAmount_Text {
            get {
                return ResourceManager.GetString("Payments_Pay_OutstandingAmount_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make a fee payment.
        /// </summary>
        public static string Payments_Pay_PageTitle {
            get {
                return ResourceManager.GetString("Payments_Pay_PageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Find out about paying the fee.
        /// </summary>
        public static string Payments_Pay_PayingHelp_LinkText {
            get {
                return ResourceManager.GetString("Payments_Pay_PayingHelp_LinkText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Have someone else make a payment on my behalf.
        /// </summary>
        public static string Payments_Pay_PayOnMyBehalf_LinkText {
            get {
                return ResourceManager.GetString("Payments_Pay_PayOnMyBehalf_LinkText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refund policy.
        /// </summary>
        public static string Payments_Pay_RefundHelp_LinkText {
            get {
                return ResourceManager.GetString("Payments_Pay_RefundHelp_LinkText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Return to my application.
        /// </summary>
        public static string Payments_Pay_Return_LinkText {
            get {
                return ResourceManager.GetString("Payments_Pay_Return_LinkText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View my payment history.
        /// </summary>
        public static string Payments_Pay_ViewPaymentHistory_LinkText {
            get {
                return ResourceManager.GetString("Payments_Pay_ViewPaymentHistory_LinkText", resourceCulture);
            }
        }
    }
}
