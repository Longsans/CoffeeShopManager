﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-14KFC4R\\SQLEXPRESS; Initial Catalog=NewDB; User id=sa;Passwor" +
            "d=123456;")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=localhost; Initial Catalog=NewDB; User id=sa;Password=onetwothree;Mul" +
            "tipleActiveResultSets=True;")]
        public string ConnectionStringLong {
            get {
                return ((string)(this["ConnectionStringLong"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HDM-PC-DC54PLF;Initial Catalog=NewDB;Integrated Security=True;Multipl" +
            "eActiveResultSets=True;")]
        public string ConnectionStringHao {
            get {
                return ((string)(this["ConnectionStringHao"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-14KFC4R\\SQLEXPRESS; Initial Catalog=NewDB; User id=sa;Passwor" +
            "d=123456;MultipleActiveResultSets=True;")]
        public string ConnectionStringCuong {
            get {
                return ((string)(this["ConnectionStringCuong"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=localhost; Initial Catalog=NewDB; User id=sa;Password=onetwothree;Mul" +
            "tipleActiveResultSets=True;")]
        public string ConnectionStringAppConfig {
            get {
                return ((string)(this["ConnectionStringAppConfig"]));
            }
        }
    }
}
