﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34011
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileWebApi.User.Service.LoginWcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginReturnDto", Namespace="http://schemas.datacontract.org/2004/07/CYP.LoginService.Service.Dtos")]
    [System.SerializableAttribute()]
    public partial class LoginReturnDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MobileWebApi.User.Service.LoginWcfService.LoginStatus StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MobileWebApi.User.Service.LoginWcfService.UserDto UserField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionId {
            get {
                return this.SessionIdField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIdField, value) != true)) {
                    this.SessionIdField = value;
                    this.RaisePropertyChanged("SessionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MobileWebApi.User.Service.LoginWcfService.LoginStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MobileWebApi.User.Service.LoginWcfService.UserDto User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDto", Namespace="http://schemas.datacontract.org/2004/07/CYP.LoginService.Service.Dtos")]
    [System.SerializableAttribute()]
    public partial class UserDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BuyerLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DemonstrateTagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OridField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProvinceNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RealNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] UserRightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaId {
            get {
                return this.AreaIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaIdField, value) != true)) {
                    this.AreaIdField = value;
                    this.RaisePropertyChanged("AreaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaName {
            get {
                return this.AreaNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaNameField, value) != true)) {
                    this.AreaNameField = value;
                    this.RaisePropertyChanged("AreaName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BuyerLevel {
            get {
                return this.BuyerLevelField;
            }
            set {
                if ((this.BuyerLevelField.Equals(value) != true)) {
                    this.BuyerLevelField = value;
                    this.RaisePropertyChanged("BuyerLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CityName {
            get {
                return this.CityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CityNameField, value) != true)) {
                    this.CityNameField = value;
                    this.RaisePropertyChanged("CityName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DemonstrateTag {
            get {
                return this.DemonstrateTagField;
            }
            set {
                if ((this.DemonstrateTagField.Equals(value) != true)) {
                    this.DemonstrateTagField = value;
                    this.RaisePropertyChanged("DemonstrateTag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Orid {
            get {
                return this.OridField;
            }
            set {
                if ((this.OridField.Equals(value) != true)) {
                    this.OridField = value;
                    this.RaisePropertyChanged("Orid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProvinceName {
            get {
                return this.ProvinceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinceNameField, value) != true)) {
                    this.ProvinceNameField = value;
                    this.RaisePropertyChanged("ProvinceName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RealName {
            get {
                return this.RealNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RealNameField, value) != true)) {
                    this.RealNameField = value;
                    this.RaisePropertyChanged("RealName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] UserRight {
            get {
                return this.UserRightField;
            }
            set {
                if ((object.ReferenceEquals(this.UserRightField, value) != true)) {
                    this.UserRightField = value;
                    this.RaisePropertyChanged("UserRight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserType {
            get {
                return this.UserTypeField;
            }
            set {
                if ((this.UserTypeField.Equals(value) != true)) {
                    this.UserTypeField = value;
                    this.RaisePropertyChanged("UserType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginStatus", Namespace="http://schemas.datacontract.org/2004/07/CYP.LoginService.Service.Dtos")]
    public enum LoginStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PasswordError = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NoUser = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IsLocked = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnActive = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HasLogin = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IpError = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ValidCodeError = 7,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientInfo", Namespace="http://schemas.datacontract.org/2004/07/CYP.LoginService.Service.Dtos")]
    [System.SerializableAttribute()]
    public partial class ClientInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrowserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MobileWebApi.User.Service.LoginWcfService.EnumClientType ClientTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IMEIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlatformField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProvinceNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResolutionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaName {
            get {
                return this.AreaNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaNameField, value) != true)) {
                    this.AreaNameField = value;
                    this.RaisePropertyChanged("AreaName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Browser {
            get {
                return this.BrowserField;
            }
            set {
                if ((object.ReferenceEquals(this.BrowserField, value) != true)) {
                    this.BrowserField = value;
                    this.RaisePropertyChanged("Browser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CityName {
            get {
                return this.CityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CityNameField, value) != true)) {
                    this.CityNameField = value;
                    this.RaisePropertyChanged("CityName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MobileWebApi.User.Service.LoginWcfService.EnumClientType ClientType {
            get {
                return this.ClientTypeField;
            }
            set {
                if ((this.ClientTypeField.Equals(value) != true)) {
                    this.ClientTypeField = value;
                    this.RaisePropertyChanged("ClientType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IMEI {
            get {
                return this.IMEIField;
            }
            set {
                if ((object.ReferenceEquals(this.IMEIField, value) != true)) {
                    this.IMEIField = value;
                    this.RaisePropertyChanged("IMEI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ip {
            get {
                return this.IpField;
            }
            set {
                if ((object.ReferenceEquals(this.IpField, value) != true)) {
                    this.IpField = value;
                    this.RaisePropertyChanged("Ip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Platform {
            get {
                return this.PlatformField;
            }
            set {
                if ((object.ReferenceEquals(this.PlatformField, value) != true)) {
                    this.PlatformField = value;
                    this.RaisePropertyChanged("Platform");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProvinceName {
            get {
                return this.ProvinceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinceNameField, value) != true)) {
                    this.ProvinceNameField = value;
                    this.RaisePropertyChanged("ProvinceName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Resolution {
            get {
                return this.ResolutionField;
            }
            set {
                if ((object.ReferenceEquals(this.ResolutionField, value) != true)) {
                    this.ResolutionField = value;
                    this.RaisePropertyChanged("Resolution");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StreetName {
            get {
                return this.StreetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetNameField, value) != true)) {
                    this.StreetNameField = value;
                    this.RaisePropertyChanged("StreetName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EnumClientType", Namespace="http://schemas.datacontract.org/2004/07/CYP.LoginService.Service.Dtos")]
    public enum EnumClientType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pc = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ios = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Android = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AndroidPad = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IosPad = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 13,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SayHiStatus", Namespace="http://schemas.datacontract.org/2004/07/CYP.LoginService.Service.Dtos")]
    public enum SayHiStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HasLogOut = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ForceQuit = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginWcfService.ILoginWcfService")]
    public interface ILoginWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/Login", ReplyAction="http://tempuri.org/ILoginWcfService/LoginResponse")]
        MobileWebApi.User.Service.LoginWcfService.LoginReturnDto Login(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/Login", ReplyAction="http://tempuri.org/ILoginWcfService/LoginResponse")]
        System.Threading.Tasks.Task<MobileWebApi.User.Service.LoginWcfService.LoginReturnDto> LoginAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/LoginWithClientInfo", ReplyAction="http://tempuri.org/ILoginWcfService/LoginWithClientInfoResponse")]
        MobileWebApi.User.Service.LoginWcfService.LoginReturnDto LoginWithClientInfo(string userName, string password, bool forceLogin, string validCode, MobileWebApi.User.Service.LoginWcfService.ClientInfo clientInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/LoginWithClientInfo", ReplyAction="http://tempuri.org/ILoginWcfService/LoginWithClientInfoResponse")]
        System.Threading.Tasks.Task<MobileWebApi.User.Service.LoginWcfService.LoginReturnDto> LoginWithClientInfoAsync(string userName, string password, bool forceLogin, string validCode, MobileWebApi.User.Service.LoginWcfService.ClientInfo clientInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/GetInfo", ReplyAction="http://tempuri.org/ILoginWcfService/GetInfoResponse")]
        MobileWebApi.User.Service.LoginWcfService.UserDto GetInfo(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/GetInfo", ReplyAction="http://tempuri.org/ILoginWcfService/GetInfoResponse")]
        System.Threading.Tasks.Task<MobileWebApi.User.Service.LoginWcfService.UserDto> GetInfoAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/SayHi", ReplyAction="http://tempuri.org/ILoginWcfService/SayHiResponse")]
        void SayHi(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/SayHi", ReplyAction="http://tempuri.org/ILoginWcfService/SayHiResponse")]
        System.Threading.Tasks.Task SayHiAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/SayHiWithStatus", ReplyAction="http://tempuri.org/ILoginWcfService/SayHiWithStatusResponse")]
        MobileWebApi.User.Service.LoginWcfService.SayHiStatus SayHiWithStatus(string sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/SayHiWithStatus", ReplyAction="http://tempuri.org/ILoginWcfService/SayHiWithStatusResponse")]
        System.Threading.Tasks.Task<MobileWebApi.User.Service.LoginWcfService.SayHiStatus> SayHiWithStatusAsync(string sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/IsOnline", ReplyAction="http://tempuri.org/ILoginWcfService/IsOnlineResponse")]
        bool IsOnline(string sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/IsOnline", ReplyAction="http://tempuri.org/ILoginWcfService/IsOnlineResponse")]
        System.Threading.Tasks.Task<bool> IsOnlineAsync(string sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/Logout", ReplyAction="http://tempuri.org/ILoginWcfService/LogoutResponse")]
        bool Logout(string sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginWcfService/Logout", ReplyAction="http://tempuri.org/ILoginWcfService/LogoutResponse")]
        System.Threading.Tasks.Task<bool> LogoutAsync(string sessionId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginWcfServiceChannel : MobileWebApi.User.Service.LoginWcfService.ILoginWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginWcfServiceClient : System.ServiceModel.ClientBase<MobileWebApi.User.Service.LoginWcfService.ILoginWcfService>, MobileWebApi.User.Service.LoginWcfService.ILoginWcfService {
        
        public LoginWcfServiceClient() {
        }
        
        public LoginWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MobileWebApi.User.Service.LoginWcfService.LoginReturnDto Login(string userName, string password) {
            return base.Channel.Login(userName, password);
        }
        
        public System.Threading.Tasks.Task<MobileWebApi.User.Service.LoginWcfService.LoginReturnDto> LoginAsync(string userName, string password) {
            return base.Channel.LoginAsync(userName, password);
        }
        
        public MobileWebApi.User.Service.LoginWcfService.LoginReturnDto LoginWithClientInfo(string userName, string password, bool forceLogin, string validCode, MobileWebApi.User.Service.LoginWcfService.ClientInfo clientInfo) {
            return base.Channel.LoginWithClientInfo(userName, password, forceLogin, validCode, clientInfo);
        }
        
        public System.Threading.Tasks.Task<MobileWebApi.User.Service.LoginWcfService.LoginReturnDto> LoginWithClientInfoAsync(string userName, string password, bool forceLogin, string validCode, MobileWebApi.User.Service.LoginWcfService.ClientInfo clientInfo) {
            return base.Channel.LoginWithClientInfoAsync(userName, password, forceLogin, validCode, clientInfo);
        }
        
        public MobileWebApi.User.Service.LoginWcfService.UserDto GetInfo(string userName) {
            return base.Channel.GetInfo(userName);
        }
        
        public System.Threading.Tasks.Task<MobileWebApi.User.Service.LoginWcfService.UserDto> GetInfoAsync(string userName) {
            return base.Channel.GetInfoAsync(userName);
        }
        
        public void SayHi(int userId) {
            base.Channel.SayHi(userId);
        }
        
        public System.Threading.Tasks.Task SayHiAsync(int userId) {
            return base.Channel.SayHiAsync(userId);
        }
        
        public MobileWebApi.User.Service.LoginWcfService.SayHiStatus SayHiWithStatus(string sessionId) {
            return base.Channel.SayHiWithStatus(sessionId);
        }
        
        public System.Threading.Tasks.Task<MobileWebApi.User.Service.LoginWcfService.SayHiStatus> SayHiWithStatusAsync(string sessionId) {
            return base.Channel.SayHiWithStatusAsync(sessionId);
        }
        
        public bool IsOnline(string sessionId) {
            return base.Channel.IsOnline(sessionId);
        }
        
        public System.Threading.Tasks.Task<bool> IsOnlineAsync(string sessionId) {
            return base.Channel.IsOnlineAsync(sessionId);
        }
        
        public bool Logout(string sessionId) {
            return base.Channel.Logout(sessionId);
        }
        
        public System.Threading.Tasks.Task<bool> LogoutAsync(string sessionId) {
            return base.Channel.LogoutAsync(sessionId);
        }
    }
}