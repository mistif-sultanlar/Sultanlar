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

namespace Sultanlar.Class.hepsiburada {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ordersSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class orders : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetOpenOrdersOperationCompleted;
        
        private System.Threading.SendOrPostCallback MarkItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOpenOrders_Cancelled_LastMonthOperationCompleted;
        
        private System.Threading.SendOrPostCallback ChangeSasItemStatusOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public orders() {
            this.Url = global::Sultanlar.Class.Properties.Settings.Default.Sultanlar_Class_hepsiburada_orders;
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
        public event GetOpenOrdersCompletedEventHandler GetOpenOrdersCompleted;
        
        /// <remarks/>
        public event MarkItemCompletedEventHandler MarkItemCompleted;
        
        /// <remarks/>
        public event GetOpenOrders_Cancelled_LastMonthCompletedEventHandler GetOpenOrders_Cancelled_LastMonthCompleted;
        
        /// <remarks/>
        public event ChangeSasItemStatusCompletedEventHandler ChangeSasItemStatusCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetOpenOrders", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SasItem[] GetOpenOrders(string SupplierCode, string UserName, string Password) {
            object[] results = this.Invoke("GetOpenOrders", new object[] {
                        SupplierCode,
                        UserName,
                        Password});
            return ((SasItem[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOpenOrdersAsync(string SupplierCode, string UserName, string Password) {
            this.GetOpenOrdersAsync(SupplierCode, UserName, Password, null);
        }
        
        /// <remarks/>
        public void GetOpenOrdersAsync(string SupplierCode, string UserName, string Password, object userState) {
            if ((this.GetOpenOrdersOperationCompleted == null)) {
                this.GetOpenOrdersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOpenOrdersOperationCompleted);
            }
            this.InvokeAsync("GetOpenOrders", new object[] {
                        SupplierCode,
                        UserName,
                        Password}, this.GetOpenOrdersOperationCompleted, userState);
        }
        
        private void OnGetOpenOrdersOperationCompleted(object arg) {
            if ((this.GetOpenOrdersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOpenOrdersCompleted(this, new GetOpenOrdersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MarkItem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool MarkItem(string Ebeln, string Ebelp, string Etenr, bool Insert, string sapno) {
            object[] results = this.Invoke("MarkItem", new object[] {
                        Ebeln,
                        Ebelp,
                        Etenr,
                        Insert,
                        sapno});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void MarkItemAsync(string Ebeln, string Ebelp, string Etenr, bool Insert, string sapno) {
            this.MarkItemAsync(Ebeln, Ebelp, Etenr, Insert, sapno, null);
        }
        
        /// <remarks/>
        public void MarkItemAsync(string Ebeln, string Ebelp, string Etenr, bool Insert, string sapno, object userState) {
            if ((this.MarkItemOperationCompleted == null)) {
                this.MarkItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMarkItemOperationCompleted);
            }
            this.InvokeAsync("MarkItem", new object[] {
                        Ebeln,
                        Ebelp,
                        Etenr,
                        Insert,
                        sapno}, this.MarkItemOperationCompleted, userState);
        }
        
        private void OnMarkItemOperationCompleted(object arg) {
            if ((this.MarkItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MarkItemCompleted(this, new MarkItemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetOpenOrders_Cancelled_LastMonth", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SasItem[] GetOpenOrders_Cancelled_LastMonth(string SupplierCode, string UserName, string Password) {
            object[] results = this.Invoke("GetOpenOrders_Cancelled_LastMonth", new object[] {
                        SupplierCode,
                        UserName,
                        Password});
            return ((SasItem[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOpenOrders_Cancelled_LastMonthAsync(string SupplierCode, string UserName, string Password) {
            this.GetOpenOrders_Cancelled_LastMonthAsync(SupplierCode, UserName, Password, null);
        }
        
        /// <remarks/>
        public void GetOpenOrders_Cancelled_LastMonthAsync(string SupplierCode, string UserName, string Password, object userState) {
            if ((this.GetOpenOrders_Cancelled_LastMonthOperationCompleted == null)) {
                this.GetOpenOrders_Cancelled_LastMonthOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOpenOrders_Cancelled_LastMonthOperationCompleted);
            }
            this.InvokeAsync("GetOpenOrders_Cancelled_LastMonth", new object[] {
                        SupplierCode,
                        UserName,
                        Password}, this.GetOpenOrders_Cancelled_LastMonthOperationCompleted, userState);
        }
        
        private void OnGetOpenOrders_Cancelled_LastMonthOperationCompleted(object arg) {
            if ((this.GetOpenOrders_Cancelled_LastMonthCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOpenOrders_Cancelled_LastMonthCompleted(this, new GetOpenOrders_Cancelled_LastMonthCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ChangeSasItemStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response ChangeSasItemStatus(string SupplierCode, string UserName, string Password, SasItem[] SasItemsResponse) {
            object[] results = this.Invoke("ChangeSasItemStatus", new object[] {
                        SupplierCode,
                        UserName,
                        Password,
                        SasItemsResponse});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void ChangeSasItemStatusAsync(string SupplierCode, string UserName, string Password, SasItem[] SasItemsResponse) {
            this.ChangeSasItemStatusAsync(SupplierCode, UserName, Password, SasItemsResponse, null);
        }
        
        /// <remarks/>
        public void ChangeSasItemStatusAsync(string SupplierCode, string UserName, string Password, SasItem[] SasItemsResponse, object userState) {
            if ((this.ChangeSasItemStatusOperationCompleted == null)) {
                this.ChangeSasItemStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangeSasItemStatusOperationCompleted);
            }
            this.InvokeAsync("ChangeSasItemStatus", new object[] {
                        SupplierCode,
                        UserName,
                        Password,
                        SasItemsResponse}, this.ChangeSasItemStatusOperationCompleted, userState);
        }
        
        private void OnChangeSasItemStatusOperationCompleted(object arg) {
            if ((this.ChangeSasItemStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ChangeSasItemStatusCompleted(this, new ChangeSasItemStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SasItem {
        
        private SasItemTermin[] terminsField;
        
        private AddressInfo addressdetailsField;
        
        private string sasIDField;
        
        private string sasNoField;
        
        private int sasItemNrField;
        
        private string productNameField;
        
        private string hBSKUField;
        
        private string tedSKUField;
        
        private int quantityField;
        
        private System.DateTime createdDateField;
        
        private System.DateTime deliveryDateField;
        
        private string receiverNameField;
        
        private string packageNoteField;
        
        private string addressField;
        
        /// <remarks/>
        public SasItemTermin[] Termins {
            get {
                return this.terminsField;
            }
            set {
                this.terminsField = value;
            }
        }
        
        /// <remarks/>
        public AddressInfo addressdetails {
            get {
                return this.addressdetailsField;
            }
            set {
                this.addressdetailsField = value;
            }
        }
        
        /// <remarks/>
        public string SasID {
            get {
                return this.sasIDField;
            }
            set {
                this.sasIDField = value;
            }
        }
        
        /// <remarks/>
        public string SasNo {
            get {
                return this.sasNoField;
            }
            set {
                this.sasNoField = value;
            }
        }
        
        /// <remarks/>
        public int SasItemNr {
            get {
                return this.sasItemNrField;
            }
            set {
                this.sasItemNrField = value;
            }
        }
        
        /// <remarks/>
        public string ProductName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
            }
        }
        
        /// <remarks/>
        public string HBSKU {
            get {
                return this.hBSKUField;
            }
            set {
                this.hBSKUField = value;
            }
        }
        
        /// <remarks/>
        public string TedSKU {
            get {
                return this.tedSKUField;
            }
            set {
                this.tedSKUField = value;
            }
        }
        
        /// <remarks/>
        public int Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreatedDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DeliveryDate {
            get {
                return this.deliveryDateField;
            }
            set {
                this.deliveryDateField = value;
            }
        }
        
        /// <remarks/>
        public string ReceiverName {
            get {
                return this.receiverNameField;
            }
            set {
                this.receiverNameField = value;
            }
        }
        
        /// <remarks/>
        public string PackageNote {
            get {
                return this.packageNoteField;
            }
            set {
                this.packageNoteField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SasItemTermin {
        
        private int terminIDField;
        
        private int sasQtyField;
        
        private int waitingQtyField;
        
        private int goodsReceiptQtyField;
        
        private int terminQtyField;
        
        private int terminStatusField;
        
        private System.DateTime deliveryDateField;
        
        /// <remarks/>
        public int TerminID {
            get {
                return this.terminIDField;
            }
            set {
                this.terminIDField = value;
            }
        }
        
        /// <remarks/>
        public int SasQty {
            get {
                return this.sasQtyField;
            }
            set {
                this.sasQtyField = value;
            }
        }
        
        /// <remarks/>
        public int WaitingQty {
            get {
                return this.waitingQtyField;
            }
            set {
                this.waitingQtyField = value;
            }
        }
        
        /// <remarks/>
        public int GoodsReceiptQty {
            get {
                return this.goodsReceiptQtyField;
            }
            set {
                this.goodsReceiptQtyField = value;
            }
        }
        
        /// <remarks/>
        public int TerminQty {
            get {
                return this.terminQtyField;
            }
            set {
                this.terminQtyField = value;
            }
        }
        
        /// <remarks/>
        public int TerminStatus {
            get {
                return this.terminStatusField;
            }
            set {
                this.terminStatusField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DeliveryDate {
            get {
                return this.deliveryDateField;
            }
            set {
                this.deliveryDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Response {
        
        private bool successField;
        
        private object[] errorsField;
        
        /// <remarks/>
        public bool Success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        public object[] Errors {
            get {
                return this.errorsField;
            }
            set {
                this.errorsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AddressInfo {
        
        private string isimField;
        
        private string adres1Field;
        
        private string adres2Field;
        
        private string adres3Field;
        
        private string cityField;
        
        private string districtField;
        
        private string townField;
        
        private string countryField;
        
        private string telgonderenField;
        
        private string telteslimalanField;
        
        private string isimgonderenField;
        
        /// <remarks/>
        public string isim {
            get {
                return this.isimField;
            }
            set {
                this.isimField = value;
            }
        }
        
        /// <remarks/>
        public string adres1 {
            get {
                return this.adres1Field;
            }
            set {
                this.adres1Field = value;
            }
        }
        
        /// <remarks/>
        public string adres2 {
            get {
                return this.adres2Field;
            }
            set {
                this.adres2Field = value;
            }
        }
        
        /// <remarks/>
        public string adres3 {
            get {
                return this.adres3Field;
            }
            set {
                this.adres3Field = value;
            }
        }
        
        /// <remarks/>
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string district {
            get {
                return this.districtField;
            }
            set {
                this.districtField = value;
            }
        }
        
        /// <remarks/>
        public string town {
            get {
                return this.townField;
            }
            set {
                this.townField = value;
            }
        }
        
        /// <remarks/>
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public string telgonderen {
            get {
                return this.telgonderenField;
            }
            set {
                this.telgonderenField = value;
            }
        }
        
        /// <remarks/>
        public string telteslimalan {
            get {
                return this.telteslimalanField;
            }
            set {
                this.telteslimalanField = value;
            }
        }
        
        /// <remarks/>
        public string isimgonderen {
            get {
                return this.isimgonderenField;
            }
            set {
                this.isimgonderenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetOpenOrdersCompletedEventHandler(object sender, GetOpenOrdersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOpenOrdersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOpenOrdersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SasItem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SasItem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void MarkItemCompletedEventHandler(object sender, MarkItemCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MarkItemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MarkItemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetOpenOrders_Cancelled_LastMonthCompletedEventHandler(object sender, GetOpenOrders_Cancelled_LastMonthCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOpenOrders_Cancelled_LastMonthCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOpenOrders_Cancelled_LastMonthCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SasItem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SasItem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ChangeSasItemStatusCompletedEventHandler(object sender, ChangeSasItemStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ChangeSasItemStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ChangeSasItemStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591