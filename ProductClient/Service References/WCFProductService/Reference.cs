﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductClient.WCFProductService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ProductBL")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Desc {
            get {
                return this.DescField;
            }
            set {
                if ((object.ReferenceEquals(this.DescField, value) != true)) {
                    this.DescField = value;
                    this.RaisePropertyChanged("Desc");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFProductService.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProducts", ReplyAction="http://tempuri.org/IProductService/GetProductsResponse")]
        ProductClient.WCFProductService.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProducts", ReplyAction="http://tempuri.org/IProductService/GetProductsResponse")]
        System.Threading.Tasks.Task<ProductClient.WCFProductService.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProductByID", ReplyAction="http://tempuri.org/IProductService/GetProductByIDResponse")]
        ProductClient.WCFProductService.Product GetProductByID(int ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProductByID", ReplyAction="http://tempuri.org/IProductService/GetProductByIDResponse")]
        System.Threading.Tasks.Task<ProductClient.WCFProductService.Product> GetProductByIDAsync(int ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/CreateProduct", ReplyAction="http://tempuri.org/IProductService/CreateProductResponse")]
        void CreateProduct(ProductClient.WCFProductService.Product newProduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/CreateProduct", ReplyAction="http://tempuri.org/IProductService/CreateProductResponse")]
        System.Threading.Tasks.Task CreateProductAsync(ProductClient.WCFProductService.Product newProduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/UpdateProduct", ReplyAction="http://tempuri.org/IProductService/UpdateProductResponse")]
        void UpdateProduct([System.ServiceModel.MessageParameterAttribute(Name="updateProduct")] ProductClient.WCFProductService.Product updateProduct1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/UpdateProduct", ReplyAction="http://tempuri.org/IProductService/UpdateProductResponse")]
        System.Threading.Tasks.Task UpdateProductAsync(ProductClient.WCFProductService.Product updateProduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DeleteProduct", ReplyAction="http://tempuri.org/IProductService/DeleteProductResponse")]
        void DeleteProduct(int deleteProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DeleteProduct", ReplyAction="http://tempuri.org/IProductService/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(int deleteProductId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : ProductClient.WCFProductService.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<ProductClient.WCFProductService.IProductService>, ProductClient.WCFProductService.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProductClient.WCFProductService.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<ProductClient.WCFProductService.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public ProductClient.WCFProductService.Product GetProductByID(int ProductId) {
            return base.Channel.GetProductByID(ProductId);
        }
        
        public System.Threading.Tasks.Task<ProductClient.WCFProductService.Product> GetProductByIDAsync(int ProductId) {
            return base.Channel.GetProductByIDAsync(ProductId);
        }
        
        public void CreateProduct(ProductClient.WCFProductService.Product newProduct) {
            base.Channel.CreateProduct(newProduct);
        }
        
        public System.Threading.Tasks.Task CreateProductAsync(ProductClient.WCFProductService.Product newProduct) {
            return base.Channel.CreateProductAsync(newProduct);
        }
        
        public void UpdateProduct(ProductClient.WCFProductService.Product updateProduct1) {
            base.Channel.UpdateProduct(updateProduct1);
        }
        
        public System.Threading.Tasks.Task UpdateProductAsync(ProductClient.WCFProductService.Product updateProduct) {
            return base.Channel.UpdateProductAsync(updateProduct);
        }
        
        public void DeleteProduct(int deleteProductId) {
            base.Channel.DeleteProduct(deleteProductId);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(int deleteProductId) {
            return base.Channel.DeleteProductAsync(deleteProductId);
        }
    }
}
