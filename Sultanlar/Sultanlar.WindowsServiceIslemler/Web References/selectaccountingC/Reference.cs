﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace Sultanlar.WindowsServiceIslemler.selectaccountingC {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ZwebSelectAccountingBinding", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Zwebs020[]))]
    public partial class ZwebSelectAccountingService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ZwebSelectAccountingOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)base.GetWebRequest(uri);
            request.KeepAlive = false;
            request.ProtocolVersion = System.Net.HttpVersion.Version10;
            return request;
        }
        
        /// <remarks/>
        public ZwebSelectAccountingService() {
            this.Url = global::Sultanlar.WindowsServiceIslemler.Properties.Settings.Default.Sultanlar_WindowsServiceIslemler_selectaccountingC_ZwebSelectAccountingService;
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
        public event ZwebSelectAccountingCompletedEventHandler ZwebSelectAccountingCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.sap.com/ZwebSelectAccounting", RequestNamespace="urn:sap-com:document:sap:soap:functions:mc-style", ResponseElementName="ZwebSelectAccountingResult", ResponseNamespace="urn:sap-com:document:sap:soap:functions:mc-style", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("EtAccountHead", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zwebs020[] ZwebSelectAccounting([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IBegda, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IEndda) {
            object[] results = this.Invoke("ZwebSelectAccounting", new object[] {
                        IBegda,
                        IEndda});
            return ((Zwebs020[])(results[0]));
        }
        
        /// <remarks/>
        public void ZwebSelectAccountingAsync(string IBegda, string IEndda) {
            this.ZwebSelectAccountingAsync(IBegda, IEndda, null);
        }
        
        /// <remarks/>
        public void ZwebSelectAccountingAsync(string IBegda, string IEndda, object userState) {
            if ((this.ZwebSelectAccountingOperationCompleted == null)) {
                this.ZwebSelectAccountingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZwebSelectAccountingOperationCompleted);
            }
            this.InvokeAsync("ZwebSelectAccounting", new object[] {
                        IBegda,
                        IEndda}, this.ZwebSelectAccountingOperationCompleted, userState);
        }
        
        private void OnZwebSelectAccountingOperationCompleted(object arg) {
            if ((this.ZwebSelectAccountingCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ZwebSelectAccountingCompleted(this, new ZwebSelectAccountingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zwebs020 {
        
        private string bukrsField;
        
        private string belnrField;
        
        private string gjahrField;
        
        private string blartField;
        
        private string bldatField;
        
        private string budatField;
        
        private string monatField;
        
        private string cpudtField;
        
        private string cputmField;
        
        private string aedatField;
        
        private string upddtField;
        
        private string wwertField;
        
        private string usnamField;
        
        private string xblnrField;
        
        private string stblgField;
        
        private string stjahField;
        
        private string bktxtField;
        
        private string waersField;
        
        private string awtypField;
        
        private string awkeyField;
        
        private string zzikincibelgenoField;
        
        private string zzislemkdField;
        
        private string zzreferansField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Bukrs {
            get {
                return this.bukrsField;
            }
            set {
                this.bukrsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Belnr {
            get {
                return this.belnrField;
            }
            set {
                this.belnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Gjahr {
            get {
                return this.gjahrField;
            }
            set {
                this.gjahrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Blart {
            get {
                return this.blartField;
            }
            set {
                this.blartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Bldat {
            get {
                return this.bldatField;
            }
            set {
                this.bldatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Budat {
            get {
                return this.budatField;
            }
            set {
                this.budatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Monat {
            get {
                return this.monatField;
            }
            set {
                this.monatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Cpudt {
            get {
                return this.cpudtField;
            }
            set {
                this.cpudtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Cputm {
            get {
                return this.cputmField;
            }
            set {
                this.cputmField = value;
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
        public string Upddt {
            get {
                return this.upddtField;
            }
            set {
                this.upddtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Wwert {
            get {
                return this.wwertField;
            }
            set {
                this.wwertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Usnam {
            get {
                return this.usnamField;
            }
            set {
                this.usnamField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Xblnr {
            get {
                return this.xblnrField;
            }
            set {
                this.xblnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Stblg {
            get {
                return this.stblgField;
            }
            set {
                this.stblgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Stjah {
            get {
                return this.stjahField;
            }
            set {
                this.stjahField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Bktxt {
            get {
                return this.bktxtField;
            }
            set {
                this.bktxtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Waers {
            get {
                return this.waersField;
            }
            set {
                this.waersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Awtyp {
            get {
                return this.awtypField;
            }
            set {
                this.awtypField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Awkey {
            get {
                return this.awkeyField;
            }
            set {
                this.awkeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zzikincibelgeno {
            get {
                return this.zzikincibelgenoField;
            }
            set {
                this.zzikincibelgenoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zzislemkd {
            get {
                return this.zzislemkdField;
            }
            set {
                this.zzislemkdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zzreferans {
            get {
                return this.zzreferansField;
            }
            set {
                this.zzreferansField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ZwebSelectAccountingCompletedEventHandler(object sender, ZwebSelectAccountingCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ZwebSelectAccountingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ZwebSelectAccountingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Zwebs020[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Zwebs020[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591