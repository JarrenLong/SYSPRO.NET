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
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 
namespace SYSPRO.NET.BusinessObjects.INVQSEOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class InvSerialNumberQuery {
        
        private InvSerialNumberQuerySystemInformation systemInformationField;
        
        private InvSerialNumberQuerySerialDetail serialDetailField;
        
        /// <remarks/>
        public InvSerialNumberQuerySystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public InvSerialNumberQuerySerialDetail SerialDetail {
            get {
                return this.serialDetailField;
            }
            set {
                this.serialDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InvSerialNumberQuerySystemInformation {
        
        private string cssStyleField;
        
        private string languageField;
        
        private string decFormatField;
        
        private string dateFormatField;
        
        private string roleField;
        
        private string versionField;
        
        private string companyIdField;
        
        private string companyNameField;
        
        private string operatorCodeField;
        
        private string operatorNameField;
        
        private string operatorGroupField;
        
        private string operatorEmailAddressField;
        
        private string operatorLocationField;
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
        /// <remarks/>
        public string CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        public string DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        public string DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorCode {
            get {
                return this.operatorCodeField;
            }
            set {
                this.operatorCodeField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorName {
            get {
                return this.operatorNameField;
            }
            set {
                this.operatorNameField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorGroup {
            get {
                return this.operatorGroupField;
            }
            set {
                this.operatorGroupField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorEmailAddress {
            get {
                return this.operatorEmailAddressField;
            }
            set {
                this.operatorEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorLocation {
            get {
                return this.operatorLocationField;
            }
            set {
                this.operatorLocationField = value;
            }
        }
        
        /// <remarks/>
        public string ReportDate {
            get {
                return this.reportDateField;
            }
            set {
                this.reportDateField = value;
            }
        }
        
        /// <remarks/>
        public string UseSeparatorOnReports {
            get {
                return this.useSeparatorOnReportsField;
            }
            set {
                this.useSeparatorOnReportsField = value;
            }
        }
        
        /// <remarks/>
        public string SeparatorToUse {
            get {
                return this.separatorToUseField;
            }
            set {
                this.separatorToUseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InvSerialNumberQuerySerialDetail {
        
        private string serialField;
        
        private string warehouseField;
        
        private string iNVWHC_DescriptionField;
        
        private string serialMethodField;
        
        private string stockCodeField;
        
        private string iNVMST_DescriptionField;
        
        private string serialDescriptionField;
        
        private string expiryDateField;
        
        private string scrapDateField;
        
        private string qtyReceivedField;
        
        private string qtyAvailableField;
        
        private string qtyOnHandField;
        
        private string locationField;
        
        private string serviceFlagField;
        
        private string loadFlagField;
        
        private string serviceDepotFlagField;
        
        private string dueDateField;
        
        private string customerField;
        
        private string nameField;
        
        private string lotField;
        
        private string archiveFilenameField;
        
        private string dateCreatedField;
        
        private string prvWarehouseField;
        
        private string versionField;
        
        private string releaseField;
        
        private InvSerialNumberQuerySerialDetailTransactionDetail[] transactionsField;
        
        /// <remarks/>
        public string Serial {
            get {
                return this.serialField;
            }
            set {
                this.serialField = value;
            }
        }
        
        /// <remarks/>
        public string Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public string INVWHC_Description {
            get {
                return this.iNVWHC_DescriptionField;
            }
            set {
                this.iNVWHC_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string SerialMethod {
            get {
                return this.serialMethodField;
            }
            set {
                this.serialMethodField = value;
            }
        }
        
        /// <remarks/>
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string INVMST_Description {
            get {
                return this.iNVMST_DescriptionField;
            }
            set {
                this.iNVMST_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string SerialDescription {
            get {
                return this.serialDescriptionField;
            }
            set {
                this.serialDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string ExpiryDate {
            get {
                return this.expiryDateField;
            }
            set {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        public string ScrapDate {
            get {
                return this.scrapDateField;
            }
            set {
                this.scrapDateField = value;
            }
        }
        
        /// <remarks/>
        public string QtyReceived {
            get {
                return this.qtyReceivedField;
            }
            set {
                this.qtyReceivedField = value;
            }
        }
        
        /// <remarks/>
        public string QtyAvailable {
            get {
                return this.qtyAvailableField;
            }
            set {
                this.qtyAvailableField = value;
            }
        }
        
        /// <remarks/>
        public string QtyOnHand {
            get {
                return this.qtyOnHandField;
            }
            set {
                this.qtyOnHandField = value;
            }
        }
        
        /// <remarks/>
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        public string ServiceFlag {
            get {
                return this.serviceFlagField;
            }
            set {
                this.serviceFlagField = value;
            }
        }
        
        /// <remarks/>
        public string LoadFlag {
            get {
                return this.loadFlagField;
            }
            set {
                this.loadFlagField = value;
            }
        }
        
        /// <remarks/>
        public string ServiceDepotFlag {
            get {
                return this.serviceDepotFlagField;
            }
            set {
                this.serviceDepotFlagField = value;
            }
        }
        
        /// <remarks/>
        public string DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        public string Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
            }
        }
        
        /// <remarks/>
        public string ArchiveFilename {
            get {
                return this.archiveFilenameField;
            }
            set {
                this.archiveFilenameField = value;
            }
        }
        
        /// <remarks/>
        public string DateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }
        
        /// <remarks/>
        public string PrvWarehouse {
            get {
                return this.prvWarehouseField;
            }
            set {
                this.prvWarehouseField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TransactionDetail", IsNullable=false)]
        public InvSerialNumberQuerySerialDetailTransactionDetail[] Transactions {
            get {
                return this.transactionsField;
            }
            set {
                this.transactionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InvSerialNumberQuerySerialDetailTransactionDetail {
        
        private string entryDateField;
        
        private string detailTypeField;
        
        private string revisionLevelField;
        
        private string referenceField;
        
        private string jobField;
        
        private string notationField;
        
        private string custSupplierField;
        
        private string custSupNameField;
        
        private string trnQtyField;
        
        private string trnValueField;
        
        private string trnWarehouseField;
        
        private string newLocationField;
        
        private string newExpiryDateField;
        
        private string purchaseOrderField;
        
        private string lotField;
        
        private string versionField;
        
        private string releaseField;
        
        private string trfFromWhField;
        
        /// <remarks/>
        public string EntryDate {
            get {
                return this.entryDateField;
            }
            set {
                this.entryDateField = value;
            }
        }
        
        /// <remarks/>
        public string DetailType {
            get {
                return this.detailTypeField;
            }
            set {
                this.detailTypeField = value;
            }
        }
        
        /// <remarks/>
        public string RevisionLevel {
            get {
                return this.revisionLevelField;
            }
            set {
                this.revisionLevelField = value;
            }
        }
        
        /// <remarks/>
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        public string Job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        public string Notation {
            get {
                return this.notationField;
            }
            set {
                this.notationField = value;
            }
        }
        
        /// <remarks/>
        public string CustSupplier {
            get {
                return this.custSupplierField;
            }
            set {
                this.custSupplierField = value;
            }
        }
        
        /// <remarks/>
        public string CustSupName {
            get {
                return this.custSupNameField;
            }
            set {
                this.custSupNameField = value;
            }
        }
        
        /// <remarks/>
        public string TrnQty {
            get {
                return this.trnQtyField;
            }
            set {
                this.trnQtyField = value;
            }
        }
        
        /// <remarks/>
        public string TrnValue {
            get {
                return this.trnValueField;
            }
            set {
                this.trnValueField = value;
            }
        }
        
        /// <remarks/>
        public string TrnWarehouse {
            get {
                return this.trnWarehouseField;
            }
            set {
                this.trnWarehouseField = value;
            }
        }
        
        /// <remarks/>
        public string NewLocation {
            get {
                return this.newLocationField;
            }
            set {
                this.newLocationField = value;
            }
        }
        
        /// <remarks/>
        public string NewExpiryDate {
            get {
                return this.newExpiryDateField;
            }
            set {
                this.newExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        public string PurchaseOrder {
            get {
                return this.purchaseOrderField;
            }
            set {
                this.purchaseOrderField = value;
            }
        }
        
        /// <remarks/>
        public string Lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        
        /// <remarks/>
        public string TrfFromWh {
            get {
                return this.trfFromWhField;
            }
            set {
                this.trfFromWhField = value;
            }
        }
    }
}
