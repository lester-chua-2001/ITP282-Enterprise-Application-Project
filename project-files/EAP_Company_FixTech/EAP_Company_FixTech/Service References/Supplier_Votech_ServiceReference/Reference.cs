﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EAP_Company_FixTech.Supplier_Votech_ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DAL_CreateInvoice", Namespace="http://schemas.datacontract.org/2004/07/EAP_Supplier_Votech.DAL.Lester")]
    [System.SerializableAttribute()]
    public partial class DAL_CreateInvoice : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_AdminCommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_ArchiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_CompanyAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_CompanyContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_CompanyEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InvoiceDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InvoiceNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OI_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PO_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProdIDField;
        
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
        public string CO_AdminComment {
            get {
                return this.CO_AdminCommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_AdminCommentField, value) != true)) {
                    this.CO_AdminCommentField = value;
                    this.RaisePropertyChanged("CO_AdminComment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CO_Archive {
            get {
                return this.CO_ArchiveField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_ArchiveField, value) != true)) {
                    this.CO_ArchiveField = value;
                    this.RaisePropertyChanged("CO_Archive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CO_CompanyAddress {
            get {
                return this.CO_CompanyAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_CompanyAddressField, value) != true)) {
                    this.CO_CompanyAddressField = value;
                    this.RaisePropertyChanged("CO_CompanyAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CO_CompanyContact {
            get {
                return this.CO_CompanyContactField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_CompanyContactField, value) != true)) {
                    this.CO_CompanyContactField = value;
                    this.RaisePropertyChanged("CO_CompanyContact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CO_CompanyEmail {
            get {
                return this.CO_CompanyEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_CompanyEmailField, value) != true)) {
                    this.CO_CompanyEmailField = value;
                    this.RaisePropertyChanged("CO_CompanyEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CO_CompanyName {
            get {
                return this.CO_CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_CompanyNameField, value) != true)) {
                    this.CO_CompanyNameField = value;
                    this.RaisePropertyChanged("CO_CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CO_Date {
            get {
                return this.CO_DateField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_DateField, value) != true)) {
                    this.CO_DateField = value;
                    this.RaisePropertyChanged("CO_Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CO_ID {
            get {
                return this.CO_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_IDField, value) != true)) {
                    this.CO_IDField = value;
                    this.RaisePropertyChanged("CO_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InvoiceDate {
            get {
                return this.InvoiceDateField;
            }
            set {
                if ((object.ReferenceEquals(this.InvoiceDateField, value) != true)) {
                    this.InvoiceDateField = value;
                    this.RaisePropertyChanged("InvoiceDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InvoiceNum {
            get {
                return this.InvoiceNumField;
            }
            set {
                if ((object.ReferenceEquals(this.InvoiceNumField, value) != true)) {
                    this.InvoiceNumField = value;
                    this.RaisePropertyChanged("InvoiceNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OI_ID {
            get {
                return this.OI_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.OI_IDField, value) != true)) {
                    this.OI_IDField = value;
                    this.RaisePropertyChanged("OI_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PO_ID {
            get {
                return this.PO_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.PO_IDField, value) != true)) {
                    this.PO_IDField = value;
                    this.RaisePropertyChanged("PO_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProdID {
            get {
                return this.ProdIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdIDField, value) != true)) {
                    this.ProdIDField = value;
                    this.RaisePropertyChanged("ProdID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DAL_DeliveryOrder", Namespace="http://schemas.datacontract.org/2004/07/EAP_Supplier_Votech.DAL.Nelson")]
    [System.SerializableAttribute()]
    public partial class DAL_DeliveryOrder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CO_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DO_CompanyAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DO_CompanyContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DO_CompanyEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DO_CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DO_DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DO_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DO_RemarksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DO_StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OI_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProdIDField;
        
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
        public string CO_ID {
            get {
                return this.CO_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.CO_IDField, value) != true)) {
                    this.CO_IDField = value;
                    this.RaisePropertyChanged("CO_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DO_CompanyAddress {
            get {
                return this.DO_CompanyAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.DO_CompanyAddressField, value) != true)) {
                    this.DO_CompanyAddressField = value;
                    this.RaisePropertyChanged("DO_CompanyAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DO_CompanyContact {
            get {
                return this.DO_CompanyContactField;
            }
            set {
                if ((object.ReferenceEquals(this.DO_CompanyContactField, value) != true)) {
                    this.DO_CompanyContactField = value;
                    this.RaisePropertyChanged("DO_CompanyContact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DO_CompanyEmail {
            get {
                return this.DO_CompanyEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.DO_CompanyEmailField, value) != true)) {
                    this.DO_CompanyEmailField = value;
                    this.RaisePropertyChanged("DO_CompanyEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DO_CompanyName {
            get {
                return this.DO_CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DO_CompanyNameField, value) != true)) {
                    this.DO_CompanyNameField = value;
                    this.RaisePropertyChanged("DO_CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DO_Date {
            get {
                return this.DO_DateField;
            }
            set {
                if ((object.ReferenceEquals(this.DO_DateField, value) != true)) {
                    this.DO_DateField = value;
                    this.RaisePropertyChanged("DO_Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DO_ID {
            get {
                return this.DO_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.DO_IDField, value) != true)) {
                    this.DO_IDField = value;
                    this.RaisePropertyChanged("DO_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DO_Remarks {
            get {
                return this.DO_RemarksField;
            }
            set {
                if ((object.ReferenceEquals(this.DO_RemarksField, value) != true)) {
                    this.DO_RemarksField = value;
                    this.RaisePropertyChanged("DO_Remarks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DO_Status {
            get {
                return this.DO_StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.DO_StatusField, value) != true)) {
                    this.DO_StatusField = value;
                    this.RaisePropertyChanged("DO_Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OI_ID {
            get {
                return this.OI_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.OI_IDField, value) != true)) {
                    this.OI_IDField = value;
                    this.RaisePropertyChanged("OI_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProdID {
            get {
                return this.ProdIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdIDField, value) != true)) {
                    this.ProdIDField = value;
                    this.RaisePropertyChanged("ProdID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Supplier_Votech_ServiceReference.IWs_Supplier_Votech")]
    public interface IWs_Supplier_Votech {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/insertPurchaseOrder", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/insertPurchaseOrderResponse")]
        int insertPurchaseOrder(string name, string email, string contact, string address, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/insertPurchaseOrder", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/insertPurchaseOrderResponse")]
        System.Threading.Tasks.Task<int> insertPurchaseOrderAsync(string name, string email, string contact, string address, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/createOrderItems", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/createOrderItemsResponse")]
        int createOrderItems(string ProdName, string ProdDesc, string ProdPrice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/createOrderItems", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/createOrderItemsResponse")]
        System.Threading.Tasks.Task<int> createOrderItemsAsync(string ProdName, string ProdDesc, string ProdPrice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/GetAll_Inventory", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/GetAll_InventoryResponse")]
        System.Data.DataSet GetAll_Inventory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/GetAll_Inventory", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/GetAll_InventoryResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAll_InventoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/GetAllCustomerOrders", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/GetAllCustomerOrdersResponse")]
        System.Data.DataSet GetAllCustomerOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/GetAllCustomerOrders", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/GetAllCustomerOrdersResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllCustomerOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/PaySupplier", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/PaySupplierResponse")]
        int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/PaySupplier", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/PaySupplierResponse")]
        System.Threading.Tasks.Task<int> PaySupplierAsync(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/GetInvoiceCreated", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/GetInvoiceCreatedResponse")]
        EAP_Company_FixTech.Supplier_Votech_ServiceReference.DAL_CreateInvoice[] GetInvoiceCreated();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/GetInvoiceCreated", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/GetInvoiceCreatedResponse")]
        System.Threading.Tasks.Task<EAP_Company_FixTech.Supplier_Votech_ServiceReference.DAL_CreateInvoice[]> GetInvoiceCreatedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/getallInvoiceOrderItem", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/getallInvoiceOrderItemResponse")]
        System.Data.DataSet getallInvoiceOrderItem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/getallInvoiceOrderItem", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/getallInvoiceOrderItemResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getallInvoiceOrderItemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/getAllDeliveryOrders", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/getAllDeliveryOrdersResponse")]
        System.Data.DataSet getAllDeliveryOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/getAllDeliveryOrders", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/getAllDeliveryOrdersResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getAllDeliveryOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/getDeliveryOrder", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/getDeliveryOrderResponse")]
        EAP_Company_FixTech.Supplier_Votech_ServiceReference.DAL_DeliveryOrder[] getDeliveryOrder(string DO_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWs_Supplier_Votech/getDeliveryOrder", ReplyAction="http://tempuri.org/IWs_Supplier_Votech/getDeliveryOrderResponse")]
        System.Threading.Tasks.Task<EAP_Company_FixTech.Supplier_Votech_ServiceReference.DAL_DeliveryOrder[]> getDeliveryOrderAsync(string DO_ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWs_Supplier_VotechChannel : EAP_Company_FixTech.Supplier_Votech_ServiceReference.IWs_Supplier_Votech, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Ws_Supplier_VotechClient : System.ServiceModel.ClientBase<EAP_Company_FixTech.Supplier_Votech_ServiceReference.IWs_Supplier_Votech>, EAP_Company_FixTech.Supplier_Votech_ServiceReference.IWs_Supplier_Votech {
        
        public Ws_Supplier_VotechClient() {
        }
        
        public Ws_Supplier_VotechClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Ws_Supplier_VotechClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Ws_Supplier_VotechClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Ws_Supplier_VotechClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int insertPurchaseOrder(string name, string email, string contact, string address, string date) {
            return base.Channel.insertPurchaseOrder(name, email, contact, address, date);
        }
        
        public System.Threading.Tasks.Task<int> insertPurchaseOrderAsync(string name, string email, string contact, string address, string date) {
            return base.Channel.insertPurchaseOrderAsync(name, email, contact, address, date);
        }
        
        public int createOrderItems(string ProdName, string ProdDesc, string ProdPrice) {
            return base.Channel.createOrderItems(ProdName, ProdDesc, ProdPrice);
        }
        
        public System.Threading.Tasks.Task<int> createOrderItemsAsync(string ProdName, string ProdDesc, string ProdPrice) {
            return base.Channel.createOrderItemsAsync(ProdName, ProdDesc, ProdPrice);
        }
        
        public System.Data.DataSet GetAll_Inventory() {
            return base.Channel.GetAll_Inventory();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAll_InventoryAsync() {
            return base.Channel.GetAll_InventoryAsync();
        }
        
        public System.Data.DataSet GetAllCustomerOrders() {
            return base.Channel.GetAllCustomerOrders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllCustomerOrdersAsync() {
            return base.Channel.GetAllCustomerOrdersAsync();
        }
        
        public int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum) {
            return base.Channel.PaySupplier(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum);
        }
        
        public System.Threading.Tasks.Task<int> PaySupplierAsync(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum) {
            return base.Channel.PaySupplierAsync(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum);
        }
        
        public EAP_Company_FixTech.Supplier_Votech_ServiceReference.DAL_CreateInvoice[] GetInvoiceCreated() {
            return base.Channel.GetInvoiceCreated();
        }
        
        public System.Threading.Tasks.Task<EAP_Company_FixTech.Supplier_Votech_ServiceReference.DAL_CreateInvoice[]> GetInvoiceCreatedAsync() {
            return base.Channel.GetInvoiceCreatedAsync();
        }
        
        public System.Data.DataSet getallInvoiceOrderItem() {
            return base.Channel.getallInvoiceOrderItem();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getallInvoiceOrderItemAsync() {
            return base.Channel.getallInvoiceOrderItemAsync();
        }
        
        public System.Data.DataSet getAllDeliveryOrders() {
            return base.Channel.getAllDeliveryOrders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getAllDeliveryOrdersAsync() {
            return base.Channel.getAllDeliveryOrdersAsync();
        }
        
        public EAP_Company_FixTech.Supplier_Votech_ServiceReference.DAL_DeliveryOrder[] getDeliveryOrder(string DO_ID) {
            return base.Channel.getDeliveryOrder(DO_ID);
        }
        
        public System.Threading.Tasks.Task<EAP_Company_FixTech.Supplier_Votech_ServiceReference.DAL_DeliveryOrder[]> getDeliveryOrderAsync(string DO_ID) {
            return base.Channel.getDeliveryOrderAsync(DO_ID);
        }
    }
}