﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 
namespace SYSPRO.NET.BusinessObjects.PORQINOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PorInspection {
        
        private PorInspectionSystemInformation systemInformationField;
        
        private PorInspectionInspectionItem inspectionItemField;
        
        /// <remarks/>
        public PorInspectionSystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public PorInspectionInspectionItem InspectionItem {
            get {
                return this.inspectionItemField;
            }
            set {
                this.inspectionItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PorInspectionSystemInformation {
        
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
    public partial class PorInspectionInspectionItem {
        
        private PorInspectionInspectionItemWarehouseItem warehouseItemField;
        
        /// <remarks/>
        public PorInspectionInspectionItemWarehouseItem WarehouseItem {
            get {
                return this.warehouseItemField;
            }
            set {
                this.warehouseItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PorInspectionInspectionItemWarehouseItem {
        
        private string warehouseField;
        
        private string descriptionField;
        
        private PorInspectionInspectionItemWarehouseItemStockCodeItem[] stockCodeItemField;
        
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StockCodeItem")]
        public PorInspectionInspectionItemWarehouseItemStockCodeItem[] StockCodeItem {
            get {
                return this.stockCodeItemField;
            }
            set {
                this.stockCodeItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PorInspectionInspectionItemWarehouseItemStockCodeItem {
        
        private string stockCodeField;
        
        private string descriptionField;
        
        private string longDescField;
        
        private string stockUomField;
        
        private string supCatalogueNumField;
        
        private PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItem[] grnItemField;
        
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string LongDesc {
            get {
                return this.longDescField;
            }
            set {
                this.longDescField = value;
            }
        }
        
        /// <remarks/>
        public string StockUom {
            get {
                return this.stockUomField;
            }
            set {
                this.stockUomField = value;
            }
        }
        
        /// <remarks/>
        public string SupCatalogueNum {
            get {
                return this.supCatalogueNumField;
            }
            set {
                this.supCatalogueNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GrnItem")]
        public PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItem[] GrnItem {
            get {
                return this.grnItemField;
            }
            set {
                this.grnItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItem {
        
        private string grnField;
        
        private string grnReceiptDateField;
        
        private string supplierField;
        
        private string supplierNameField;
        
        private string contactField;
        
        private string telephoneField;
        
        private string faxField;
        
        private string onHoldField;
        
        private string purchaseOrderField;
        
        private string purchaseOrderLinField;
        
        private string supDelNoteField;
        
        private string certificateField;
        
        private string versionField;
        
        private string releaseField;
        
        private string jobField;
        
        private string inspNarrationField;
        
        private string lctFlagField;
        
        private string lotField;
        
        private string expiryDateField;
        
        private string qtyOnSiteField;
        
        private string qtyOffSiteField;
        
        private string committedValueField;
        
        private string qtyAdvisedField;
        
        private string qtyInspectedField;
        
        private string qtyCountedField;
        
        private string countCompletedField;
        
        private string inspectionCompletedField;
        
        private string qtyAcceptedField;
        
        private string qtyScrappedField;
        
        private string qtyRejectedField;
        
        private string poPriceField;
        
        private string priceFactorField;
        
        private string priceUomField;
        
        private string convFactPriceUomField;
        
        private string orderFactorField;
        
        private string orderUomField;
        
        private string convFactOrdUomField;
        
        private string discLPct1Field;
        
        private string discLPct2Field;
        
        private string discLPct3Field;
        
        private string discLValFlagField;
        
        private string discLValueField;
        
        private PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemTransactionDetail[] transactionDetailField;
        
        private PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemSerialItem serialItemField;
        
        /// <remarks/>
        public string Grn {
            get {
                return this.grnField;
            }
            set {
                this.grnField = value;
            }
        }
        
        /// <remarks/>
        public string GrnReceiptDate {
            get {
                return this.grnReceiptDateField;
            }
            set {
                this.grnReceiptDateField = value;
            }
        }
        
        /// <remarks/>
        public string Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierName {
            get {
                return this.supplierNameField;
            }
            set {
                this.supplierNameField = value;
            }
        }
        
        /// <remarks/>
        public string Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        public string Telephone {
            get {
                return this.telephoneField;
            }
            set {
                this.telephoneField = value;
            }
        }
        
        /// <remarks/>
        public string Fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }
        
        /// <remarks/>
        public string OnHold {
            get {
                return this.onHoldField;
            }
            set {
                this.onHoldField = value;
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
        public string PurchaseOrderLin {
            get {
                return this.purchaseOrderLinField;
            }
            set {
                this.purchaseOrderLinField = value;
            }
        }
        
        /// <remarks/>
        public string SupDelNote {
            get {
                return this.supDelNoteField;
            }
            set {
                this.supDelNoteField = value;
            }
        }
        
        /// <remarks/>
        public string Certificate {
            get {
                return this.certificateField;
            }
            set {
                this.certificateField = value;
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
        public string Job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        public string InspNarration {
            get {
                return this.inspNarrationField;
            }
            set {
                this.inspNarrationField = value;
            }
        }
        
        /// <remarks/>
        public string LctFlag {
            get {
                return this.lctFlagField;
            }
            set {
                this.lctFlagField = value;
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
        public string ExpiryDate {
            get {
                return this.expiryDateField;
            }
            set {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        public string QtyOnSite {
            get {
                return this.qtyOnSiteField;
            }
            set {
                this.qtyOnSiteField = value;
            }
        }
        
        /// <remarks/>
        public string QtyOffSite {
            get {
                return this.qtyOffSiteField;
            }
            set {
                this.qtyOffSiteField = value;
            }
        }
        
        /// <remarks/>
        public string CommittedValue {
            get {
                return this.committedValueField;
            }
            set {
                this.committedValueField = value;
            }
        }
        
        /// <remarks/>
        public string QtyAdvised {
            get {
                return this.qtyAdvisedField;
            }
            set {
                this.qtyAdvisedField = value;
            }
        }
        
        /// <remarks/>
        public string QtyInspected {
            get {
                return this.qtyInspectedField;
            }
            set {
                this.qtyInspectedField = value;
            }
        }
        
        /// <remarks/>
        public string QtyCounted {
            get {
                return this.qtyCountedField;
            }
            set {
                this.qtyCountedField = value;
            }
        }
        
        /// <remarks/>
        public string CountCompleted {
            get {
                return this.countCompletedField;
            }
            set {
                this.countCompletedField = value;
            }
        }
        
        /// <remarks/>
        public string InspectionCompleted {
            get {
                return this.inspectionCompletedField;
            }
            set {
                this.inspectionCompletedField = value;
            }
        }
        
        /// <remarks/>
        public string QtyAccepted {
            get {
                return this.qtyAcceptedField;
            }
            set {
                this.qtyAcceptedField = value;
            }
        }
        
        /// <remarks/>
        public string QtyScrapped {
            get {
                return this.qtyScrappedField;
            }
            set {
                this.qtyScrappedField = value;
            }
        }
        
        /// <remarks/>
        public string QtyRejected {
            get {
                return this.qtyRejectedField;
            }
            set {
                this.qtyRejectedField = value;
            }
        }
        
        /// <remarks/>
        public string PoPrice {
            get {
                return this.poPriceField;
            }
            set {
                this.poPriceField = value;
            }
        }
        
        /// <remarks/>
        public string PriceFactor {
            get {
                return this.priceFactorField;
            }
            set {
                this.priceFactorField = value;
            }
        }
        
        /// <remarks/>
        public string PriceUom {
            get {
                return this.priceUomField;
            }
            set {
                this.priceUomField = value;
            }
        }
        
        /// <remarks/>
        public string ConvFactPriceUom {
            get {
                return this.convFactPriceUomField;
            }
            set {
                this.convFactPriceUomField = value;
            }
        }
        
        /// <remarks/>
        public string OrderFactor {
            get {
                return this.orderFactorField;
            }
            set {
                this.orderFactorField = value;
            }
        }
        
        /// <remarks/>
        public string OrderUom {
            get {
                return this.orderUomField;
            }
            set {
                this.orderUomField = value;
            }
        }
        
        /// <remarks/>
        public string ConvFactOrdUom {
            get {
                return this.convFactOrdUomField;
            }
            set {
                this.convFactOrdUomField = value;
            }
        }
        
        /// <remarks/>
        public string DiscLPct1 {
            get {
                return this.discLPct1Field;
            }
            set {
                this.discLPct1Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscLPct2 {
            get {
                return this.discLPct2Field;
            }
            set {
                this.discLPct2Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscLPct3 {
            get {
                return this.discLPct3Field;
            }
            set {
                this.discLPct3Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscLValFlag {
            get {
                return this.discLValFlagField;
            }
            set {
                this.discLValFlagField = value;
            }
        }
        
        /// <remarks/>
        public string DiscLValue {
            get {
                return this.discLValueField;
            }
            set {
                this.discLValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransactionDetail")]
        public PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemTransactionDetail[] TransactionDetail {
            get {
                return this.transactionDetailField;
            }
            set {
                this.transactionDetailField = value;
            }
        }
        
        /// <remarks/>
        public PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemSerialItem SerialItem {
            get {
                return this.serialItemField;
            }
            set {
                this.serialItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemTransactionDetail {
        
        private string trnTypeField;
        
        private string trnQtyField;
        
        private string documentNumField;
        
        private string concessionNumField;
        
        private string returnSupFlagField;
        
        private string returnSupplierField;
        
        private string rejectScrapCodeField;
        
        private string rejectNarrationField;
        
        private string scrapGLCodeField;
        
        /// <remarks/>
        public string TrnType {
            get {
                return this.trnTypeField;
            }
            set {
                this.trnTypeField = value;
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
        public string DocumentNum {
            get {
                return this.documentNumField;
            }
            set {
                this.documentNumField = value;
            }
        }
        
        /// <remarks/>
        public string ConcessionNum {
            get {
                return this.concessionNumField;
            }
            set {
                this.concessionNumField = value;
            }
        }
        
        /// <remarks/>
        public string ReturnSupFlag {
            get {
                return this.returnSupFlagField;
            }
            set {
                this.returnSupFlagField = value;
            }
        }
        
        /// <remarks/>
        public string ReturnSupplier {
            get {
                return this.returnSupplierField;
            }
            set {
                this.returnSupplierField = value;
            }
        }
        
        /// <remarks/>
        public string RejectScrapCode {
            get {
                return this.rejectScrapCodeField;
            }
            set {
                this.rejectScrapCodeField = value;
            }
        }
        
        /// <remarks/>
        public string RejectNarration {
            get {
                return this.rejectNarrationField;
            }
            set {
                this.rejectNarrationField = value;
            }
        }
        
        /// <remarks/>
        public string ScrapGLCode {
            get {
                return this.scrapGLCodeField;
            }
            set {
                this.scrapGLCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemSerialItem {
        
        private string serialField;
        
        private string statusField;
        
        private string quantityField;
        
        private string versionField;
        
        private string releaseField;
        
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
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
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
    }
}
