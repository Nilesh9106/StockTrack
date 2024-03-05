﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTrackClient.StoreService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Store", Namespace="http://schemas.datacontract.org/2004/07/StocktrackService.models")]
    [System.SerializableAttribute()]
    public partial class Store : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/StocktrackService.models")]
    [System.SerializableAttribute()]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodeField;
        
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
        public int Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StoreService.IStoreService")]
    public interface IStoreService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoreById", ReplyAction="http://tempuri.org/IStoreService/GetStoreByIdResponse")]
        StockTrackClient.StoreService.Store GetStoreById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoreById", ReplyAction="http://tempuri.org/IStoreService/GetStoreByIdResponse")]
        System.Threading.Tasks.Task<StockTrackClient.StoreService.Store> GetStoreByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoreByEmail", ReplyAction="http://tempuri.org/IStoreService/GetStoreByEmailResponse")]
        StockTrackClient.StoreService.Store GetStoreByEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoreByEmail", ReplyAction="http://tempuri.org/IStoreService/GetStoreByEmailResponse")]
        System.Threading.Tasks.Task<StockTrackClient.StoreService.Store> GetStoreByEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/AddStore", ReplyAction="http://tempuri.org/IStoreService/AddStoreResponse")]
        StockTrackClient.StoreService.Store AddStore(StockTrackClient.StoreService.Store store);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/AddStore", ReplyAction="http://tempuri.org/IStoreService/AddStoreResponse")]
        System.Threading.Tasks.Task<StockTrackClient.StoreService.Store> AddStoreAsync(StockTrackClient.StoreService.Store store);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/Verify", ReplyAction="http://tempuri.org/IStoreService/VerifyResponse")]
        StockTrackClient.StoreService.Response Verify(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/Verify", ReplyAction="http://tempuri.org/IStoreService/VerifyResponse")]
        System.Threading.Tasks.Task<StockTrackClient.StoreService.Response> VerifyAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/UpdateStore", ReplyAction="http://tempuri.org/IStoreService/UpdateStoreResponse")]
        StockTrackClient.StoreService.Store UpdateStore(StockTrackClient.StoreService.Store store);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/UpdateStore", ReplyAction="http://tempuri.org/IStoreService/UpdateStoreResponse")]
        System.Threading.Tasks.Task<StockTrackClient.StoreService.Store> UpdateStoreAsync(StockTrackClient.StoreService.Store store);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/DeleteStore", ReplyAction="http://tempuri.org/IStoreService/DeleteStoreResponse")]
        void DeleteStore(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/DeleteStore", ReplyAction="http://tempuri.org/IStoreService/DeleteStoreResponse")]
        System.Threading.Tasks.Task DeleteStoreAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStoreServiceChannel : StockTrackClient.StoreService.IStoreService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StoreServiceClient : System.ServiceModel.ClientBase<StockTrackClient.StoreService.IStoreService>, StockTrackClient.StoreService.IStoreService {
        
        public StoreServiceClient() {
        }
        
        public StoreServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StoreServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public StockTrackClient.StoreService.Store GetStoreById(int id) {
            return base.Channel.GetStoreById(id);
        }
        
        public System.Threading.Tasks.Task<StockTrackClient.StoreService.Store> GetStoreByIdAsync(int id) {
            return base.Channel.GetStoreByIdAsync(id);
        }
        
        public StockTrackClient.StoreService.Store GetStoreByEmail(string email) {
            return base.Channel.GetStoreByEmail(email);
        }
        
        public System.Threading.Tasks.Task<StockTrackClient.StoreService.Store> GetStoreByEmailAsync(string email) {
            return base.Channel.GetStoreByEmailAsync(email);
        }
        
        public StockTrackClient.StoreService.Store AddStore(StockTrackClient.StoreService.Store store) {
            return base.Channel.AddStore(store);
        }
        
        public System.Threading.Tasks.Task<StockTrackClient.StoreService.Store> AddStoreAsync(StockTrackClient.StoreService.Store store) {
            return base.Channel.AddStoreAsync(store);
        }
        
        public StockTrackClient.StoreService.Response Verify(string email, string password) {
            return base.Channel.Verify(email, password);
        }
        
        public System.Threading.Tasks.Task<StockTrackClient.StoreService.Response> VerifyAsync(string email, string password) {
            return base.Channel.VerifyAsync(email, password);
        }
        
        public StockTrackClient.StoreService.Store UpdateStore(StockTrackClient.StoreService.Store store) {
            return base.Channel.UpdateStore(store);
        }
        
        public System.Threading.Tasks.Task<StockTrackClient.StoreService.Store> UpdateStoreAsync(StockTrackClient.StoreService.Store store) {
            return base.Channel.UpdateStoreAsync(store);
        }
        
        public void DeleteStore(int id) {
            base.Channel.DeleteStore(id);
        }
        
        public System.Threading.Tasks.Task DeleteStoreAsync(int id) {
            return base.Channel.DeleteStoreAsync(id);
        }
    }
}