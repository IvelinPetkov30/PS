﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserLogin {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
    internal sealed partial class DbConnect : global::System.Configuration.ApplicationSettingsBase {
        
        private static DbConnect defaultInstance = ((DbConnect)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DbConnect())));
        
        public static DbConnect Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-EE714IN;Initial Catalog=StudentInfoDatabase;Integrated Securi" +
            "ty=True")]
        public string DbConnect {
            get {
                return ((string)(this["DbConnect"]));
            }
        }
    }
}
