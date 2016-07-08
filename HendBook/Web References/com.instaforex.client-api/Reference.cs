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

namespace HendBook.com.instaforex.client_api {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ICalendarService", Namespace="http://client-api.instaforex.com/Calendar/")]
    public partial class BasicHttpBinding_ICalendarService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCalendarOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCalendarByDateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpBinding_ICalendarService() {
            this.Url = "http://client-api.instaforex.com/soapservices/Calendar.svc";
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
        public event GetCalendarCompletedEventHandler GetCalendarCompleted;
        
        /// <remarks/>
        public event GetCalendarByDateCompletedEventHandler GetCalendarByDateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://client-api.instaforex.com/Calendar/ICalendarService/GetCalendar", RequestNamespace="http://client-api.instaforex.com/Calendar/", ResponseNamespace="http://client-api.instaforex.com/Calendar/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Event[] GetCalendar(Lang lang, [System.Xml.Serialization.XmlIgnoreAttribute()] bool langSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Account account) {
            object[] results = this.Invoke("GetCalendar", new object[] {
                        lang,
                        langSpecified,
                        account});
            return ((Event[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCalendarAsync(Lang lang, bool langSpecified, Account account) {
            this.GetCalendarAsync(lang, langSpecified, account, null);
        }
        
        /// <remarks/>
        public void GetCalendarAsync(Lang lang, bool langSpecified, Account account, object userState) {
            if ((this.GetCalendarOperationCompleted == null)) {
                this.GetCalendarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCalendarOperationCompleted);
            }
            this.InvokeAsync("GetCalendar", new object[] {
                        lang,
                        langSpecified,
                        account}, this.GetCalendarOperationCompleted, userState);
        }
        
        private void OnGetCalendarOperationCompleted(object arg) {
            if ((this.GetCalendarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCalendarCompleted(this, new GetCalendarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://client-api.instaforex.com/Calendar/ICalendarService/GetCalendarByDate", RequestNamespace="http://client-api.instaforex.com/Calendar/", ResponseNamespace="http://client-api.instaforex.com/Calendar/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Event[] GetCalendarByDate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] DataRequest request) {
            object[] results = this.Invoke("GetCalendarByDate", new object[] {
                        request});
            return ((Event[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCalendarByDateAsync(DataRequest request) {
            this.GetCalendarByDateAsync(request, null);
        }
        
        /// <remarks/>
        public void GetCalendarByDateAsync(DataRequest request, object userState) {
            if ((this.GetCalendarByDateOperationCompleted == null)) {
                this.GetCalendarByDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCalendarByDateOperationCompleted);
            }
            this.InvokeAsync("GetCalendarByDate", new object[] {
                        request}, this.GetCalendarByDateOperationCompleted, userState);
        }
        
        private void OnGetCalendarByDateOperationCompleted(object arg) {
            if ((this.GetCalendarByDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCalendarByDateCompleted(this, new GetCalendarByDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ICalendarService1", Namespace="http://client-api.instaforex.com/Calendar/")]
    public partial class BasicHttpBinding_ICalendarService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCalendarOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCalendarByDateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpBinding_ICalendarService1() {
            this.Url = "https://client-api.instaforex.com/soapservices/Calendar.svc/secure";
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
        public event GetCalendarCompletedEventHandler GetCalendarCompleted;
        
        /// <remarks/>
        public event GetCalendarByDateCompletedEventHandler GetCalendarByDateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://client-api.instaforex.com/Calendar/ICalendarService/GetCalendar", RequestNamespace="http://client-api.instaforex.com/Calendar/", ResponseNamespace="http://client-api.instaforex.com/Calendar/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Event[] GetCalendar(Lang lang, [System.Xml.Serialization.XmlIgnoreAttribute()] bool langSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Account account) {
            object[] results = this.Invoke("GetCalendar", new object[] {
                        lang,
                        langSpecified,
                        account});
            return ((Event[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCalendarAsync(Lang lang, bool langSpecified, Account account) {
            this.GetCalendarAsync(lang, langSpecified, account, null);
        }
        
        /// <remarks/>
        public void GetCalendarAsync(Lang lang, bool langSpecified, Account account, object userState) {
            if ((this.GetCalendarOperationCompleted == null)) {
                this.GetCalendarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCalendarOperationCompleted);
            }
            this.InvokeAsync("GetCalendar", new object[] {
                        lang,
                        langSpecified,
                        account}, this.GetCalendarOperationCompleted, userState);
        }
        
        private void OnGetCalendarOperationCompleted(object arg) {
            if ((this.GetCalendarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCalendarCompleted(this, new GetCalendarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://client-api.instaforex.com/Calendar/ICalendarService/GetCalendarByDate", RequestNamespace="http://client-api.instaforex.com/Calendar/", ResponseNamespace="http://client-api.instaforex.com/Calendar/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Event[] GetCalendarByDate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] DataRequest request) {
            object[] results = this.Invoke("GetCalendarByDate", new object[] {
                        request});
            return ((Event[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCalendarByDateAsync(DataRequest request) {
            this.GetCalendarByDateAsync(request, null);
        }
        
        /// <remarks/>
        public void GetCalendarByDateAsync(DataRequest request, object userState) {
            if ((this.GetCalendarByDateOperationCompleted == null)) {
                this.GetCalendarByDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCalendarByDateOperationCompleted);
            }
            this.InvokeAsync("GetCalendarByDate", new object[] {
                        request}, this.GetCalendarByDateOperationCompleted, userState);
        }
        
        private void OnGetCalendarByDateOperationCompleted(object arg) {
            if ((this.GetCalendarByDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCalendarByDateCompleted(this, new GetCalendarByDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://client-api.instaforex.com/Calendar/")]
    public enum Lang {
        
        /// <remarks/>
        En,
        
        /// <remarks/>
        Ru,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://client-api.instaforex.com/Calendar/")]
    public partial class Account {
        
        private int loginField;
        
        private bool loginFieldSpecified;
        
        private string passwordField;
        
        /// <remarks/>
        public int Login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LoginSpecified {
            get {
                return this.loginFieldSpecified;
            }
            set {
                this.loginFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfApi.Calendar")]
    public partial class DataRequest {
        
        private string[] countriesField;
        
        private long fromField;
        
        private bool fromFieldSpecified;
        
        private System.Nullable<int> importanceField;
        
        private bool importanceFieldSpecified;
        
        private Lang langField;
        
        private bool langFieldSpecified;
        
        private long toField;
        
        private bool toFieldSpecified;
        
        private string tokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Countries {
            get {
                return this.countriesField;
            }
            set {
                this.countriesField = value;
            }
        }
        
        /// <remarks/>
        public long From {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FromSpecified {
            get {
                return this.fromFieldSpecified;
            }
            set {
                this.fromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Importance {
            get {
                return this.importanceField;
            }
            set {
                this.importanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImportanceSpecified {
            get {
                return this.importanceFieldSpecified;
            }
            set {
                this.importanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Lang Lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LangSpecified {
            get {
                return this.langFieldSpecified;
            }
            set {
                this.langFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public long To {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ToSpecified {
            get {
                return this.toFieldSpecified;
            }
            set {
                this.toFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://client-api.instaforex.com/Calendar/")]
    public partial class Event {
        
        private string actualField;
        
        private string countryField;
        
        private string descriptionField;
        
        private string forecastField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private Importance importanceField;
        
        private bool importanceFieldSpecified;
        
        private string nameField;
        
        private string periodField;
        
        private string previousField;
        
        private int releaseTimestampField;
        
        private bool releaseTimestampFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Actual {
            get {
                return this.actualField;
            }
            set {
                this.actualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Forecast {
            get {
                return this.forecastField;
            }
            set {
                this.forecastField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Importance Importance {
            get {
                return this.importanceField;
            }
            set {
                this.importanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImportanceSpecified {
            get {
                return this.importanceFieldSpecified;
            }
            set {
                this.importanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Previous {
            get {
                return this.previousField;
            }
            set {
                this.previousField = value;
            }
        }
        
        /// <remarks/>
        public int ReleaseTimestamp {
            get {
                return this.releaseTimestampField;
            }
            set {
                this.releaseTimestampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReleaseTimestampSpecified {
            get {
                return this.releaseTimestampFieldSpecified;
            }
            set {
                this.releaseTimestampFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://client-api.instaforex.com/Calendar/")]
    public enum Importance {
        
        /// <remarks/>
        Low,
        
        /// <remarks/>
        Medium,
        
        /// <remarks/>
        High,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetCalendarCompletedEventHandler(object sender, GetCalendarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCalendarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCalendarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Event[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Event[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetCalendarByDateCompletedEventHandler(object sender, GetCalendarByDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCalendarByDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCalendarByDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Event[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Event[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591