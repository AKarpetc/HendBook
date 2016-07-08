﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://client-api.instaforex.com/Calendar/", ClrNamespace="clientapi.instaforex.com.Calendar")]

// 
// This code was auto-generated by SlSvcUtil, version 5.0.61118.0
// 
namespace clientapi.instaforex.com.Calendar
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lang", Namespace="http://client-api.instaforex.com/Calendar/")]
    public enum Lang : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        En = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ru = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://client-api.instaforex.com/Calendar/")]
    public partial class Account : object
    {
        
        private int LoginField;
        
        private string PasswordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Login
        {
            get
            {
                return this.LoginField;
            }
            set
            {
                this.LoginField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://client-api.instaforex.com/Calendar/")]
    public partial class Event : object
    {
        
        private string ActualField;
        
        private string CountryField;
        
        private string DescriptionField;
        
        private string ForecastField;
        
        private int IdField;
        
        private clientapi.instaforex.com.Calendar.Importance ImportanceField;
        
        private string NameField;
        
        private string PeriodField;
        
        private string PreviousField;
        
        private int ReleaseTimestampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Actual
        {
            get
            {
                return this.ActualField;
            }
            set
            {
                this.ActualField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country
        {
            get
            {
                return this.CountryField;
            }
            set
            {
                this.CountryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Forecast
        {
            get
            {
                return this.ForecastField;
            }
            set
            {
                this.ForecastField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public clientapi.instaforex.com.Calendar.Importance Importance
        {
            get
            {
                return this.ImportanceField;
            }
            set
            {
                this.ImportanceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Period
        {
            get
            {
                return this.PeriodField;
            }
            set
            {
                this.PeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Previous
        {
            get
            {
                return this.PreviousField;
            }
            set
            {
                this.PreviousField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReleaseTimestamp
        {
            get
            {
                return this.ReleaseTimestampField;
            }
            set
            {
                this.ReleaseTimestampField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Importance", Namespace="http://client-api.instaforex.com/Calendar/")]
    public enum Importance : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Low = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Medium = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        High = 2,
    }
}
namespace WcfApi.Calendar
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfApi.Calendar")]
    public partial class DataRequest : object
    {
        
        private string[] CountriesField;
        
        private long FromField;
        
        private System.Nullable<int> ImportanceField;
        
        private clientapi.instaforex.com.Calendar.Lang LangField;
        
        private long ToField;
        
        private string TokenField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Countries
        {
            get
            {
                return this.CountriesField;
            }
            set
            {
                this.CountriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long From
        {
            get
            {
                return this.FromField;
            }
            set
            {
                this.FromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Importance
        {
            get
            {
                return this.ImportanceField;
            }
            set
            {
                this.ImportanceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public clientapi.instaforex.com.Calendar.Lang Lang
        {
            get
            {
                return this.LangField;
            }
            set
            {
                this.LangField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long To
        {
            get
            {
                return this.ToField;
            }
            set
            {
                this.ToField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token
        {
            get
            {
                return this.TokenField;
            }
            set
            {
                this.TokenField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://client-api.instaforex.com/Calendar/", ConfigurationName="ICalendarService")]
public interface ICalendarService
{
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://client-api.instaforex.com/Calendar/ICalendarService/GetCalendar", ReplyAction="http://client-api.instaforex.com/Calendar/ICalendarService/GetCalendarResponse")]
    System.IAsyncResult BeginGetCalendar(clientapi.instaforex.com.Calendar.Lang lang, clientapi.instaforex.com.Calendar.Account account, System.AsyncCallback callback, object asyncState);
    
    clientapi.instaforex.com.Calendar.Event[] EndGetCalendar(System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://client-api.instaforex.com/Calendar/ICalendarService/GetCalendarByDate", ReplyAction="http://client-api.instaforex.com/Calendar/ICalendarService/GetCalendarByDateRespo" +
        "nse")]
    System.IAsyncResult BeginGetCalendarByDate(WcfApi.Calendar.DataRequest request, System.AsyncCallback callback, object asyncState);
    
    clientapi.instaforex.com.Calendar.Event[] EndGetCalendarByDate(System.IAsyncResult result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalendarServiceChannel : ICalendarService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GetCalendarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public GetCalendarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public clientapi.instaforex.com.Calendar.Event[] Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((clientapi.instaforex.com.Calendar.Event[])(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GetCalendarByDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public GetCalendarByDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public clientapi.instaforex.com.Calendar.Event[] Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((clientapi.instaforex.com.Calendar.Event[])(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalendarServiceClient : System.ServiceModel.ClientBase<ICalendarService>, ICalendarService
{
    
    private BeginOperationDelegate onBeginGetCalendarDelegate;
    
    private EndOperationDelegate onEndGetCalendarDelegate;
    
    private System.Threading.SendOrPostCallback onGetCalendarCompletedDelegate;
    
    private BeginOperationDelegate onBeginGetCalendarByDateDelegate;
    
    private EndOperationDelegate onEndGetCalendarByDateDelegate;
    
    private System.Threading.SendOrPostCallback onGetCalendarByDateCompletedDelegate;
    
    private BeginOperationDelegate onBeginOpenDelegate;
    
    private EndOperationDelegate onEndOpenDelegate;
    
    private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
    
    private BeginOperationDelegate onBeginCloseDelegate;
    
    private EndOperationDelegate onEndCloseDelegate;
    
    private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
    
    public CalendarServiceClient()
    {
    }
    
    public CalendarServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalendarServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalendarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalendarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Net.CookieContainer CookieContainer
    {
        get
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                return httpCookieContainerManager.CookieContainer;
            }
            else
            {
                return null;
            }
        }
        set
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                httpCookieContainerManager.CookieContainer = value;
            }
            else
            {
                throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                        "ookieContainerBindingElement.");
            }
        }
    }
    
    public event System.EventHandler<GetCalendarCompletedEventArgs> GetCalendarCompleted;
    
    public event System.EventHandler<GetCalendarByDateCompletedEventArgs> GetCalendarByDateCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult ICalendarService.BeginGetCalendar(clientapi.instaforex.com.Calendar.Lang lang, clientapi.instaforex.com.Calendar.Account account, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginGetCalendar(lang, account, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    clientapi.instaforex.com.Calendar.Event[] ICalendarService.EndGetCalendar(System.IAsyncResult result)
    {
        return base.Channel.EndGetCalendar(result);
    }
    
    private System.IAsyncResult OnBeginGetCalendar(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        clientapi.instaforex.com.Calendar.Lang lang = ((clientapi.instaforex.com.Calendar.Lang)(inValues[0]));
        clientapi.instaforex.com.Calendar.Account account = ((clientapi.instaforex.com.Calendar.Account)(inValues[1]));
        return ((ICalendarService)(this)).BeginGetCalendar(lang, account, callback, asyncState);
    }
    
    private object[] OnEndGetCalendar(System.IAsyncResult result)
    {
        clientapi.instaforex.com.Calendar.Event[] retVal = ((ICalendarService)(this)).EndGetCalendar(result);
        return new object[] {
                retVal};
    }
    
    private void OnGetCalendarCompleted(object state)
    {
        if ((this.GetCalendarCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.GetCalendarCompleted(this, new GetCalendarCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void GetCalendarAsync(clientapi.instaforex.com.Calendar.Lang lang, clientapi.instaforex.com.Calendar.Account account)
    {
        this.GetCalendarAsync(lang, account, null);
    }
    
    public void GetCalendarAsync(clientapi.instaforex.com.Calendar.Lang lang, clientapi.instaforex.com.Calendar.Account account, object userState)
    {
        if ((this.onBeginGetCalendarDelegate == null))
        {
            this.onBeginGetCalendarDelegate = new BeginOperationDelegate(this.OnBeginGetCalendar);
        }
        if ((this.onEndGetCalendarDelegate == null))
        {
            this.onEndGetCalendarDelegate = new EndOperationDelegate(this.OnEndGetCalendar);
        }
        if ((this.onGetCalendarCompletedDelegate == null))
        {
            this.onGetCalendarCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCalendarCompleted);
        }
        base.InvokeAsync(this.onBeginGetCalendarDelegate, new object[] {
                    lang,
                    account}, this.onEndGetCalendarDelegate, this.onGetCalendarCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult ICalendarService.BeginGetCalendarByDate(WcfApi.Calendar.DataRequest request, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginGetCalendarByDate(request, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    clientapi.instaforex.com.Calendar.Event[] ICalendarService.EndGetCalendarByDate(System.IAsyncResult result)
    {
        return base.Channel.EndGetCalendarByDate(result);
    }
    
    private System.IAsyncResult OnBeginGetCalendarByDate(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        WcfApi.Calendar.DataRequest request = ((WcfApi.Calendar.DataRequest)(inValues[0]));
        return ((ICalendarService)(this)).BeginGetCalendarByDate(request, callback, asyncState);
    }
    
    private object[] OnEndGetCalendarByDate(System.IAsyncResult result)
    {
        clientapi.instaforex.com.Calendar.Event[] retVal = ((ICalendarService)(this)).EndGetCalendarByDate(result);
        return new object[] {
                retVal};
    }
    
    private void OnGetCalendarByDateCompleted(object state)
    {
        if ((this.GetCalendarByDateCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.GetCalendarByDateCompleted(this, new GetCalendarByDateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void GetCalendarByDateAsync(WcfApi.Calendar.DataRequest request)
    {
        this.GetCalendarByDateAsync(request, null);
    }
    
    public void GetCalendarByDateAsync(WcfApi.Calendar.DataRequest request, object userState)
    {
        if ((this.onBeginGetCalendarByDateDelegate == null))
        {
            this.onBeginGetCalendarByDateDelegate = new BeginOperationDelegate(this.OnBeginGetCalendarByDate);
        }
        if ((this.onEndGetCalendarByDateDelegate == null))
        {
            this.onEndGetCalendarByDateDelegate = new EndOperationDelegate(this.OnEndGetCalendarByDate);
        }
        if ((this.onGetCalendarByDateCompletedDelegate == null))
        {
            this.onGetCalendarByDateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCalendarByDateCompleted);
        }
        base.InvokeAsync(this.onBeginGetCalendarByDateDelegate, new object[] {
                    request}, this.onEndGetCalendarByDateDelegate, this.onGetCalendarByDateCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
    }
    
    private object[] OnEndOpen(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
        return null;
    }
    
    private void OnOpenCompleted(object state)
    {
        if ((this.OpenCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void OpenAsync()
    {
        this.OpenAsync(null);
    }
    
    public void OpenAsync(object userState)
    {
        if ((this.onBeginOpenDelegate == null))
        {
            this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
        }
        if ((this.onEndOpenDelegate == null))
        {
            this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
        }
        if ((this.onOpenCompletedDelegate == null))
        {
            this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
        }
        base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
    }
    
    private object[] OnEndClose(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
        return null;
    }
    
    private void OnCloseCompleted(object state)
    {
        if ((this.CloseCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void CloseAsync()
    {
        this.CloseAsync(null);
    }
    
    public void CloseAsync(object userState)
    {
        if ((this.onBeginCloseDelegate == null))
        {
            this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
        }
        if ((this.onEndCloseDelegate == null))
        {
            this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
        }
        if ((this.onCloseCompletedDelegate == null))
        {
            this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
        }
        base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
    }
    
    protected override ICalendarService CreateChannel()
    {
        return new CalendarServiceClientChannel(this);
    }
    
    private class CalendarServiceClientChannel : ChannelBase<ICalendarService>, ICalendarService
    {
        
        public CalendarServiceClientChannel(System.ServiceModel.ClientBase<ICalendarService> client) : 
                base(client)
        {
        }
        
        public System.IAsyncResult BeginGetCalendar(clientapi.instaforex.com.Calendar.Lang lang, clientapi.instaforex.com.Calendar.Account account, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[2];
            _args[0] = lang;
            _args[1] = account;
            System.IAsyncResult _result = base.BeginInvoke("GetCalendar", _args, callback, asyncState);
            return _result;
        }
        
        public clientapi.instaforex.com.Calendar.Event[] EndGetCalendar(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            clientapi.instaforex.com.Calendar.Event[] _result = ((clientapi.instaforex.com.Calendar.Event[])(base.EndInvoke("GetCalendar", _args, result)));
            return _result;
        }
        
        public System.IAsyncResult BeginGetCalendarByDate(WcfApi.Calendar.DataRequest request, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = request;
            System.IAsyncResult _result = base.BeginInvoke("GetCalendarByDate", _args, callback, asyncState);
            return _result;
        }
        
        public clientapi.instaforex.com.Calendar.Event[] EndGetCalendarByDate(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            clientapi.instaforex.com.Calendar.Event[] _result = ((clientapi.instaforex.com.Calendar.Event[])(base.EndInvoke("GetCalendarByDate", _args, result)));
            return _result;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://client-api.instaforex.com/Calendar/", ConfigurationName="ICalendarServiceJson")]
public interface ICalendarServiceJson
{
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://client-api.instaforex.com/Calendar/ICalendarServiceJson/GetCalendarByDateJ" +
        "son", ReplyAction="http://client-api.instaforex.com/Calendar/ICalendarServiceJson/GetCalendarByDateJ" +
        "sonResponse")]
    System.IAsyncResult BeginGetCalendarByDateJson(WcfApi.Calendar.DataRequest request, System.AsyncCallback callback, object asyncState);
    
    clientapi.instaforex.com.Calendar.Event[] EndGetCalendarByDateJson(System.IAsyncResult result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalendarServiceJsonChannel : ICalendarServiceJson, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GetCalendarByDateJsonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public GetCalendarByDateJsonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public clientapi.instaforex.com.Calendar.Event[] Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((clientapi.instaforex.com.Calendar.Event[])(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalendarServiceJsonClient : System.ServiceModel.ClientBase<ICalendarServiceJson>, ICalendarServiceJson
{
    
    private BeginOperationDelegate onBeginGetCalendarByDateJsonDelegate;
    
    private EndOperationDelegate onEndGetCalendarByDateJsonDelegate;
    
    private System.Threading.SendOrPostCallback onGetCalendarByDateJsonCompletedDelegate;
    
    private BeginOperationDelegate onBeginOpenDelegate;
    
    private EndOperationDelegate onEndOpenDelegate;
    
    private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
    
    private BeginOperationDelegate onBeginCloseDelegate;
    
    private EndOperationDelegate onEndCloseDelegate;
    
    private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
    
    public CalendarServiceJsonClient()
    {
    }
    
    public CalendarServiceJsonClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalendarServiceJsonClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalendarServiceJsonClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalendarServiceJsonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Net.CookieContainer CookieContainer
    {
        get
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                return httpCookieContainerManager.CookieContainer;
            }
            else
            {
                return null;
            }
        }
        set
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                httpCookieContainerManager.CookieContainer = value;
            }
            else
            {
                throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                        "ookieContainerBindingElement.");
            }
        }
    }
    
    public event System.EventHandler<GetCalendarByDateJsonCompletedEventArgs> GetCalendarByDateJsonCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult ICalendarServiceJson.BeginGetCalendarByDateJson(WcfApi.Calendar.DataRequest request, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginGetCalendarByDateJson(request, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    clientapi.instaforex.com.Calendar.Event[] ICalendarServiceJson.EndGetCalendarByDateJson(System.IAsyncResult result)
    {
        return base.Channel.EndGetCalendarByDateJson(result);
    }
    
    private System.IAsyncResult OnBeginGetCalendarByDateJson(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        WcfApi.Calendar.DataRequest request = ((WcfApi.Calendar.DataRequest)(inValues[0]));
        return ((ICalendarServiceJson)(this)).BeginGetCalendarByDateJson(request, callback, asyncState);
    }
    
    private object[] OnEndGetCalendarByDateJson(System.IAsyncResult result)
    {
        clientapi.instaforex.com.Calendar.Event[] retVal = ((ICalendarServiceJson)(this)).EndGetCalendarByDateJson(result);
        return new object[] {
                retVal};
    }
    
    private void OnGetCalendarByDateJsonCompleted(object state)
    {
        if ((this.GetCalendarByDateJsonCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.GetCalendarByDateJsonCompleted(this, new GetCalendarByDateJsonCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void GetCalendarByDateJsonAsync(WcfApi.Calendar.DataRequest request)
    {
        this.GetCalendarByDateJsonAsync(request, null);
    }
    
    public void GetCalendarByDateJsonAsync(WcfApi.Calendar.DataRequest request, object userState)
    {
        if ((this.onBeginGetCalendarByDateJsonDelegate == null))
        {
            this.onBeginGetCalendarByDateJsonDelegate = new BeginOperationDelegate(this.OnBeginGetCalendarByDateJson);
        }
        if ((this.onEndGetCalendarByDateJsonDelegate == null))
        {
            this.onEndGetCalendarByDateJsonDelegate = new EndOperationDelegate(this.OnEndGetCalendarByDateJson);
        }
        if ((this.onGetCalendarByDateJsonCompletedDelegate == null))
        {
            this.onGetCalendarByDateJsonCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCalendarByDateJsonCompleted);
        }
        base.InvokeAsync(this.onBeginGetCalendarByDateJsonDelegate, new object[] {
                    request}, this.onEndGetCalendarByDateJsonDelegate, this.onGetCalendarByDateJsonCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
    }
    
    private object[] OnEndOpen(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
        return null;
    }
    
    private void OnOpenCompleted(object state)
    {
        if ((this.OpenCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void OpenAsync()
    {
        this.OpenAsync(null);
    }
    
    public void OpenAsync(object userState)
    {
        if ((this.onBeginOpenDelegate == null))
        {
            this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
        }
        if ((this.onEndOpenDelegate == null))
        {
            this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
        }
        if ((this.onOpenCompletedDelegate == null))
        {
            this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
        }
        base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
    }
    
    private object[] OnEndClose(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
        return null;
    }
    
    private void OnCloseCompleted(object state)
    {
        if ((this.CloseCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void CloseAsync()
    {
        this.CloseAsync(null);
    }
    
    public void CloseAsync(object userState)
    {
        if ((this.onBeginCloseDelegate == null))
        {
            this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
        }
        if ((this.onEndCloseDelegate == null))
        {
            this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
        }
        if ((this.onCloseCompletedDelegate == null))
        {
            this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
        }
        base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
    }
    
    protected override ICalendarServiceJson CreateChannel()
    {
        return new CalendarServiceJsonClientChannel(this);
    }
    
    private class CalendarServiceJsonClientChannel : ChannelBase<ICalendarServiceJson>, ICalendarServiceJson
    {
        
        public CalendarServiceJsonClientChannel(System.ServiceModel.ClientBase<ICalendarServiceJson> client) : 
                base(client)
        {
        }
        
        public System.IAsyncResult BeginGetCalendarByDateJson(WcfApi.Calendar.DataRequest request, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = request;
            System.IAsyncResult _result = base.BeginInvoke("GetCalendarByDateJson", _args, callback, asyncState);
            return _result;
        }
        
        public clientapi.instaforex.com.Calendar.Event[] EndGetCalendarByDateJson(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            clientapi.instaforex.com.Calendar.Event[] _result = ((clientapi.instaforex.com.Calendar.Event[])(base.EndInvoke("GetCalendarByDateJson", _args, result)));
            return _result;
        }
    }
}
