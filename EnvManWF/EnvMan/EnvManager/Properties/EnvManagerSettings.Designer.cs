﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFC.EnvMan.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class EnvManagerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static EnvManagerSettings defaultInstance = ((EnvManagerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new EnvManagerSettings())));
        
        public static EnvManagerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("197")]
        public int SpliterPosition {
            get {
                return ((int)(this["SpliterPosition"]));
            }
            set {
                this["SpliterPosition"] = value;
            }
        }
    }
}
