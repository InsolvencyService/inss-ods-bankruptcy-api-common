﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INSS.ODS.Bankruptcy.API.Common.Resources.DRO {
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
    public class AccountResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AccountResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("INSS.ODS.Bankruptcy.API.Common.Resources.DRO.AccountResources", typeof(AccountResources).Assembly);
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
        ///   Looks up a localized string similar to Email address.
        /// </summary>
        public static string Account_ForgottenPassword_Email_Label {
            get {
                return ResourceManager.GetString("Account_ForgottenPassword_Email_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Intermediary username.
        /// </summary>
        public static string Account_ForgottenPassword_Username_Label {
            get {
                return ResourceManager.GetString("Account_ForgottenPassword_Username_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your Intermediary ID and password..
        /// </summary>
        public static string Account_Login_Credentials_Error_Empty {
            get {
                return ResourceManager.GetString("Account_Login_Credentials_Error_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Intermediary ID/password combination you&apos;ve entered doesn&apos;t match our records. Please check your ID and password and try again or reset your password..
        /// </summary>
        public static string Account_Login_Credentials_Error_Incorrect {
            get {
                return ResourceManager.GetString("Account_Login_Credentials_Error_Incorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Intermediary ID that you&apos;ve entered is not authorized to access DRO Admin.
        /// </summary>
        public static string Account_Login_Credentials_Error_UnAuthorized {
            get {
                return ResourceManager.GetString("Account_Login_Credentials_Error_UnAuthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Intermediary username.
        /// </summary>
        public static string Account_Login_IntermediaryId_Label {
            get {
                return ResourceManager.GetString("Account_Login_IntermediaryId_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        public static string Account_Login_Password_Label {
            get {
                return ResourceManager.GetString("Account_Login_Password_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your account is currently locked. Please contact the Debt Relief Order Team..
        /// </summary>
        public static string Account_Login_User_LockedOut {
            get {
                return ResourceManager.GetString("Account_Login_User_LockedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username.
        /// </summary>
        public static string Account_Login_Username_Label {
            get {
                return ResourceManager.GetString("Account_Login_Username_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm new password.
        /// </summary>
        public static string Account_ResetPassword_ConfirmPassword_Label {
            get {
                return ResourceManager.GetString("Account_ResetPassword_ConfirmPassword_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New password.
        /// </summary>
        public static string Account_ResetPassword_Password_Label {
            get {
                return ResourceManager.GetString("Account_ResetPassword_Password_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Intermediary username.
        /// </summary>
        public static string Account_ResetPassword_Username_Label {
            get {
                return ResourceManager.GetString("Account_ResetPassword_Username_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete.
        /// </summary>
        public static string Account_SectionStatus_Complete {
            get {
                return ResourceManager.GetString("Account_SectionStatus_Complete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In progress.
        /// </summary>
        public static string Account_SectionStatus_InProgress {
            get {
                return ResourceManager.GetString("Account_SectionStatus_InProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not started.
        /// </summary>
        public static string Account_SectionStatus_NotStarted {
            get {
                return ResourceManager.GetString("Account_SectionStatus_NotStarted", resourceCulture);
            }
        }
    }
}
