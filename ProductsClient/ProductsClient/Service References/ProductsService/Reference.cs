﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductsClient.ProductsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductData", Namespace="http://schemas.datacontract.org/2004/07/Products")]
    [System.SerializableAttribute()]
    public partial class ProductData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ListPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNumberField;
        
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
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ListPrice {
            get {
                return this.ListPriceField;
            }
            set {
                if ((this.ListPriceField.Equals(value) != true)) {
                    this.ListPriceField = value;
                    this.RaisePropertyChanged("ListPrice");
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
        public string ProductNumber {
            get {
                return this.ProductNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNumberField, value) != true)) {
                    this.ProductNumberField = value;
                    this.RaisePropertyChanged("ProductNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductsService.IProductsService")]
    public interface IProductsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/ListProducts", ReplyAction="http://tempuri.org/IProductsService/ListProductsResponse")]
        string[] ListProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/ListProducts", ReplyAction="http://tempuri.org/IProductsService/ListProductsResponse")]
        System.Threading.Tasks.Task<string[]> ListProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProduct", ReplyAction="http://tempuri.org/IProductsService/GetProductResponse")]
        ProductsClient.ProductsService.ProductData GetProduct(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProduct", ReplyAction="http://tempuri.org/IProductsService/GetProductResponse")]
        System.Threading.Tasks.Task<ProductsClient.ProductsService.ProductData> GetProductAsync(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/CurrentStockLevel", ReplyAction="http://tempuri.org/IProductsService/CurrentStockLevelResponse")]
        int CurrentStockLevel(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/CurrentStockLevel", ReplyAction="http://tempuri.org/IProductsService/CurrentStockLevelResponse")]
        System.Threading.Tasks.Task<int> CurrentStockLevelAsync(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/ChangeStockLevel", ReplyAction="http://tempuri.org/IProductsService/ChangeStockLevelResponse")]
        bool ChangeStockLevel(string productNumber, short newStockLevel, string shelf, int bin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/ChangeStockLevel", ReplyAction="http://tempuri.org/IProductsService/ChangeStockLevelResponse")]
        System.Threading.Tasks.Task<bool> ChangeStockLevelAsync(string productNumber, short newStockLevel, string shelf, int bin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsServiceChannel : ProductsClient.ProductsService.IProductsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsServiceClient : System.ServiceModel.ClientBase<ProductsClient.ProductsService.IProductsService>, ProductsClient.ProductsService.IProductsService {
        
        public ProductsServiceClient() {
        }
        
        public ProductsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListProducts() {
            return base.Channel.ListProducts();
        }
        
        public System.Threading.Tasks.Task<string[]> ListProductsAsync() {
            return base.Channel.ListProductsAsync();
        }
        
        public ProductsClient.ProductsService.ProductData GetProduct(string productNumber) {
            return base.Channel.GetProduct(productNumber);
        }
        
        public System.Threading.Tasks.Task<ProductsClient.ProductsService.ProductData> GetProductAsync(string productNumber) {
            return base.Channel.GetProductAsync(productNumber);
        }
        
        public int CurrentStockLevel(string productNumber) {
            return base.Channel.CurrentStockLevel(productNumber);
        }
        
        public System.Threading.Tasks.Task<int> CurrentStockLevelAsync(string productNumber) {
            return base.Channel.CurrentStockLevelAsync(productNumber);
        }
        
        public bool ChangeStockLevel(string productNumber, short newStockLevel, string shelf, int bin) {
            return base.Channel.ChangeStockLevel(productNumber, newStockLevel, shelf, bin);
        }
        
        public System.Threading.Tasks.Task<bool> ChangeStockLevelAsync(string productNumber, short newStockLevel, string shelf, int bin) {
            return base.Channel.ChangeStockLevelAsync(productNumber, newStockLevel, shelf, bin);
        }
    }
}
