﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.0
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileWebApi.Misc.Service.WcfMiscService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseModelOfShareModel_S7WUFefR", Namespace="http://schemas.datacontract.org/2004/07/CYP2014.Shd.WCF.Service.Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MobileWebApi.Misc.Service.WcfMiscService.ShareModel))]
    public partial class BaseModelOfShareModel_S7WUFefR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MobileWebApi.Misc.Service.WcfMiscService.ShareModel[] ItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MobileWebApi.Misc.Service.WcfMiscService.ShareModel[] Items {
            get {
                return this.ItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemsField, value) != true)) {
                    this.ItemsField = value;
                    this.RaisePropertyChanged("Items");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ShareModel", Namespace="http://schemas.datacontract.org/2004/07/CYP2014.Shd.WCF.Service.Models")]
    [System.SerializableAttribute()]
    public partial class ShareModel : MobileWebApi.Misc.Service.WcfMiscService.BaseModelOfShareModel_S7WUFefR {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseListModelOfCarPositionModel_S7WUFefR", Namespace="http://schemas.datacontract.org/2004/07/CYP2014.Shd.WCF.Service.Models")]
    [System.SerializableAttribute()]
    public partial class BaseListModelOfCarPositionModel_S7WUFefR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MobileWebApi.Misc.Service.WcfMiscService.CarPositionModel[] DataListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalCountField;
        
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
        public MobileWebApi.Misc.Service.WcfMiscService.CarPositionModel[] DataList {
            get {
                return this.DataListField;
            }
            set {
                if ((object.ReferenceEquals(this.DataListField, value) != true)) {
                    this.DataListField = value;
                    this.RaisePropertyChanged("DataList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalCount {
            get {
                return this.TotalCountField;
            }
            set {
                if ((this.TotalCountField.Equals(value) != true)) {
                    this.TotalCountField = value;
                    this.RaisePropertyChanged("TotalCount");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CarPositionModel", Namespace="http://schemas.datacontract.org/2004/07/CYP2014.Shd.WCF.Service.Models")]
    [System.SerializableAttribute()]
    public partial class CarPositionModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OridField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PositionAddrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PositionCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PositionNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PositionTelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ScreenNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrapezeXField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrapezeYField;
        
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
        public string PositionAddr {
            get {
                return this.PositionAddrField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionAddrField, value) != true)) {
                    this.PositionAddrField = value;
                    this.RaisePropertyChanged("PositionAddr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PositionCode {
            get {
                return this.PositionCodeField;
            }
            set {
                if ((this.PositionCodeField.Equals(value) != true)) {
                    this.PositionCodeField = value;
                    this.RaisePropertyChanged("PositionCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PositionName {
            get {
                return this.PositionNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionNameField, value) != true)) {
                    this.PositionNameField = value;
                    this.RaisePropertyChanged("PositionName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PositionTel {
            get {
                return this.PositionTelField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionTelField, value) != true)) {
                    this.PositionTelField = value;
                    this.RaisePropertyChanged("PositionTel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ScreenName {
            get {
                return this.ScreenNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ScreenNameField, value) != true)) {
                    this.ScreenNameField = value;
                    this.RaisePropertyChanged("ScreenName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrapezeX {
            get {
                return this.TrapezeXField;
            }
            set {
                if ((object.ReferenceEquals(this.TrapezeXField, value) != true)) {
                    this.TrapezeXField = value;
                    this.RaisePropertyChanged("TrapezeX");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrapezeY {
            get {
                return this.TrapezeYField;
            }
            set {
                if ((object.ReferenceEquals(this.TrapezeYField, value) != true)) {
                    this.TrapezeYField = value;
                    this.RaisePropertyChanged("TrapezeY");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MyCYPModel", Namespace="http://schemas.datacontract.org/2004/07/CYP2014.Shd.WCF.Service.Models")]
    [System.SerializableAttribute()]
    public partial class MyCYPModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CompleteTradingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhotoPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UnConfirmCarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UnPayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UnVehicleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VoucherField;
        
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
        public int CompleteTrading {
            get {
                return this.CompleteTradingField;
            }
            set {
                if ((this.CompleteTradingField.Equals(value) != true)) {
                    this.CompleteTradingField = value;
                    this.RaisePropertyChanged("CompleteTrading");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Money {
            get {
                return this.MoneyField;
            }
            set {
                if ((this.MoneyField.Equals(value) != true)) {
                    this.MoneyField = value;
                    this.RaisePropertyChanged("Money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhotoPath {
            get {
                return this.PhotoPathField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoPathField, value) != true)) {
                    this.PhotoPathField = value;
                    this.RaisePropertyChanged("PhotoPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UnConfirmCar {
            get {
                return this.UnConfirmCarField;
            }
            set {
                if ((this.UnConfirmCarField.Equals(value) != true)) {
                    this.UnConfirmCarField = value;
                    this.RaisePropertyChanged("UnConfirmCar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UnPay {
            get {
                return this.UnPayField;
            }
            set {
                if ((this.UnPayField.Equals(value) != true)) {
                    this.UnPayField = value;
                    this.RaisePropertyChanged("UnPay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UnVehicle {
            get {
                return this.UnVehicleField;
            }
            set {
                if ((this.UnVehicleField.Equals(value) != true)) {
                    this.UnVehicleField = value;
                    this.RaisePropertyChanged("UnVehicle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Voucher {
            get {
                return this.VoucherField;
            }
            set {
                if ((this.VoucherField.Equals(value) != true)) {
                    this.VoucherField = value;
                    this.RaisePropertyChanged("Voucher");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfMiscService.IWcfMiscService")]
    public interface IWcfMiscService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/LogShare", ReplyAction="http://tempuri.org/IWcfMiscService/LogShareResponse")]
        MobileWebApi.Misc.Service.WcfMiscService.ShareModel LogShare(string businesid, string tradecode, string pagefrom, string shareto, string tokenKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/LogShare", ReplyAction="http://tempuri.org/IWcfMiscService/LogShareResponse")]
        System.Threading.Tasks.Task<MobileWebApi.Misc.Service.WcfMiscService.ShareModel> LogShareAsync(string businesid, string tradecode, string pagefrom, string shareto, string tokenKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/GetCarPositionList", ReplyAction="http://tempuri.org/IWcfMiscService/GetCarPositionListResponse")]
        MobileWebApi.Misc.Service.WcfMiscService.BaseListModelOfCarPositionModel_S7WUFefR GetCarPositionList(string tokenKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/GetCarPositionList", ReplyAction="http://tempuri.org/IWcfMiscService/GetCarPositionListResponse")]
        System.Threading.Tasks.Task<MobileWebApi.Misc.Service.WcfMiscService.BaseListModelOfCarPositionModel_S7WUFefR> GetCarPositionListAsync(string tokenKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/InsertMessage", ReplyAction="http://tempuri.org/IWcfMiscService/InsertMessageResponse")]
        bool InsertMessage(int uid, string message, int msgType, string contactWay, string tokenKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/InsertMessage", ReplyAction="http://tempuri.org/IWcfMiscService/InsertMessageResponse")]
        System.Threading.Tasks.Task<bool> InsertMessageAsync(int uid, string message, int msgType, string contactWay, string tokenKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/GetMyCYPInfo", ReplyAction="http://tempuri.org/IWcfMiscService/GetMyCYPInfoResponse")]
        MobileWebApi.Misc.Service.WcfMiscService.MyCYPModel GetMyCYPInfo(int uId, string tokenKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/GetMyCYPInfo", ReplyAction="http://tempuri.org/IWcfMiscService/GetMyCYPInfoResponse")]
        System.Threading.Tasks.Task<MobileWebApi.Misc.Service.WcfMiscService.MyCYPModel> GetMyCYPInfoAsync(int uId, string tokenKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/UpdateHeadImg", ReplyAction="http://tempuri.org/IWcfMiscService/UpdateHeadImgResponse")]
        int UpdateHeadImg(string headImg, int uId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfMiscService/UpdateHeadImg", ReplyAction="http://tempuri.org/IWcfMiscService/UpdateHeadImgResponse")]
        System.Threading.Tasks.Task<int> UpdateHeadImgAsync(string headImg, int uId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfMiscServiceChannel : global::MobileWebApi.Misc.Service.WcfMiscService.IWcfMiscService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfMiscServiceClient : System.ServiceModel.ClientBase<global::MobileWebApi.Misc.Service.WcfMiscService.IWcfMiscService>, global::MobileWebApi.Misc.Service.WcfMiscService.IWcfMiscService {
        
        public WcfMiscServiceClient() {
        }
        
        public WcfMiscServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfMiscServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfMiscServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfMiscServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MobileWebApi.Misc.Service.WcfMiscService.ShareModel LogShare(string businesid, string tradecode, string pagefrom, string shareto, string tokenKey) {
            return base.Channel.LogShare(businesid, tradecode, pagefrom, shareto, tokenKey);
        }
        
        public System.Threading.Tasks.Task<MobileWebApi.Misc.Service.WcfMiscService.ShareModel> LogShareAsync(string businesid, string tradecode, string pagefrom, string shareto, string tokenKey) {
            return base.Channel.LogShareAsync(businesid, tradecode, pagefrom, shareto, tokenKey);
        }
        
        public MobileWebApi.Misc.Service.WcfMiscService.BaseListModelOfCarPositionModel_S7WUFefR GetCarPositionList(string tokenKey) {
            return base.Channel.GetCarPositionList(tokenKey);
        }
        
        public System.Threading.Tasks.Task<MobileWebApi.Misc.Service.WcfMiscService.BaseListModelOfCarPositionModel_S7WUFefR> GetCarPositionListAsync(string tokenKey) {
            return base.Channel.GetCarPositionListAsync(tokenKey);
        }
        
        public bool InsertMessage(int uid, string message, int msgType, string contactWay, string tokenKey) {
            return base.Channel.InsertMessage(uid, message, msgType, contactWay, tokenKey);
        }
        
        public System.Threading.Tasks.Task<bool> InsertMessageAsync(int uid, string message, int msgType, string contactWay, string tokenKey) {
            return base.Channel.InsertMessageAsync(uid, message, msgType, contactWay, tokenKey);
        }
        
        public MobileWebApi.Misc.Service.WcfMiscService.MyCYPModel GetMyCYPInfo(int uId, string tokenKey) {
            return base.Channel.GetMyCYPInfo(uId, tokenKey);
        }
        
        public System.Threading.Tasks.Task<MobileWebApi.Misc.Service.WcfMiscService.MyCYPModel> GetMyCYPInfoAsync(int uId, string tokenKey) {
            return base.Channel.GetMyCYPInfoAsync(uId, tokenKey);
        }
        
        public int UpdateHeadImg(string headImg, int uId) {
            return base.Channel.UpdateHeadImg(headImg, uId);
        }
        
        public System.Threading.Tasks.Task<int> UpdateHeadImgAsync(string headImg, int uId) {
            return base.Channel.UpdateHeadImgAsync(headImg, uId);
        }
    }
}
