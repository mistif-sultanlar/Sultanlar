﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sultanlar.UI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://exper2.tibet.com.tr:8000/sap/bc/soap/rfc")]
        public string Sultanlar_SAPsendorder_ZwebSendSalesOrderService {
            get {
                return ((string)(this["Sultanlar_SAPsendorder_ZwebSendSalesOrderService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://stella.tibet.com.tr:8000/sap/bc/soap/rfc")]
        public string Sultanlar_SAPsendorderC_ZwebSendSalesOrderService {
            get {
                return ((string)(this["Sultanlar_SAPsendorderC_ZwebSendSalesOrderService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://stella.tibet.com.tr:8000/sap/bc/soap/rfc")]
        public string Sultanlar_SAPchangeorderC_ZWEB_CHANGE_SALES_ORDERService {
            get {
                return ((string)(this["Sultanlar_SAPchangeorderC_ZWEB_CHANGE_SALES_ORDERService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://stella.tibet.com.tr:8000/sap/bc/soap/rfc")]
        public string Sultanlar_getsalesreportC_ZwebSelectSalesReportService {
            get {
                return ((string)(this["Sultanlar_getsalesreportC_ZwebSelectSalesReportService"]));
            }
        }
    }
}