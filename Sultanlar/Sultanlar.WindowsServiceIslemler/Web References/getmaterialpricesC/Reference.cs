﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Sultanlar.WindowsServiceIslemler.getmaterialpricesC {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ZwebGetMaterialPricesBinding", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Zwebt004[]))]
    public partial class ZwebGetMaterialPricesService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ZwebGetMaterialPricesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ZwebGetMaterialPricesService() {
            this.Url = global::Sultanlar.WindowsServiceIslemler.Properties.Settings.Default.Sultanlar_WindowsServiceIslemler_selectsalesvbfaC_ZwebSelectSalesVbfaService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ZwebGetMaterialPricesCompletedEventHandler ZwebGetMaterialPricesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.sap.com/ZwebGetMaterialPrices", RequestNamespace="urn:sap-com:document:sap:soap:functions:mc-style", ResponseElementName="ZwebGetMaterialPricesResult", ResponseNamespace="urn:sap-com:document:sap:soap:functions:mc-style", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("EtMaterialPrices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zwebt004[] ZwebGetMaterialPrices() {
            object[] results = this.Invoke("ZwebGetMaterialPrices", new object[0]);
            return ((Zwebt004[])(results[0]));
        }
        
        /// <remarks/>
        public void ZwebGetMaterialPricesAsync() {
            this.ZwebGetMaterialPricesAsync(null);
        }
        
        /// <remarks/>
        public void ZwebGetMaterialPricesAsync(object userState) {
            if ((this.ZwebGetMaterialPricesOperationCompleted == null)) {
                this.ZwebGetMaterialPricesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZwebGetMaterialPricesOperationCompleted);
            }
            this.InvokeAsync("ZwebGetMaterialPrices", new object[0], this.ZwebGetMaterialPricesOperationCompleted, userState);
        }
        
        private void OnZwebGetMaterialPricesOperationCompleted(object arg) {
            if ((this.ZwebGetMaterialPricesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ZwebGetMaterialPricesCompleted(this, new ZwebGetMaterialPricesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zwebt004 {
        
        private string mandtField;
        
        private string pltypField;
        
        private string kdgrpField;
        
        private string kunnrField;
        
        private string matnrField;
        
        private string kschlField;
        
        private decimal kbetrField;
        
        private bool kbetrFieldSpecified;
        
        private string konwaField;
        
        private decimal kpeinField;
        
        private bool kpeinFieldSpecified;
        
        private string kmeinField;
        
        private string ztermField;
        
        private string aedatField;
        
        private string aezetField;
        
        private string valdtField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Mandt {
            get {
                return this.mandtField;
            }
            set {
                this.mandtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Pltyp {
            get {
                return this.pltypField;
            }
            set {
                this.pltypField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kdgrp {
            get {
                return this.kdgrpField;
            }
            set {
                this.kdgrpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kunnr {
            get {
                return this.kunnrField;
            }
            set {
                this.kunnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Matnr {
            get {
                return this.matnrField;
            }
            set {
                this.matnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kschl {
            get {
                return this.kschlField;
            }
            set {
                this.kschlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Kbetr {
            get {
                return this.kbetrField;
            }
            set {
                this.kbetrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KbetrSpecified {
            get {
                return this.kbetrFieldSpecified;
            }
            set {
                this.kbetrFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Konwa {
            get {
                return this.konwaField;
            }
            set {
                this.konwaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Kpein {
            get {
                return this.kpeinField;
            }
            set {
                this.kpeinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KpeinSpecified {
            get {
                return this.kpeinFieldSpecified;
            }
            set {
                this.kpeinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kmein {
            get {
                return this.kmeinField;
            }
            set {
                this.kmeinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zterm {
            get {
                return this.ztermField;
            }
            set {
                this.ztermField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Aedat {
            get {
                return this.aedatField;
            }
            set {
                this.aedatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Aezet {
            get {
                return this.aezetField;
            }
            set {
                this.aezetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Valdt {
            get {
                return this.valdtField;
            }
            set {
                this.valdtField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void ZwebGetMaterialPricesCompletedEventHandler(object sender, ZwebGetMaterialPricesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ZwebGetMaterialPricesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ZwebGetMaterialPricesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Zwebt004[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Zwebt004[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591