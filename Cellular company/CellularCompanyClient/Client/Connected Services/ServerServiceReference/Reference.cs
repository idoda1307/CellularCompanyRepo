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
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.27130.2010
// 
namespace Client.ServerServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Models")]
    public partial class ClientDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AddressField;
        
        private System.Nullable<int> CallsToCenterField;
        
        private string ClientIdField;
        
        private Client.ServerServiceReference.ClientTypeDto ClientTypeField;
        
        private System.Nullable<int> ClientTypeIdField;
        
        private string ContactNumberField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CallsToCenter {
            get {
                return this.CallsToCenterField;
            }
            set {
                if ((this.CallsToCenterField.Equals(value) != true)) {
                    this.CallsToCenterField = value;
                    this.RaisePropertyChanged("CallsToCenter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientIdField, value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServerServiceReference.ClientTypeDto ClientType {
            get {
                return this.ClientTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientTypeField, value) != true)) {
                    this.ClientTypeField = value;
                    this.RaisePropertyChanged("ClientType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ClientTypeId {
            get {
                return this.ClientTypeIdField;
            }
            set {
                if ((this.ClientTypeIdField.Equals(value) != true)) {
                    this.ClientTypeIdField = value;
                    this.RaisePropertyChanged("ClientTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactNumber {
            get {
                return this.ContactNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNumberField, value) != true)) {
                    this.ContactNumberField = value;
                    this.RaisePropertyChanged("ContactNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientTypeDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Models")]
    public partial class ClientTypeDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int ClientTypeIdField;
        
        private System.Nullable<double> MinutePriceField;
        
        private System.Nullable<double> SMSPriceField;
        
        private string TypeNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientTypeId {
            get {
                return this.ClientTypeIdField;
            }
            set {
                if ((this.ClientTypeIdField.Equals(value) != true)) {
                    this.ClientTypeIdField = value;
                    this.RaisePropertyChanged("ClientTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> MinutePrice {
            get {
                return this.MinutePriceField;
            }
            set {
                if ((this.MinutePriceField.Equals(value) != true)) {
                    this.MinutePriceField = value;
                    this.RaisePropertyChanged("MinutePrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> SMSPrice {
            get {
                return this.SMSPriceField;
            }
            set {
                if ((this.SMSPriceField.Equals(value) != true)) {
                    this.SMSPriceField = value;
                    this.RaisePropertyChanged("SMSPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LineDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Models")]
    public partial class LineDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Client.ServerServiceReference.ClientDto ClientField;
        
        private string ClientIdField;
        
        private int LineIdField;
        
        private string NumberField;
        
        private Client.ServerServiceReference.PackageDto PackageField;
        
        private int PackageIdField;
        
        private string StatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServerServiceReference.ClientDto Client {
            get {
                return this.ClientField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientField, value) != true)) {
                    this.ClientField = value;
                    this.RaisePropertyChanged("Client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientIdField, value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LineId {
            get {
                return this.LineIdField;
            }
            set {
                if ((this.LineIdField.Equals(value) != true)) {
                    this.LineIdField = value;
                    this.RaisePropertyChanged("LineId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServerServiceReference.PackageDto Package {
            get {
                return this.PackageField;
            }
            set {
                if ((object.ReferenceEquals(this.PackageField, value) != true)) {
                    this.PackageField = value;
                    this.RaisePropertyChanged("Package");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PackageId {
            get {
                return this.PackageIdField;
            }
            set {
                if ((this.PackageIdField.Equals(value) != true)) {
                    this.PackageIdField = value;
                    this.RaisePropertyChanged("PackageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PackageDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Models")]
    public partial class PackageDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int PackageIdField;
        
        private Client.ServerServiceReference.PackageIncludesDto PackageIncludesField;
        
        private int PackageIncludesIdField;
        
        private string PackageNameField;
        
        private double PackageTotalPriceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PackageId {
            get {
                return this.PackageIdField;
            }
            set {
                if ((this.PackageIdField.Equals(value) != true)) {
                    this.PackageIdField = value;
                    this.RaisePropertyChanged("PackageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServerServiceReference.PackageIncludesDto PackageIncludes {
            get {
                return this.PackageIncludesField;
            }
            set {
                if ((object.ReferenceEquals(this.PackageIncludesField, value) != true)) {
                    this.PackageIncludesField = value;
                    this.RaisePropertyChanged("PackageIncludes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PackageIncludesId {
            get {
                return this.PackageIncludesIdField;
            }
            set {
                if ((this.PackageIncludesIdField.Equals(value) != true)) {
                    this.PackageIncludesIdField = value;
                    this.RaisePropertyChanged("PackageIncludesId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PackageName {
            get {
                return this.PackageNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PackageNameField, value) != true)) {
                    this.PackageNameField = value;
                    this.RaisePropertyChanged("PackageName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PackageTotalPrice {
            get {
                return this.PackageTotalPriceField;
            }
            set {
                if ((this.PackageTotalPriceField.Equals(value) != true)) {
                    this.PackageTotalPriceField = value;
                    this.RaisePropertyChanged("PackageTotalPrice");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PackageIncludesDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Models")]
    public partial class PackageIncludesDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double DiscountPrecentageField;
        
        private int FavoriteNumbersIdField;
        
        private double FixedPriceField;
        
        private int IdField;
        
        private string IncludeNameField;
        
        private bool InsideFamilyCallsField;
        
        private int MaxMinuteField;
        
        private bool MostCalledNumberField;
        
        private Client.ServerServiceReference.PackageDto PackageField;
        
        private int PackageIdField;
        
        private Client.ServerServiceReference.SelectedNumbersDto SelectedNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double DiscountPrecentage {
            get {
                return this.DiscountPrecentageField;
            }
            set {
                if ((this.DiscountPrecentageField.Equals(value) != true)) {
                    this.DiscountPrecentageField = value;
                    this.RaisePropertyChanged("DiscountPrecentage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FavoriteNumbersId {
            get {
                return this.FavoriteNumbersIdField;
            }
            set {
                if ((this.FavoriteNumbersIdField.Equals(value) != true)) {
                    this.FavoriteNumbersIdField = value;
                    this.RaisePropertyChanged("FavoriteNumbersId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double FixedPrice {
            get {
                return this.FixedPriceField;
            }
            set {
                if ((this.FixedPriceField.Equals(value) != true)) {
                    this.FixedPriceField = value;
                    this.RaisePropertyChanged("FixedPrice");
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
        public string IncludeName {
            get {
                return this.IncludeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.IncludeNameField, value) != true)) {
                    this.IncludeNameField = value;
                    this.RaisePropertyChanged("IncludeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool InsideFamilyCalls {
            get {
                return this.InsideFamilyCallsField;
            }
            set {
                if ((this.InsideFamilyCallsField.Equals(value) != true)) {
                    this.InsideFamilyCallsField = value;
                    this.RaisePropertyChanged("InsideFamilyCalls");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxMinute {
            get {
                return this.MaxMinuteField;
            }
            set {
                if ((this.MaxMinuteField.Equals(value) != true)) {
                    this.MaxMinuteField = value;
                    this.RaisePropertyChanged("MaxMinute");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MostCalledNumber {
            get {
                return this.MostCalledNumberField;
            }
            set {
                if ((this.MostCalledNumberField.Equals(value) != true)) {
                    this.MostCalledNumberField = value;
                    this.RaisePropertyChanged("MostCalledNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServerServiceReference.PackageDto Package {
            get {
                return this.PackageField;
            }
            set {
                if ((object.ReferenceEquals(this.PackageField, value) != true)) {
                    this.PackageField = value;
                    this.RaisePropertyChanged("Package");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PackageId {
            get {
                return this.PackageIdField;
            }
            set {
                if ((this.PackageIdField.Equals(value) != true)) {
                    this.PackageIdField = value;
                    this.RaisePropertyChanged("PackageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServerServiceReference.SelectedNumbersDto SelectedNumber {
            get {
                return this.SelectedNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SelectedNumberField, value) != true)) {
                    this.SelectedNumberField = value;
                    this.RaisePropertyChanged("SelectedNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectedNumbersDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Models")]
    public partial class SelectedNumbersDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string FirstNumberField;
        
        private int IdField;
        
        private string SecondNumberField;
        
        private string ThirdNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstNumber {
            get {
                return this.FirstNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNumberField, value) != true)) {
                    this.FirstNumberField = value;
                    this.RaisePropertyChanged("FirstNumber");
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
        public string SecondNumber {
            get {
                return this.SecondNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondNumberField, value) != true)) {
                    this.SecondNumberField = value;
                    this.RaisePropertyChanged("SecondNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ThirdNumber {
            get {
                return this.ThirdNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ThirdNumberField, value) != true)) {
                    this.ThirdNumberField = value;
                    this.RaisePropertyChanged("ThirdNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerServiceReference.ICRMService")]
    public interface ICRMService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddClient", ReplyAction="http://tempuri.org/ICRMService/AddClientResponse")]
        System.Threading.Tasks.Task AddClientAsync(Client.ServerServiceReference.ClientDto client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetClientTypes", ReplyAction="http://tempuri.org/ICRMService/GetClientTypesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Client.ServerServiceReference.ClientTypeDto>> GetClientTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetClients", ReplyAction="http://tempuri.org/ICRMService/GetClientsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Client.ServerServiceReference.ClientDto>> GetClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetLine", ReplyAction="http://tempuri.org/ICRMService/GetLineResponse")]
        System.Threading.Tasks.Task<Client.ServerServiceReference.LineDto> GetLineAsync(string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/UpdateClient", ReplyAction="http://tempuri.org/ICRMService/UpdateClientResponse")]
        System.Threading.Tasks.Task<Client.ServerServiceReference.ClientDto> UpdateClientAsync(string id, Client.ServerServiceReference.ClientDto client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetClientsIds", ReplyAction="http://tempuri.org/ICRMService/GetClientsIdsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetClientsIdsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/RemoveClient", ReplyAction="http://tempuri.org/ICRMService/RemoveClientResponse")]
        System.Threading.Tasks.Task<bool> RemoveClientAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetLines", ReplyAction="http://tempuri.org/ICRMService/GetLinesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Client.ServerServiceReference.LineDto>> GetLinesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICRMServiceChannel : Client.ServerServiceReference.ICRMService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CRMServiceClient : System.ServiceModel.ClientBase<Client.ServerServiceReference.ICRMService>, Client.ServerServiceReference.ICRMService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CRMServiceClient() : 
                base(CRMServiceClient.GetDefaultBinding(), CRMServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICRMService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CRMServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CRMServiceClient.GetBindingForEndpoint(endpointConfiguration), CRMServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CRMServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CRMServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CRMServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CRMServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CRMServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task AddClientAsync(Client.ServerServiceReference.ClientDto client) {
            return base.Channel.AddClientAsync(client);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Client.ServerServiceReference.ClientTypeDto>> GetClientTypesAsync() {
            return base.Channel.GetClientTypesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Client.ServerServiceReference.ClientDto>> GetClientsAsync() {
            return base.Channel.GetClientsAsync();
        }
        
        public System.Threading.Tasks.Task<Client.ServerServiceReference.LineDto> GetLineAsync(string number) {
            return base.Channel.GetLineAsync(number);
        }
        
        public System.Threading.Tasks.Task<Client.ServerServiceReference.ClientDto> UpdateClientAsync(string id, Client.ServerServiceReference.ClientDto client) {
            return base.Channel.UpdateClientAsync(id, client);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetClientsIdsAsync() {
            return base.Channel.GetClientsIdsAsync();
        }
        
        public System.Threading.Tasks.Task<bool> RemoveClientAsync(string id) {
            return base.Channel.RemoveClientAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Client.ServerServiceReference.LineDto>> GetLinesAsync() {
            return base.Channel.GetLinesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICRMService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICRMService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:51610/CRMService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return CRMServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICRMService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return CRMServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICRMService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_ICRMService,
        }
    }
}
