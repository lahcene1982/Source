﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orias.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Driver={SQL Server};server=SERVBDD;trusted_connection=Yes;app=Microsoft® Visual S" +
            "tudio® 2013;wsid=CIP-D0014;database=App_Db")]
        public string App_Db_DevConnectionString {
            get {
                return ((string)(this["App_Db_DevConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=SQLNCLI11;Data Source=gheh9dnl1p.database.windows.net;Persist Security I" +
            "nfo=True;Password=A56s#f6qs!d48ezd;User ID=JazzCipresLogin@gheh9dnl1p;Initial Ca" +
            "talog=JazzCipresDb")]
        public string JazzProd_ConnectionString {
            get {
                return ((string)(this["JazzProd_ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=SQLNCLI11;Data Source=gheh9dnl1p.database.windows.net;Persist Security I" +
            "nfo=True;Password=A56s#f6qs!d48ezd;User ID=JazzCipresLogin@gheh9dnl1p;Initial Ca" +
            "talog=JazzCipresDbPreProd")]
        public string JazzPrePro_ConnectionString {
            get {
                return ((string)(this["JazzPrePro_ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=SQLNCLI11;Data Source=gheh9dnl1p.database.windows.net;Persist Security I" +
            "nfo=True;Password=A56s#f6qs!d48ezd;User ID=JazzCipresLogin@gheh9dnl1p;Initial Ca" +
            "talog=JazzCipresDbRecette")]
        public string JazzRecette_ConnectionString {
            get {
                return ((string)(this["JazzRecette_ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DJO3J4VD2W59OF8NCNLD")]
        public string OriasUserAccount {
            get {
                return ((string)(this["OriasUserAccount"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=SQLNCLI11;Data Source=gheh9dnl1p.database.windows.net;Persist Security I" +
            "nfo=True;Password=A56s#f6qs!d48ezd;User ID=JazzCipresLogin@gheh9dnl1p;Initial Ca" +
            "talog=JazzKlesiaDb")]
        public string JazzKlesia_ConnectionString {
            get {
                return ((string)(this["JazzKlesia_ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://ws.orias.fr/service")]
        public string Orias_fr_orias_ws_intermediarySearchService {
            get {
                return ((string)(this["Orias_fr_orias_ws_intermediarySearchService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConsoleExecute {
            get {
                return ((bool)(this["ConsoleExecute"]));
            }
        }
    }
}
