﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace innovoCAD.Bentley.CONNECT.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("innovoCAD.Bentley.CONNECT.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Item to Key-ins.
        /// </summary>
        internal static string AddItem {
            get {
                return ResourceManager.GetString("AddItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Item.
        /// </summary>
        internal static string AddItemMessageTitle {
            get {
                return ResourceManager.GetString("AddItemMessageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command Table Already Implemented. Only one command table per project..
        /// </summary>
        internal static string CommandTableError {
            get {
                return ResourceManager.GetString("CommandTableError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to innovoCAD - MicroStation CONNECT.
        /// </summary>
        internal static string ErrorTitle {
            get {
                return ResourceManager.GetString("ErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MicroStation CONNECT SDK Not Installed. Please install the MicroStation CONNECT SDK and restart Visual Studios. Please visit www.Bentley.com for MicroStation CONNECT and other Bentley related product. Bentley Systems, Inc. is not affiliated with Visual Studio Tools for MicroStation V8i..
        /// </summary>
        internal static string MicroStationCONNECTSDKNotFoundError {
            get {
                return ResourceManager.GetString("MicroStationCONNECTSDKNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one Scan Criteria Extension is necessary per project..
        /// </summary>
        internal static string ScanCriteriaMsg {
            get {
                return ResourceManager.GetString("ScanCriteriaMsg", resourceCulture);
            }
        }
    }
}