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

namespace Sultanlar.WindowsServiceIslemler.getdelinvC {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ZwebGetDelInvBinding", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Zwebs003d[]))]
    public partial class ZwebGetDelInvService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ZwebGetDelInvOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)base.GetWebRequest(uri);
            request.KeepAlive = false;
            request.ProtocolVersion = System.Net.HttpVersion.Version10;
            return request;
        }
        
        /// <remarks/>
        public ZwebGetDelInvService() {
            this.Url = global::Sultanlar.WindowsServiceIslemler.Properties.Settings.Default.Sultanlar_WindowsServiceIslemler_getdelinvC_ZwebGetDelInvService;
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
        public event ZwebGetDelInvCompletedEventHandler ZwebGetDelInvCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.sap.com/ZwebGetDelInv", RequestNamespace="urn:sap-com:document:sap:soap:functions:mc-style", ResponseElementName="ZwebGetDelInvResult", ResponseNamespace="urn:sap-com:document:sap:soap:functions:mc-style", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("EtDelInv", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zwebs003d[] ZwebGetDelInv([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IvBegda, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IvEndda) {
            object[] results = this.Invoke("ZwebGetDelInv", new object[] {
                        IvBegda,
                        IvEndda});
            return ((Zwebs003d[])(results[0]));
        }
        
        /// <remarks/>
        public void ZwebGetDelInvAsync(string IvBegda, string IvEndda) {
            this.ZwebGetDelInvAsync(IvBegda, IvEndda, null);
        }
        
        /// <remarks/>
        public void ZwebGetDelInvAsync(string IvBegda, string IvEndda, object userState) {
            if ((this.ZwebGetDelInvOperationCompleted == null)) {
                this.ZwebGetDelInvOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZwebGetDelInvOperationCompleted);
            }
            this.InvokeAsync("ZwebGetDelInv", new object[] {
                        IvBegda,
                        IvEndda}, this.ZwebGetDelInvOperationCompleted, userState);
        }
        
        private void OnZwebGetDelInvOperationCompleted(object arg) {
            if ((this.ZwebGetDelInvCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ZwebGetDelInvCompleted(this, new ZwebGetDelInvCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Zwebs003d {
        
        private string vbelnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Vbeln {
            get {
                return this.vbelnField;
            }
            set {
                this.vbelnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ZwebGetDelInvCompletedEventHandler(object sender, ZwebGetDelInvCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ZwebGetDelInvCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ZwebGetDelInvCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Zwebs003d[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Zwebs003d[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591