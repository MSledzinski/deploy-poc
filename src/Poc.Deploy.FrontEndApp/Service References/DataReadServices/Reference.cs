﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poc.Deploy.FrontEndApp.DataReadServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAllEmployersDataQuery", Namespace="http://schemas.datacontract.org/2004/07/Poc.Deploy.CommonModels.Queries")]
    [System.SerializableAttribute()]
    public partial class GetAllEmployersDataQuery : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAllEmployersDataQueryResponse", Namespace="http://schemas.datacontract.org/2004/07/Poc.Deploy.CommonModels.Queries")]
    [System.SerializableAttribute()]
    public partial class GetAllEmployersDataQueryResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poc.Deploy.FrontEndApp.DataReadServices.EmployerSummaryData[] DataField;
        
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
        public Poc.Deploy.FrontEndApp.DataReadServices.EmployerSummaryData[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployerSummaryData", Namespace="http://schemas.datacontract.org/2004/07/Poc.Deploy.CommonModels.Queries")]
    [System.SerializableAttribute()]
    public partial class EmployerSummaryData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalSalaryField;
        
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
        public int EmployerId {
            get {
                return this.EmployerIdField;
            }
            set {
                if ((this.EmployerIdField.Equals(value) != true)) {
                    this.EmployerIdField = value;
                    this.RaisePropertyChanged("EmployerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployerName {
            get {
                return this.EmployerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployerNameField, value) != true)) {
                    this.EmployerNameField = value;
                    this.RaisePropertyChanged("EmployerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalSalary {
            get {
                return this.TotalSalaryField;
            }
            set {
                if ((this.TotalSalaryField.Equals(value) != true)) {
                    this.TotalSalaryField = value;
                    this.RaisePropertyChanged("TotalSalary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataReadServices.IEmploymentQueryHandleService")]
    public interface IEmploymentQueryHandleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploymentQueryHandleService/Handle", ReplyAction="http://tempuri.org/IEmploymentQueryHandleService/HandleResponse")]
        Poc.Deploy.FrontEndApp.DataReadServices.GetAllEmployersDataQueryResponse Handle(Poc.Deploy.FrontEndApp.DataReadServices.GetAllEmployersDataQuery query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmploymentQueryHandleService/Handle", ReplyAction="http://tempuri.org/IEmploymentQueryHandleService/HandleResponse")]
        System.Threading.Tasks.Task<Poc.Deploy.FrontEndApp.DataReadServices.GetAllEmployersDataQueryResponse> HandleAsync(Poc.Deploy.FrontEndApp.DataReadServices.GetAllEmployersDataQuery query);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmploymentQueryHandleServiceChannel : Poc.Deploy.FrontEndApp.DataReadServices.IEmploymentQueryHandleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmploymentQueryHandleServiceClient : System.ServiceModel.ClientBase<Poc.Deploy.FrontEndApp.DataReadServices.IEmploymentQueryHandleService>, Poc.Deploy.FrontEndApp.DataReadServices.IEmploymentQueryHandleService {
        
        public EmploymentQueryHandleServiceClient() {
        }
        
        public EmploymentQueryHandleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmploymentQueryHandleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmploymentQueryHandleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmploymentQueryHandleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Poc.Deploy.FrontEndApp.DataReadServices.GetAllEmployersDataQueryResponse Handle(Poc.Deploy.FrontEndApp.DataReadServices.GetAllEmployersDataQuery query) {
            return base.Channel.Handle(query);
        }
        
        public System.Threading.Tasks.Task<Poc.Deploy.FrontEndApp.DataReadServices.GetAllEmployersDataQueryResponse> HandleAsync(Poc.Deploy.FrontEndApp.DataReadServices.GetAllEmployersDataQuery query) {
            return base.Channel.HandleAsync(query);
        }
    }
}