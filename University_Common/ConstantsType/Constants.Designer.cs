﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University_Common.ConstantsType {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Constants {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Constants() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("University_Common.ConstantsType.Constants", typeof(Constants).Assembly);
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
        ///   Looks up a localized string similar to 30.
        /// </summary>
        public static string CountryName {
            get {
                return ResourceManager.GetString("CountryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 80.
        /// </summary>
        public static string EmailLength {
            get {
                return ResourceManager.GetString("EmailLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 11.
        /// </summary>
        public static string MobileLength {
            get {
                return ResourceManager.GetString("MobileLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 10.
        /// </summary>
        public static string NationalCodeLength {
            get {
                return ResourceManager.GetString("NationalCodeLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 11.
        /// </summary>
        public static string TelLength {
            get {
                return ResourceManager.GetString("TelLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to نام کاربری بیشتر از حد مجاز میباشد.
        /// </summary>
        public static string UsernameMaxLength {
            get {
                return ResourceManager.GetString("UsernameMaxLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to نام کاربری نمیتواند کمتر از 3 کاراکتر باشد.
        /// </summary>
        public static string UsernameMinLength {
            get {
                return ResourceManager.GetString("UsernameMinLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to این فیلد اجباری میباشد.
        /// </summary>
        public static string Validation_Required {
            get {
                return ResourceManager.GetString("Validation_Required", resourceCulture);
            }
        }
    }
}
